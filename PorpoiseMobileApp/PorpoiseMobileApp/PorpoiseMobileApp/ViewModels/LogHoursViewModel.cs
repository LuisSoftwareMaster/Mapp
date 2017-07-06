using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.PictureChooser;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Models;
using System.Diagnostics;
using Amazon.CognitoIdentity;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using PorpoiseMobileApp.Services;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using MvvmCross.Plugins.Permissions;


namespace PorpoiseMobileApp.ViewModels
{
	public class LogHoursViewModel : PorpoiseViewModel<LogHoursViewModel>
	{
		private readonly IMvxPictureChooserTask _pictureChooserTask;
		private ISettings _settings;
		private IPorpoiseWebApiClient client;
		private IImageRotateService _rotator;
		private IImageService _imageService;
		private IMvxCommand _logHoursCommand;
		private IMvxCommand _updateLogCommand;
		private IMvxCommand _choosePictureCommand;
		private IMvxCommand _removeImageCommand;
		private IMvxCommand _takePictureCommand;
		private IMvxCommand _rotateLeftPictureCommand;
		private IMvxCommand _rotateRightPictureCommand;

		public event EventHandler<SdkEventArgs> GetOrgsEvent;
		public event EventHandler<SdkEventArgs> GetGoalsEvent;
		public event EventHandler<SdkEventArgs> LogHoursEvent;
		public event EventHandler<SdkEventArgs> UpdateLogEvent;
		public event EventHandler<SdkEventArgs> UploadAssetEvent;
		public event EventHandler<SdkEventArgs> RemoveImageEvent;
		public event EventHandler<SdkEventArgs> GetPostDetailsEvent;

		//testing

		private bool _isEditing;
		private bool _pictureTaken;
		private bool _inFlight;
		private double _hourAmount;
		private string _highlight;
		private Goal _goal;
		private List<Goal> _goals;
		private Organisation _org;
		private List<Organisation> _organisations;
		private Guid _postId;
		private string _photoS3Url;
		private DateTime _date;
		private string _fileName;
		private string _photoContentType;
		private string _fileSize;
		private DateTime _updatedTime;
		private string _photoKeyName;
		private byte[] _bytes;

		private const string BUCKET_NAME = "production-mobileuploads";


		public LogHoursViewModel(IPorpoiseWebApiClient client)
		{
			this.client = client;
			this._pictureChooserTask = Mvx.Resolve<IMvxPictureChooserTask>();
			this._settings = Mvx.Resolve<ISettings>();
			this._imageService = Mvx.Resolve<IImageService>();
			this._rotator = Mvx.Resolve<IImageRotateService>();
		}


		public async void Init(EditParameters editParams)
		{
			InFlight = true;
			this.IsEditing = !Equals(Guid.Empty, editParams.PostId);
			this.Date = DateTime.Today;

			try
			{
				//fill organisations drop down
				await GetOrganisations();

				//fill goals drop down
				await GetGoals();

				//if the user is editing, check if the PostId has been stored in the settings and get the Post details
				if (this.IsEditing)
				{
					var post = await client.GetPost(editParams.PostId);
					if (post != null && post.Successful)
					{
						this.Date = post.Payload.Date.Value;
						this.PhotoUrl = post.Payload.PhotoUrl;
						this.Highlight = post.Payload.Highlight;
						this.Goal = Goals.FirstOrDefault(x => x.Name == post.Payload.GoalName);
						this.Organisation = Organisations?.FirstOrDefault(x => x.Name == post.Payload.OrganisationName);
						this.HourAmount = post.Payload.NumberOfHours.Value;
						this.PostId = editParams.PostId;
						this.Bytes = await GetImageBytes(GetKeyName(this.PhotoUrl));

						PerformGetPostDetailsEvent(true);
					}
					else
					{
						PerformGetPostDetailsEvent(false, Resource.GetPostDetailsError);

					}
				}

				OrganisationsRetrieved = true;
				GoalsRetrieved = true;
				InFlight = false;
			}
			catch (PorpoiseException pex)
			{
				PerformGetPostDetailsEvent(false, Resource.GetPostDetailsError);

			}
			catch (Exception ex)
			{
				PerformGetPostDetailsEvent(false, ex.Message);
			}

		}

		public string GetKeyName(string photoUrl)
		{
			var split = photoUrl.Split('/');
			var keyname = $"{split.ElementAt(3)}/{split.ElementAt(4)}";
			return keyname;
		}


