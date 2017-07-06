using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Services;

namespace PorpoiseMobileApp.ViewModels
{
	public class LogPostOrganizationViewModel : PorpoiseViewModel<LogPostOrganizationViewModel>
	{
		private List<Organisation> _organisations;

		byte[] _bytes;

		private Organisation _org;

		private string _photoUrl;

		private ISettings _settings;
		private IPorpoiseWebApiClient client;
		private IMvxCommand _backCommand;
        private IImageRotateService _rotator;
		private IMvxCommand _cancelCommand;

		private Models.Company _company;
		private DateTime _date;

		private bool _isValid;

		private bool _inFlight;

		private IImageService _imageService;

		private string _photoContentType;

		private const string BUCKET_NAME = "production-mobileuploads";

		private string _photoKeyName;

		public event EventHandler<SdkEventArgs> UploadAssetEvent;

		public event EventHandler<SdkEventArgs> LogHoursEvent;

		IMvxCommand _logHoursCommand;

		private double _contributionAmount;
		private string _fileName;
		private string _fileSize;
		private DateTime _updatedTime;
		private string _highlight;
		private List<Goal> _goals;
		private string _organisationRequired;
		public event EventHandler<SdkEventArgs> UpdateLogEvent;

		private bool _isEditing;
		private string _numberMetricLabel;

		private Guid _postId;

		private IMvxCommand _updateLogCommand;

		private string companyName;

		private bool _metricRequired = true;

		private bool _alert;

		private string _alertMessage;

		public string AlertMessage{

			get{

				return _alertMessage;
			}
			set{

				_alertMessage = value;

			}

		}

		public bool Alert{

			get{

				return _alert;
			}
			set{

				_alert = value;
				RaisePropertyChanged(() => Alert);
			}

		}

