using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.PictureChooser;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.ViewModels
{
	public class LogHourPhotoViewModel : PorpoiseViewModel<LogHourPhotoViewModel>
	{
		private ISettings _settings;
		private bool _inFlight;
		private readonly IMvxPictureChooserTask _pictureChooserTask;
		private byte[] _bytes;
		private bool _pictureTaken;
		private IMvxCommand _choosePictureCommand;
		private IMvxCommand _navigateNextView;
		private IMvxCommand _cancelCommand;
		private IMvxCommand _continueEditingCommand;
		private IMvxCommand _navigateContinueEditingCommand;
        private IMvxCommand _takePictureCommand;
		public event EventHandler<SdkEventArgs> UploadAssetEvent;
		public event EventHandler<SdkEventArgs> LogHoursEvent;
		private string _photoS3Url;
        IPorpoiseWebApiClient _client;


        private Guid postId;

        public Guid PostId{

            get{

                return postId;

            }

            set{

                postId = value;

                RaisePropertyChanged(()=> PostId);

            }

        }

		public LogHourPhotoViewModel(IPorpoiseWebApiClient client)
		{
			_client = client;
			this._pictureChooserTask = Mvx.Resolve<IMvxPictureChooserTask>();
			this._settings = Mvx.Resolve<ISettings>();
            //this._imageService = Mvx.Resolve<IImageService>();
            //this._rotator = Mvx.Resolve<IImageRotateService>();
          
		}

        protected async override void InitFromBundle(IMvxBundle parameters)
        {
            if(parameters.Data.ContainsKey("goal")){

                this.PostId = Guid.Parse(parameters.Data["goal"]);

                Debug.WriteLine("GOAL IN CAMERA IS NOT NULL");

				var list = await _client.GetCompanyGoals();

                if (list != null && list.Successful)
                {

                  List<Models.Goal> goalList = list.Goals;

                    foreach(Models.Goal goal in goalList){

                        if(goal.Id.Value.Equals(PostId)){

                            LogPost.goal = goal;

                            break;

                        }

                    }

                }
            }

            base.InitFromBundle(parameters);
        }


		public bool PictureTaken
		{
			get
			{
				return _pictureTaken;
			}
			private set
			{
				_pictureTaken = value;
				RaisePropertyChanged(() => PictureTaken);
			}
		}
		public bool InFlight
		{
			get
			{
				return _inFlight;
			}
			set
			{
				_inFlight = value;
				RaisePropertyChanged(() => InFlight);
				//RaisePropertyChanged(() => LogHoursCommand);
			}
		}
		public byte[] Bytes
		{
			get { return _bytes; }
			set
			{
				_bytes = value;
				RaisePropertyChanged(() => Bytes);
			}
		}
		private void OnPicture(Stream pictureStream)
		{
			var bytes = new byte[pictureStream.Length];
			pictureStream.Read(bytes, 0, (int)pictureStream.Length);
			Bytes = bytes;
            LogPost.image = bytes;
            if (LogPost.isEditing) {
				LogPost.imageChanged = true;
				//LogPost.photoChanged = true;
                this.navigateContinueEditing();

            }
            else
            {
                this.navigateOrganisationViewModel();
            }
			//PictureTaken = true;

		}

		public IMvxCommand CancelCommand { 
		
			get {
				_cancelCommand = _cancelCommand ?? new MvxCommand(this.NavigateCancel);
				return _cancelCommand;
			
			}
		
		}

		public IMvxCommand ContinueEditingCommand{

			get
			{
				_continueEditingCommand = _cancelCommand ?? new MvxCommand(this.ContinueEditing);
				return _continueEditingCommand;

			}

		}

		public IMvxCommand NavigateNextView { 
		
			get { 
			
				_navigateNextView = _choosePictureCommand ?? new MvxCommand(this.navigateOrganisationViewModel);
				return _navigateNextView;
			
			}
		
		}

		public IMvxCommand ChoosePictureCommand
		{
			get
			{
				_choosePictureCommand = _choosePictureCommand ?? new MvxCommand(PerformChoosePicture);
				return _choosePictureCommand;
			}
		}

		public IMvxCommand NavigateContinueEditiongCommand
		{
			get{

				_navigateContinueEditingCommand = _navigateContinueEditingCommand ?? new MvxCommand(navigateContinueEditing);
				return _navigateContinueEditingCommand;
			}
		}
		public void ContinueEditing(){
			LogPost.photoChanged = false;
			ShowViewModel<LogPostOrganizationViewModel>();

		}

		public void NavigateCancel() {
            if (this.PostId == null || string.IsNullOrEmpty(this.PostId.ToString()))
            {
                Debug.WriteLine("REDIRECTIRING NULL");

                ShowViewModel<ChallengeLogHourViewModel>();
            }
            else{

				Debug.WriteLine("REDIRECTIRING NOT NULL");

                IDictionary<string,string> dic = new Dictionary<string, string>();

                dic.Add("goal",this.PostId.ToString());

				ShowViewModel<ChallengeLogHourViewModel>(dic);

            }
		
		}
		public void PerformUploadPhotoEvent(bool success, string message = null)
		{
			if (UploadAssetEvent != null)
			{
				Debug.WriteLine("TRYING TO UPLOAD PHOTO");
				try
				{
					Debug.WriteLine("UPLOADING");
					UploadAssetEvent(this, new SdkEventArgs(success, message));

				}
				catch (Exception)
				{
					Debug.WriteLine("ERROR");
					LogHoursEvent(this, new SdkEventArgs(false, message));
				}
			}
		}
		public string PhotoUrl
		{
			get
			{

				return _photoS3Url;
			}
			set
			{
				_photoS3Url = value;
				RaisePropertyChanged(() => PhotoUrl);
				//RaisePropertyChanged(() => isValid);
				//RaisePropertyChanged(() => LogHoursCommand);
			}
		}
		private void PerformChoosePicture()
		{
			InFlight = true;
			try
			{
				_pictureChooserTask.ChoosePictureFromLibrary(400, 75, stream =>
				{
					OnPicture(stream);
					PerformUploadPhotoEvent(true);
				},
				() =>
				{
					// perform any cancelled operation
				});
				InFlight = false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine("CHOOSE PICTURE ERROR: " + ex);
				PerformUploadPhotoEvent(false, ex.Message);
			}
		}

		public void navigateOrganisationViewModel() {
			//Debug.WriteLine("BYTES SIZE: " + myByteArray.Length);

            ShowViewModel<LogPostOrganizationViewModel>();

		}

		public void navigateContinueEditing(){

			ShowViewModel<LogPostOrganizationViewModel>();

		}
		public async void DoTakePicture()
		{
			InFlight = true;
			try
			{
				_pictureChooserTask.TakePicture(400, 75, obj =>
			   {
				   OnPicture(obj);
				   //PerformUploadPhotoEvent(true);

			   },
				() =>
				{
					// perform any cancelled operation
				});
				InFlight = false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine("TAKE PICTURE ERROR: " + ex);
				PerformUploadPhotoEvent(false, ex.Message);
			}
		}
		public IMvxCommand TakePictureCommand
		{
			get
			{
				_takePictureCommand = _takePictureCommand ?? new MvxCommand(DoTakePicture);
				return _takePictureCommand;
			}
		}


	}

}