		async Task GetOrganisations()
		{
			try
			{
				var orgResult = await client.GetAllOrganisations();
				if (orgResult != null)
				{

					Organisations = orgResult.Organisations.Where(x => x.Id != null).OrderBy(x => x.Name).ToList();

				}
				else
				{
					Organisations = new List<Organisation>();
				}
				Organisations.Add(new Organisation
				{
					Name = Resource.Other
				});
			}
			catch (PorpoiseException)
			{
				PerformGetOrgs(false, Resource.ServerConnectionError);

			}
			catch (Exception ex)
			{
				PerformGetOrgs(false, ex.Message);
			}
		}

		async Task GetGoals()
		{
			try
			{
				var goalsResult = await client.GetCompanyGoals();
				if (goalsResult != null)
				{
					Goals = goalsResult.Goals.Where(x => x.Id != null).OrderBy(x => x.Name).ToList();
					GoalsRetrieved = true;
				}
				else
				{
					Goals = new List<Goal>();
				}

			}
			catch (PorpoiseException)
			{
				PerformGetGoals(false, Resource.ServerConnectionError);

			}
			catch (Exception ex)
			{
				PerformGetGoals(false, ex.Message);
			}
		}


		#region Properties
		public bool GoalsRetrieved { get; private set; }
		public bool OrganisationsRetrieved { get; private set; }
		public bool IsEditing
		{
			get
			{
				return _isEditing;
			}
			private set
			{
				_isEditing = value;
				RaisePropertyChanged(() => IsEditing);
			}
		}