		public bool MetricRequired{

			get{

				return _metricRequired;

			}
			set{
				_metricRequired = value;

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

		public string NumberMetricLabel
		{

			get
			{

				return _numberMetricLabel;

			}

			set
			{

				_numberMetricLabel = value;
				RaisePropertyChanged(() => NumberMetricLabel);
				RaisePropertyChanged(() => InFlight);

			}

		}

		private string _removeConstraints;

		public string RemoveConstraints
		{

			get
			{

				return _removeConstraints;

			}

			set
			{

				_removeConstraints = value;

				RaisePropertyChanged(() => RemoveConstraints);
			}

		}

		public bool IsEditing
		{

			get
			{

				return _isEditing;

			}
			set
			{

				_isEditing = value;
				RaisePropertyChanged(() => IsEditing);
			}

		}

		private string _companyName;

		public string CompanyName
		{

			get
			{

				return _companyName;

			}
			set
			{

				_companyName = value;

				RaisePropertyChanged(() => CompanyName);

			}

		}

		public string OrganisationRequired
		{

			get
			{

				return _organisationRequired;

			}
			set
			{
				_organisationRequired = value;
				RaisePropertyChanged(() => OrganisationRequired);
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
		public double ContributionAmount
		{
			get
			{

				return _contributionAmount;
			}
			set
			{
				_contributionAmount = value;
				RaisePropertyChanged(() => ContributionAmount);
				RaisePropertyChanged(() => isValid);
				//TODO enable this
				//RaisePropertyChanged(() => LogHoursCommand);
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


			}

		}

		private string _photoS3Url;

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

		public bool isValid
		{

			get
			{
				return _isValid;
			}
			set
			{

				_isValid = value;
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

		private bool isWebPost(string url){

			if(url.Contains("porpoise-production")){

				return true;

			}

			return false;

		}

		private string GetWebAppKeyname(string url){
			char[] array = new char[1];

			array[0] = '/';

			url.Split(array[0]);

			bool start = false;

			string result = "";

			foreach(string aux in url.Split(array[0])){

				if (start)
				{

					result = result + aux + "/";

				}

				if(aux.Equals("porpoise-production.s3.amazonaws.com")){


					start = true;

				}



			}


			if(result.Contains("?")){

				int index = 0;

				index = result.IndexOf("?");
				if (index != 0)
				{
					result = result.Substring(0, index);
				}
			}
			Debug.WriteLine("RESULT: " + result);
			return result;

		}

		public async Task<byte[]> GetImageBytes(string keyname, bool postType)
		{
			
			Stream pictureStream = await _imageService.DownloadImage(keyname, postType);
			byte [] bytes = new byte[pictureStream.Length];

			pictureStream.Read(bytes, 0, (int)pictureStream.Length);
			return bytes;
		}

		public string GetKeyName(string photoUrl)
		{
			var split = photoUrl.Split('/');
			var keyname = $"{split.ElementAt(3)}/{split.ElementAt(4)}";
			return keyname;
		}




		public async void Init(EditParameters editParams)
		{
			//Todo IsValid should be aa method
			InFlight = true;

			isValid = true;
			await this.GetOrganisations();
			this.IsEditing = !Equals(Guid.Empty, editParams.PostId);
			// Is Editing
			if (IsEditing)
			{
				Debug.WriteLine("ISEDITING");
				LogPost.isEditing = true;

				Debug.WriteLine("IS EDITING INSIDE LOGPOSTVIEWCONTROLLER " + editParams.PostId.ToString());

				//Get Post

				var post = await client.GetPost(editParams.PostId);

				LogPost.editingPost = post;

				this.PhotoUrl = post.Payload.PhotoUrl;
				if (this.PhotoUrl != null && !string.IsNullOrEmpty(this.PhotoUrl) && !this.PhotoUrl.Equals("https://s3.amazonaws.com/porpoise-cdn/default_photo_placeholder.png"))
				{
					Debug.WriteLine("PHOTO URL IN EDITING " + this.PhotoUrl);
					//Debug.WriteLine(this.GetWebAppKeyname(this.PhotoUrl));
					//Bytes = await GetImageBytes(GetKeyName(this.PhotoUrl));
					if (this.isWebPost(this.PhotoUrl))
					{
						Bytes = await GetImageBytes(this.GetWebAppKeyname(this.PhotoUrl), this.isWebPost(this.PhotoUrl));
					}
					else
					{
						Bytes = await GetImageBytes(this.GetKeyName(this.PhotoUrl), this.isWebPost(this.PhotoUrl));

					}
				}
				LogPost.image = Bytes;

				if (post != null && post.Successful)
				{
					var goals = await client.GetCompanyGoals();

					Goal goal = null;

					if (goals != null && goals.Successful)
					{

						foreach (Goal aux in goals.Goals)
						{

							if (aux.Id.Value == post.Payload.GoalUid.Value)
							{

								goal = aux;

								Debug.WriteLine("Goal Found");

								break;

							}

						}

					}
					this.PostId = post.Payload.Id.Value;
					LogPost.goal = goal;

					LogPost.highlight = post.Payload.Highlight;

					if (goal != null && goal.IsRequired != null && goal.IsRequired.Value)
					{

						this.OrganisationRequired = "Organization Impacted (required)";

					}
					else
					{

						this.OrganisationRequired = "Organization Impacted (optional)";

					}

					if (!string.IsNullOrEmpty(post.Payload.GoalMetric) && !post.Payload.GoalMetric.ToLower().Equals("other"))
					{

						this.NumberMetricLabel = "Number of " + post.Payload.GoalMetric;
					}
					else
					{

						this.NumberMetricLabel = "Number of " + post.Payload.otherGoalMetricLabel;

					}

					this.Date = post.Payload.Date.Value;

					this.Highlight = post.Payload.Highlight;

					this.Organisation = Organisations?.FirstOrDefault(x => x.Name == post.Payload.OrganisationName);

					this.RemoveConstraints = "remove";

					LogPost.highlight = post.Payload.Highlight;

					Debug.WriteLine("LOGPOST HIGHTLIGHT " + LogPost.highlight);

					if (post.Payload.ContributionAmount != null)
					{
						this.ContributionAmount = post.Payload.ContributionAmount.Value;
					}
					else
					{
						if (post.Payload.NumberOfHours != null)
						{
							this.ContributionAmount = post.Payload.NumberOfHours.Value;
						}
					}

				}
                RaisePropertyChanged(() => IsEditing);
			}

			else if (LogPost.isEditing)
			{

				Debug.WriteLine("IS EDITING LOGPOST");

				this.Bytes = LogPost.image;

				var post = LogPost.editingPost;

				this.IsEditing = true;

				this.PhotoUrl = post.Payload.PhotoUrl;
				if(!LogPost.photoChanged)
				{
					if (this.PhotoUrl != null && !string.IsNullOrEmpty(this.PhotoUrl) && !this.PhotoUrl.Equals("https://s3.amazonaws.com/porpoise-cdn/default_photo_placeholder.png"))
					{
						Debug.WriteLine("PHOTO URL IN EDITING " + this.PhotoUrl);
						//Debug.WriteLine(this.GetWebAppKeyname(this.PhotoUrl));
						//Bytes = await GetImageBytes(GetKeyName(this.PhotoUrl));
						if (this.isWebPost(this.PhotoUrl))
						{
							Bytes = await GetImageBytes(this.GetWebAppKeyname(this.PhotoUrl), this.isWebPost(this.PhotoUrl));
						}
						else
						{
							Bytes = await GetImageBytes(this.GetKeyName(this.PhotoUrl), this.isWebPost(this.PhotoUrl));

						}
					}

					LogPost.image = Bytes;
				}
				else{

					Bytes = LogPost.image;

				}
				if (post != null && post.Successful)
				{
					var goals = await client.GetCompanyGoals();

					Goal goal = null;

					if (goals != null && goals.Successful)
					{

						foreach (Goal aux in goals.Goals)
						{

							if (aux.Id.Value == post.Payload.GoalUid.Value)
							{

								goal = aux;

								Debug.WriteLine("Goal Found");

								break;

							}

						}

					}
					this.PostId = post.Payload.Id.Value;
					LogPost.goal = goal;

					LogPost.highlight = post.Payload.Highlight;

					if (goal != null && goal.IsRequired != null && goal.IsRequired.Value)
					{

						this.OrganisationRequired = "Organization Impacted (required)";

					}
					else
					{

						this.OrganisationRequired = "Organization Impacted (optional)";

					}

					if (!string.IsNullOrEmpty(post.Payload.GoalMetric) && !post.Payload.GoalMetric.ToLower().Equals("other"))
					{

						this.NumberMetricLabel = "Number of " + post.Payload.GoalMetric;
					}
					else
					{

						this.NumberMetricLabel = "Number of " + post.Payload.otherGoalMetricLabel;

					}

					this.Date = post.Payload.Date.Value;

					this.Highlight = post.Payload.Highlight;

					this.Organisation = Organisations?.FirstOrDefault(x => x.Name == post.Payload.OrganisationName);

					this.RemoveConstraints = "remove";

					LogPost.highlight = post.Payload.Highlight;

					Debug.WriteLine("LOGPOST HIGHTLIGHT " + LogPost.highlight);

					if (post.Payload.ContributionAmount != null)
					{
						this.ContributionAmount = post.Payload.ContributionAmount.Value;
					}
					else
					{
						if (post.Payload.NumberOfHours != null)
						{
							this.ContributionAmount = post.Payload.NumberOfHours.Value;
						}
					}

				}
                RaisePropertyChanged(() => IsEditing);
			}

			//Not Editing
			else
			{

				//Add Description inital text
                RaisePropertyChanged(() => IsEditing);
				this.Highlight = "Add a description";

				Debug.WriteLine("NOT EDITING");
				if (LogPost.goal != null)
				{

					if (LogPost.goal.IsRequired.Value)
					{

						this.OrganisationRequired = "Organization Impacted (required)";

					}
					else
					{

						this.OrganisationRequired = "Organization Impacted (optional)";

					}

				}

				//_date = DateTime.Today;


				if (LogPost.image != null)
				{

					this.Bytes = LogPost.image;


					Debug.WriteLine("IMAGE IS NOT NULL, CHANGED "+Bytes.Length);

                    RaiseAllPropertiesChanged();

				}
				else
				{

					Bytes = null;

				}

               

				if (!LogPost.goal.MetricName.ToLower().Equals("other"))
				{

					this.NumberMetricLabel = "Number of " + LogPost.goal.MetricName;
				}
				else
				{

					this.NumberMetricLabel = "Number of " + LogPost.goal.otherGoalMetricLabel;

				}


				this.RemoveConstraints = "noRemove";

				_date = DateTime.Today;
			}

			Debug.WriteLine("INITIALIZING LogPostOrganizationViewModel VIEW MODEL");

			var employee = await client.GetEmployee();

			if (employee != null && employee.Successful)
			{

                Debug.WriteLine("EMPLOYEE UPDATED");

				CompanyName = "Allow " + employee.Payload.CompanyName + " to share to their social accounts?";

                Debug.WriteLine("Company Name Changed "+CompanyName);
			}

			var result = await client.GetCompanyGoals();

			if (result != null && result.Successful)
			{

				_goals = result.Payload;
			}

			InFlight = false;
		}

		public IMvxCommand BackCommand
		{

			get
			{
				_backCommand = _backCommand ?? new MvxCommand(this.Back);
				return _backCommand;

			}

		}

		public IMvxCommand CancelCommand { 
		
			get {

				_cancelCommand = _cancelCommand ?? new MvxCommand(this.Cancel);

				return _cancelCommand;
					
			
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
				//RaisePropertyChanged(() => isValid);
				//RaisePropertyChanged(() => LogHoursCommand);
			}
		}

		public void Back() {

            var param = new System.Collections.Generic.Dictionary<string, string>();
            if (LogPost.goal != null)
            {
                param.Add("goal", LogPost.goal.Id.Value.ToString());
            }
            ShowViewModel<LogHourPhotoViewModel>(param);
			
		
		}

		public void Cancel() { 
		
			ShowViewModel<HomeViewModel>();
		
		}

		public event EventHandler<SdkEventArgs> GetOrgsEvent;

		public Models.Company Company { 
		
			get {

				return _company;
			
			}
			set {

				_company = value;
			
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

		public async Task GetOrganisations()
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

		public byte[] Bytes {

			get {

				return _bytes;
			
			}
			set {

				_bytes = value;
				RaisePropertyChanged(() => Bytes);
			}
		
		}
		
		public  LogPostOrganizationViewModel(IPorpoiseWebApiClient client)
		{
			this.client = client;

			this._settings = Mvx.Resolve<ISettings>();

			this._imageService = Mvx.Resolve<IImageService>();

            this._rotator = Mvx.Resolve<IImageRotateService>();

			this.InFlight = true;
		}

		public async void LoadCompany() {
			InFlight = true;
			var employee =  await this.client.getEmployeeRow(AccountInfo.UserId.Value);

			if (employee != null && employee.Successful) {


			
			}

		
		}

		private async Task RotateRightPicture()
		{

			try
			{
                int degrees = 0;
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

                LogPost.image = bytes;

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

		public Organisation Organisation
		{
			get
			{
				
				return _org;
			}
			set
			{
				
				_org = value;
				//Debug.WriteLine("CHANGING ORGANISATION "+_org.Name);
				RaisePropertyChanged(() => Organisation);
				//RaisePropertyChanged(() => isValid);
				//RaisePropertyChanged(() => LogHoursCommand);
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

		public IMvxCommand LogHoursCommand
		{
			get
			{
				return _logHoursCommand ?? (_logHoursCommand = new MvxCommand(this.performOperation, () => !InFlight));

			
			}
		}


		public IMvxCommand UpdateLogCommand
		{
			get
			{
				Debug.WriteLine("UPDATING");
				return _updateLogCommand ?? (_updateLogCommand = new MvxCommand(PerformUpdateLog, () => !InFlight));
			}
		}


		private bool checkValidation()
		{
			//Empty description
			if(string.IsNullOrEmpty(LogPost.highlight)){
				this.AlertMessage = "Enter a valid highlight";
				return false;

			}
			//Check if metric is required
			if (LogPost.goal != null) {

				if (string.IsNullOrEmpty(LogPost.goal.MetricName) || LogPost.goal.MetricName.ToLower().Equals("none")) {

					this.MetricRequired = false;
				
				}
			
			}

			Debug.WriteLine("METRIC REQUIRED: "+this.MetricRequired);

			if (LogPost.goal != null && this.MetricRequired)
				{
					if (this.ContributionAmount <= 0)
					{
						this.AlertMessage = "Enter a valid value for contribution";
						return false;

					}
					if (LogPost.goal.IsRequired.Value)
					{

						//Check Date, metric and organisation
						{
						

							if (this.Date != null && this.Organisation != null && !string.IsNullOrEmpty(LogPost.highlight))
							{
								return true;

							}

						}


					}
					else
					{

						if (this.Date != null && !string.IsNullOrEmpty(LogPost.highlight))
						{

							return true;

						}

					}

				}
				else if (LogPost.goal != null && !this.MetricRequired)
				{


					if (LogPost.goal.IsRequired.Value)
					{

						//Check Date, metric and organisation
						{

							if (this.Date != null && this.Organisation != null && !string.IsNullOrEmpty(LogPost.highlight))
							{
								return true;

							}

						}


					}
					else
					{

						if (this.Date != null && !string.IsNullOrEmpty(LogPost.highlight))
						{

							return true;

						}

					}

				}
			if(this.Date == null){

				this.AlertMessage = "Enter a valid date";

			}
			else if(string.IsNullOrEmpty(LogPost.highlight)){

				this.AlertMessage = "Enter a valid highlight";

			}
			else if(this.Organisation == null){

				this.AlertMessage = "Enter a valid Organization";

			}
				return false;
		}



		private async void PerformUpdateLog()
		{
			LogPost.highlight = this.Highlight;

			if (this.Highlight.Equals("Add a description")) {

				this.Highlight = "";

				LogPost.highlight = "";
			}

			isValid = this.checkValidation();

			if (!isValid)
			{
				Debug.WriteLine("invalid");
				RaiseAllPropertiesChanged();
				PerformUpdateLogEvent(false, Resource.InvalidFieldsError);
				this.Alert = true;
			}
			else
			{
				
				if(LogPost.isEditing && LogPost.photoChanged && LogPost.image != null){

					InFlight = true;

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

				try
					{
						Debug.WriteLine("UPDATING POST");
						if (!string.IsNullOrEmpty(PhotoUrl) && this.Organisation != null)
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
									GoalId = LogPost.goal.Id.Value,
									Highlight = LogPost.highlight,
									//TODO: Change fixed value by this.HourAmount
									PostContributionAmount = this.ContributionAmount,
									NumberOfHours = this.ContributionAmount,
									//PostContributionAmount = this.ContributionAmount,
									OrganisationName = this.Organisation.Name,
									PostId = this.PostId
								});
								if (response.Successful)
								{
									PerformUpdateLogEvent(true, Resource.HoursUpdatedSuccess);
									ShowViewModel<HomeViewModel>();
								}
								else
								{
									Debug.WriteLine("Exception " + response.Message);
									PerformUpdateLogEvent(false, Resource.HoursUpdatedError);
								}
							}
							InFlight = false;
						}
						else if (this.Organisation == null)
						{
							//Optional Organisation
							if (client != null)
							{
								//update log to api
								var response = await client.UpdateLogHours(new LogHoursRequestModel
								{
									FileName = this.FileName,
									//PhotoContentType = this.PhotoContentType,
									//PhotoFileSize = this.PhotoFileSize,
									PhotoS3Url = this.PhotoUrl,
									PhotoUpdatedTime = this.PhotoUpdatedTime,
									Date = this.Date,
									GoalId = LogPost.goal.Id.Value,
									Highlight = LogPost.highlight,
									//TODO: Change fixed value by this.HourAmount
									PostContributionAmount = this.ContributionAmount,
									NumberOfHours = this.ContributionAmount,
									//PostContributionAmount = this.ContributionAmount,
									//OrganisationName = this.Organisation.Name,
									PostId = this.PostId
								});
								if (response.Successful)
								{
									PerformUpdateLogEvent(true, Resource.HoursUpdatedSuccess);
									ShowViewModel<HomeViewModel>();
								}
								else
								{
									Debug.WriteLine("Exception " + response.Message);
									PerformUpdateLogEvent(false, Resource.HoursUpdatedError);
								}
							}
							InFlight = false;

						}
					}
					catch (Exception ex)
					{
						Debug.WriteLine("Exception " + ex.Message);
						PerformUpdateLogEvent(false, ex.Message);
					}
			}

		}

		//Navigate to pick photo when editing a post
		public void NavigatePickPhoto(){

			LogPost.image = null;

			ShowViewModel<LogHourPhotoViewModel>();

		}

		public void performOperation() {

			if (IsEditing)
			{

				 this.PerformUpdateLog();

			}
			else {

				 this.PerformLogHours();
			
			}
		
		}
        private int degrees = 0;
		private async Task RotateLeftPicture()
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
					this.Bytes = bytes;
                    LogPost.image = bytes;
					//PictureTaken = true;

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

		//Log Hours

		private async void PerformLogHours()
		{
			this.PhotoUrl = null;
			this.PhotoContentType = "none";
			LogPost.highlight = this.Highlight;
			if (this.Highlight.Equals("Add a description")) {

				this.Highlight = "";

				LogPost.highlight = "";
			
			}
			InFlight = true;
			Debug.WriteLine("LOGIN HOURS");
			isValid = this.checkValidation();
			string organizationName = "";



			if (this.Organisation == null){

				organizationName = "";
			}
			else {

				organizationName = this.Organisation.Name;
			
			}
			if (!isValid)
			{
				Debug.WriteLine("INVALID");
				RaiseAllPropertiesChanged();
				//TODO Enable this
				//PerformLogHoursEvent(false, Resource.InvalidFieldsError);
				Alert = true;
				InFlight = false;
			}
			else
			{
				try
				{
					
					// Save Image
					if (Bytes != null)
					{

                      
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

				}
				catch (ArgumentNullException ex)
				{
					Debug.WriteLine("NULL IMAGE "+ex.Message);
					//TODO enable this
					//PerformLogHoursEvent(false, Resource.MissingUploadedImage);
					return;
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Exeption "+ex.Message);
					//TODO enable this
					//PerformLogHoursEvent(false, ex.Message);
					return;
				}

				try
				{
					Debug.WriteLine("BEFORE SUBMITTING CONTRIBUTION AMOUNT "+this.ContributionAmount);
						var response = await client.PostLogHours(new LogHoursRequestModel
						{
							FileName = this.FileName,
							PhotoContentType = "image/jpeg",
							PhotoFileSize = this.PhotoFileSize,
							PhotoS3Url = this.PhotoUrl,
							PhotoUpdatedTime = this.PhotoUpdatedTime,
							Date = this.Date,
							GoalId = LogPost.goal.Id.Value,
						    Highlight = LogPost.highlight,
						    NumberOfHours = this.ContributionAmount,
						    PostContributionAmount = this.ContributionAmount,
							OrganisationName = organizationName

						});
						if (response.Successful)
						{
							Debug.WriteLine("LOG HOURS RESPONSE SUCCESSFUL");
							//TODO: may not need this bit but putting it here for now since these values are null since the response doesn't send these back.
							response.Payload.Goal = Goals.FirstOrDefault(x => x.Id == LogPost.goal.Id);

						if (this.Organisation != null)
						{

							response.Payload.Organisation = Organisations.FirstOrDefault(x => x.Id == this.Organisation.Id);
						}
							PerformLogHoursEvent(true, Resource.HoursLoggedSuccess);
						}
						else
						{
							Debug.WriteLine("UNSUCCESFUL RESPONSE PHOTO URL");

							PerformLogHoursEvent(false, Resource.HoursLoggedError);
						}
						InFlight = false;

						ShowViewModel<HomeViewModel>();
					

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

	}
}