		public bool isValid
		{//TODO: this.Bytes is the image check it is uploaded, uncomment this
			get
			{

				if (!string.IsNullOrEmpty(HourAmount.ToString()) && HourAmount > 0 && !string.IsNullOrEmpty(Highlight)
					&& Goal != null && Organisation != null && Validation.IsValidDate(Date.ToString())
					&& !this.Organisation.Name.Equals("Other", StringComparison.CurrentCultureIgnoreCase)
					&& !string.IsNullOrEmpty(this.Organisation.Name) && !string.IsNullOrEmpty(this.Goal.Name)
					&& !this.Organisation.Name.Equals(" ") && !this.Goal.Name.Equals(" ") && this.Bytes != null)
				{
					RaisePropertyChanged(() => isValid);
					return true;
				}

				else
				{
					RaisePropertyChanged(() => isValid);
					return false;
				}
			}

		}
		public void Logout()
		{

			_settings.Remove(AccountInfo.EMAILID);
			_settings.Remove(AccountInfo.PASSWORDID);
			_settings.Remove(AccountInfo.USERKEY);
			_settings.Remove(AccountInfo.TOKENKEY);
			//good place to add anylitics or segment calls saying the user logged out

			ShowViewModel<LoginViewModel>();
			//ShowViewModel<LoginViewModel>();
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


		public Guid PostId
		{
			get
			{
				return _postId;
			}
			set
			{
				_postId = value;
				RaisePropertyChanged(() => PostId);
			}
		}

		public List<Organisation> Organisations
		{
			get
			{
				return _organisations;
			}
			set
			{
				_organisations = value;
				RaisePropertyChanged(() => Organisations);
			}
		}
		public List<Goal> Goals
		{
			get
			{
				return _goals;
			}
			set
			{
				_goals = value;
				RaisePropertyChanged(() => Goals);
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
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public double HourAmount
		{
			get
			{

				return _hourAmount;
			}
			set
			{
				_hourAmount = value;
				RaisePropertyChanged(() => HourAmount);
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public DateTime Date
		{
			get
			{

				return _date;
			}
			set
			{
				_date = value;
				RaisePropertyChanged(() => Date);
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public string Highlight
		{
			get
			{

				return _highlight;
			}
			set
			{
				_highlight = value;
				RaisePropertyChanged(() => Highlight);
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public bool HighlightValid
		{
			get
			{
				return !string.IsNullOrEmpty(Highlight);
			}
		}

		public Organisation Organisation
		{
			get
			{

				return _org;
			}
			set
			{
				_org = value;
				RaisePropertyChanged(() => Organisation);
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public Goal Goal
		{
			get
			{

				return _goal;
			}
			set
			{
				_goal = value;
				RaisePropertyChanged(() => Goal);
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
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
				RaisePropertyChanged(() => isValid);
				RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public string FileName
		{
			get
			{

				return _fileName;
			}
			set
			{
				_fileName = value;
				RaisePropertyChanged(() => FileName);
			}
		}

		public string PhotoContentType
		{
			get
			{

				return _photoContentType;
			}
			set
			{
				_photoContentType = value;
				RaisePropertyChanged(() => PhotoContentType);
			}
		}

		public string PhotoFileSize
		{
			get
			{

				return _fileSize;
			}
			set
			{
				_fileSize = value;
				RaisePropertyChanged(() => PhotoFileSize);
			}
		}

		public DateTime PhotoUpdatedTime
		{
			get
			{

				return _updatedTime;
			}
			set
			{
				_updatedTime = value;
				RaisePropertyChanged(() => PhotoUpdatedTime);
			}
		}


		public string PhotoKeyName
		{
			get
			{
				return _photoKeyName;

			}
			set
			{
				_photoKeyName = value;
				RaisePropertyChanged(() => PhotoKeyName);
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

		#endregion

		public void ReturnToProfile()
		{
			ShowViewModel<HomeViewModel>();
		}


		private async void PerformLogHours()
		{
			Debug.WriteLine("LOGIN HOURS");
			if (!isValid)
			{
				Debug.WriteLine("INVALID");
				RaiseAllPropertiesChanged();
				PerformLogHoursEvent(false, Resource.InvalidFieldsError);
			}
			else
			{
				try
				{
					InFlight = true;
					// Save Image
					Stream stream = new MemoryStream(Bytes);
					stream.Seek(0, SeekOrigin.Begin);

					var keyName = AccountInfo.UserId.Value.ToString() + "/" + DateTime.Now.Ticks.ToString() + Resource.S3KeyNameEnd;

					var imageResponse = await _imageService.ProcessImage(keyName, stream);
					if (imageResponse.HttpStatusCode == System.Net.HttpStatusCode.OK)
					{
						this.PhotoUrl = "https://" + BUCKET_NAME + ".s3.amazonaws.com/" + keyName;
						Debug.WriteLine("PHOTOURL " + this.PhotoUrl);
						this.PhotoContentType = "image/jpeg";
						this.PhotoKeyName = keyName;

						// expect the stream to be disposed after immediately this method returns.
						PerformUploadPhotoEvent(true);
					}

				}
				catch (ArgumentNullException)
				{
					Debug.WriteLine("NULL IMAGE");
					PerformLogHoursEvent(false, Resource.MissingUploadedImage);
					return;
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Exeption");
					PerformLogHoursEvent(false, ex.Message);
					return;
				}

				try
				{
					if (!string.IsNullOrEmpty(PhotoUrl))
					{

						var response = await client.PostLogHours(new LogHoursRequestModel
						{
							FileName = this.FileName,
							PhotoContentType = this.PhotoContentType,
							PhotoFileSize = this.PhotoFileSize,
							PhotoS3Url = this.PhotoUrl,
							PhotoUpdatedTime = this.PhotoUpdatedTime,
							Date = this.Date,

							GoalId = this.Goal.Id.Value,
							Highlight = this.Highlight,
							NumberOfHours = this.HourAmount,
							OrganisationName = this.Organisation.Name

						});
						if (response.Successful)
						{
							//TODO: may not need this bit but putting it here for now since these values are null since the response doesn't send these back.
							response.Payload.Goal = Goals.FirstOrDefault(x => x.Id == this.Goal.Id);
							response.Payload.Organisation = Organisations.FirstOrDefault(x => x.Id == this.Organisation.Id);

							PerformLogHoursEvent(true, Resource.HoursLoggedSuccess);
						}
						else
						{
							Debug.WriteLine("UNSUCCESFUL RESPONSE PHOTO URL");
							PerformLogHoursEvent(false, Resource.HoursLoggedError);
						}
						InFlight = false;
					}

				}
				catch (PorpoiseException pex)
				{
					Debug.WriteLine("PORPOISE EXCEPTION");
					PerformLogHoursEvent(false, pex.Message);
				}
				catch (Exception ex)
				{
					Debug.WriteLine("GENERAL EXCEPTION");
					PerformLogHoursEvent(false, ex.Message);
				}

			}

		}

		private async void PerformUpdateLog()
		{
			if (!isValid)
			{
				RaiseAllPropertiesChanged();
				PerformUpdateLogEvent(false, Resource.InvalidFieldsError);
			}
			else
			{
				if (PictureTaken)
				{
					try
					{
						InFlight = true;
						// Save Image
						Stream stream = new MemoryStream(Bytes);
						this.Bytes = Bytes;
						stream.Seek(0, SeekOrigin.Begin);

						var keyName = $"{AccountInfo.UserId.Value.ToString()}/{DateTime.Now.Ticks.ToString()}{Resource.S3KeyNameEnd}";

						var imageResponse = await _imageService.ProcessImage(keyName, stream);
						if (imageResponse.HttpStatusCode == System.Net.HttpStatusCode.OK)
						{
							this.PhotoUrl = $"https://{BUCKET_NAME}.s3.amazonaws.com/{keyName}";
							this.PhotoContentType = "image/jpeg";
							this.PhotoKeyName = keyName;
							PerformUploadPhotoEvent(true);
						}

					}
					catch (ArgumentNullException)
					{
						PerformUpdateLogEvent(false, Resource.MissingUploadedImage);
						return;
					}
					catch (Exception ex)
					{
						PerformUpdateLogEvent(false, ex.Message);

					}
				}


				try
				{
					if (!string.IsNullOrEmpty(PhotoUrl))
					{
						if (client != null)
						{
							//update log to api
							var response = await client.UpdateLogHours(new LogHoursRequestModel
							{
								FileName = this.FileName,
								PhotoContentType = this.PhotoContentType,
								PhotoFileSize = this.PhotoFileSize,
								PhotoS3Url = this.PhotoUrl,
								PhotoUpdatedTime = this.PhotoUpdatedTime,
								Date = this.Date,
								GoalId = this.Goal.Id.Value,
								Highlight = this.Highlight,
								NumberOfHours = this.HourAmount,
								OrganisationName = this.Organisation.Name,
								PostId = this.PostId
							});
							if (response.Successful)
							{
								PerformUpdateLogEvent(true, Resource.HoursUpdatedSuccess);
							}
							else
							{
								PerformUpdateLogEvent(false, Resource.HoursUpdatedError);
							}
						}
						InFlight = false;
					}
				}
				catch (Exception ex)
				{
					PerformUpdateLogEvent(false, ex.Message);
				}
			}


		}

		private async void PerformRemoveImage()
		{
			try
			{
				var response = await _imageService.RemoveImage(this.PhotoKeyName);
				if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
				{
					PerformRemoveImageEvent(true);

				}
				else
				{
					PerformRemoveImageEvent(false, $"Error when trying to delete keyname {this.PhotoKeyName} from AWS S3");
				}
			}
			catch (Exception ex)
			{
				PerformRemoveImageEvent(false, $"Error when trying to delete keyname {this.PhotoKeyName} from AWS S3");
				Debug.WriteLine(ex.Message);
			}



		}


		private async void DoTakePicture()
		{
			InFlight = true;
			try
			{
				_pictureChooserTask.TakePicture(400, 75, obj =>
			   {
				   OnPicture(obj);
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
				Debug.WriteLine("TAKE PICTURE ERROR: " + ex);
				PerformUploadPhotoEvent(false, ex.Message);
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

		private int degrees = 0;
		private async void RotateLeftPicture()
		{
			try
			{
				if (Bytes != null)
				{
					degrees -= 90;
					Debug.WriteLine($"DEGREES {degrees}");
					degrees = degrees % 360;
					Debug.WriteLine($"degrees % 360 = {degrees}");

					Stream stream = new MemoryStream(Bytes);
					stream.Seek(0, SeekOrigin.Begin);
					var rotatedPic = await _rotator.Rotate(stream, false, Bytes, this.PhotoUrl, degrees);
					var bytes = new byte[rotatedPic.Length];
					rotatedPic.Seek(0, SeekOrigin.Begin);
					rotatedPic.Read(bytes, 0, (int)rotatedPic.Length);
					Bytes = bytes;
					PictureTaken = true;

				}
			}
			catch (PorpoiseException pe)
			{

				PerformUploadPhotoEvent(false, pe.Message);
			}
			catch (Exception)
			{
				PerformUploadPhotoEvent(false, Resource.ImageRotationError);
			}
		}


		private async void RotateRightPicture()
		{
			try
			{
				if (Bytes != null)
				{
					degrees += 90;
					Debug.WriteLine($"DEGREES {degrees}");
					degrees = degrees % 360;
					Debug.WriteLine($"degrees % 360 = {degrees}");

					Stream stream = new MemoryStream(Bytes);
					stream.Seek(0, SeekOrigin.Begin);
					var rotatedPic = await _rotator.Rotate(stream, true, Bytes, this.PhotoUrl, degrees);
					var bytes = new byte[rotatedPic.Length];
					rotatedPic.Seek(0, SeekOrigin.Begin);
					rotatedPic.Read(bytes, 0, (int)rotatedPic.Length);
					Bytes = bytes;
					PictureTaken = true;

				}
			}
			catch (PorpoiseException pe)
			{

				PerformUploadPhotoEvent(false, pe.Message);
			}
			catch (Exception)
			{
				PerformUploadPhotoEvent(false, Resource.ImageRotationError);
			}
		}


		//set the Bytes so the image is visible on the view, and can be manipulated (i.e. rotated and saved)
		private void OnPicture(Stream pictureStream)
		{
			var bytes = new byte[pictureStream.Length];
			pictureStream.Read(bytes, 0, (int)pictureStream.Length);
			Bytes = bytes;
			PictureTaken = true;

		}

		public async Task<byte[]> GetImageBytes(string keyname)
		{

            Stream pictureStream = await _imageService.DownloadImage(keyname, true);
			var bytes = new byte[pictureStream.Length];

			pictureStream.Read(bytes, 0, (int)pictureStream.Length);
			return bytes;
		}


		#region Command Declaration
		public IMvxCommand RotateLeftPictureCommand
		{
			get
			{
				_rotateLeftPictureCommand = _rotateLeftPictureCommand ?? new MvxCommand(RotateLeftPicture);
				return _rotateLeftPictureCommand;
			}
		}

		public IMvxCommand LogHoursCommand
		{
			get
			{
				return _logHoursCommand ?? (_logHoursCommand = new MvxCommand(PerformLogHours, () => !InFlight));
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

		public IMvxCommand UpdateLogCommand
		{
			get
			{
				return _updateLogCommand ?? (_updateLogCommand = new MvxCommand(PerformUpdateLog, () => !InFlight));
			}
		}


		public IMvxCommand RemoveImageCommand
		{
			get
			{
				return _removeImageCommand ?? (_removeImageCommand = new MvxCommand(PerformRemoveImage, () => !InFlight));
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

		public IMvxCommand RotateRightPictureCommand
		{
			get
			{
				_rotateRightPictureCommand = _rotateRightPictureCommand ?? new MvxCommand(RotateRightPicture);
				return _rotateRightPictureCommand;
			}
		}
		#endregion

		#region Events
		private void PerformGetPostDetailsEvent(bool success, string message = null)
		{
			if (GetPostDetailsEvent != null)
			{
				try
				{
					GetPostDetailsEvent(this, new SdkEventArgs(success, message));
				}
				catch
				{
				}
			}
		}



		private void PerformUpdateLogEvent(bool success, string message = null)
		{
			if (UpdateLogEvent != null)
			{
				try
				{
					UpdateLogEvent(this, new SdkEventArgs(success, message));

				}
				catch (Exception)
				{
					UpdateLogEvent(this, new SdkEventArgs(success, message));
				}
			}
		}

		private void PerformUploadPhotoEvent(bool success, string message = null)
		{
			if (UploadAssetEvent != null)
			{
				try
				{
					UploadAssetEvent(this, new SdkEventArgs(success, message));

				}
				catch (Exception)
				{
					LogHoursEvent(this, new SdkEventArgs(false, message));
				}
			}
		}
		private void PerformLogHoursEvent(bool success, string message = null)
		{
			if (LogHoursEvent != null)
			{
				try
				{
					LogHoursEvent(this, new SdkEventArgs(success, message));

				}
				catch (PorpoiseException pex)
				{
					LogHoursEvent(this, new SdkEventArgs(false, pex.Message));
				}
				catch (Exception)
				{
					LogHoursEvent(this, new SdkEventArgs(false, message));
				}
			}
		}
		private void PerformRemoveImageEvent(bool success, string message = null)
		{
			if (RemoveImageEvent != null)
			{
				try
				{
					RemoveImageEvent(this, new SdkEventArgs(success, message));

				}
				catch (Exception)
				{
					RemoveImageEvent(this, new SdkEventArgs(false, message));
				}
			}
		}

		private void PerformGetOrgs(bool success, string message = null)
		{
			if (GetOrgsEvent != null)
			{
				try
				{
					GetOrgsEvent(this, new SdkEventArgs(success, message));
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		private void PerformGetGoals(bool success, string message = null)
		{
			if (GetGoalsEvent != null)
			{
				try
				{
					GetGoalsEvent(this, new SdkEventArgs(success, message));
				}
				catch (Exception)
				{

					throw;
				}
			}
		}
		#endregion
	}
}