using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Acr.Settings;
using PorpoiseMobileApp.Client;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PorpoiseMobileApp.ViewModels
{
	public class ProfileViewModel : PorpoiseViewModel<ProfileViewModel>
	{
		private IMvxCommand _goEditLogCommand;
		private readonly string POSTKEY = "PostId";
		private bool _inFlight;
		private ISettings _settings;
		private string _profilePic;
		private string _name;
		private string _location;
		private double _totalHours;
		private List<Goal> _companyGoals;
		private double _progress;
		private List<HourLog> _latestPostList = new List<HourLog>();
		HourLog _latestPost;
		private IPorpoiseWebApiClient client;
		private string _fname;
		private string _lname;
		public Guid _deletePostId;
		private bool _isDeleting = false;

        private IMvxCommand _createPostCommand;

        private bool _reload = false;

        private string _goalName;

        public string GoalName{

            get{

                return _goalName;

            }
            set{

                _goalName = value;

                RaisePropertyChanged(()=> GoalName);

            }

        }

        public bool Reload {

            get {

                return _reload;
            
            }
            set {

                _reload = value;
            
            }
        
        }

        public IMvxCommand CreatePostCommand{

            get{

                _createPostCommand = new MvxCommand(CreatePost);

                return _createPostCommand;
            }

        }

        void CreatePost(){

            var param = new System.Collections.Generic.Dictionary<string, string>();

            param.Add("goal", GoalName); 

            ShowViewModel<LogHourPhotoViewModel>(param);

        }

        public void ReloadView() {

           // ShowViewModel<ActivityViewModel>();

            ShowViewModel<ProfileViewModel>();

        
        }

		public bool IsDeleting
		{
			get
			{
				return _isDeleting;
			}
			set
			{
				_isDeleting = value;
				RaisePropertyChanged(() => IsDeleting);
			}
		}
		public Guid DeletePostId
		{

			get
			{
				return _deletePostId;
			}
			set
			{
				_deletePostId = value;

				RaisePropertyChanged(() => DeletePostId);
			}
		}

		public ProfileViewModel(IPorpoiseWebApiClient client)
		{
			this.client = client;
			this._settings = Mvx.Resolve<ISettings>();
		}

		public override void Start()
		{
			base.Start();
		}


		public async void LoadDetails()
		{
			await GetProfileDetails();
		}
		async Task GetProfileDetails()
		{
			try
			{
				if (client != null)
				{
					InFlight = true;
					var result = await client.GetEmployee();
					if (result != null && result.Successful)
					{
						this.FirstName = result.FirstName;
						this.LastName = result.LastName;
						this.ProfilePicture = result.ProfilePicture;
						this.Location = result.Location;
                        this.TotalHoursGiven = result.Payload.totalContributionAmountInvested;
						this.CompanyGoals = result.CompanyGoals.Where(x => x.Id != null).OrderBy(x => x.Name).ToList();
						this.LatestLogPostList.Clear();

						var  posts =  await client.GetPosts(true);

						if (posts != null && posts.Successful) {

							this.LatestLogPostList = posts.Payload;
							RaisePropertyChanged(() => LatestLogPostList);
							//RaisePropertyChanged(() => LatestPost);

							foreach (var post in posts.Payload) { 
							
								post.OnDelete += (id) =>
								{
									this.DeletePostId = id;

									this.IsDeleting = true;

									//ShowViewModel<ActivityViewModel>(new DeleteParameter() { PostId = id });
								};
							
							}

						}


						/*if (result.LatestPost != null)
						{
							this.LatestLogPostList.Add(result.LatestPost);
							RaisePropertyChanged(() => LatestLogPostList);
							RaisePropertyChanged(() => LatestPost);
							LatestPost.OnEdit += (id) =>
								{
									if (LatestPost.CanEdit)
									{
										ShowViewModel<LogHoursViewModel>(new { PostId = id });
									}
									else
									{
										throw new PorpoiseException(Resource.InactiveGoalError);
									}

								};

						}*/

						AccountInfo.UserId = result.UserId.Value;
						RaiseAllPropertiesChanged();
						PerformGetEmployeeDetailsEvent(true);
						InFlight = false;
					}
					else
					{
						PerformGetEmployeeDetailsEvent(false, Resource.RetrieveProfileError);
						AccountInfo.Token = null;
						await Task.Delay(1000);
						ShowViewModel<LoginViewModel>();
					}
				}
			}
			catch (PorpoiseException pex)
			{
                System.Diagnostics.Debug.WriteLine(pex);

                PerformGetEmployeeDetailsEvent(false, Resource.RetrieveProfileError);
				AccountInfo.Token = null;
                //await Task.Delay(1000);
				ShowViewModel<LoginViewModel>();

			}
			catch (Exception ex)
			{
                System.Diagnostics.Debug.WriteLine(ex);
				PerformGetEmployeeDetailsEvent(false, ex.Message); ;
			}
		}

		public async Task DeletePost()
		{

			try
			{
				this.InFlight = true;

				if (this.client != null)
				{

					var result = await client.DeletePost(this.DeletePostId);
					var posts = await client.GetPosts(true);
					if (posts != null && posts.Successful)
					{
						this.LatestLogPostList = posts.Payload;
						foreach (var post in posts.Payload)
						{

							post.OnDelete += (id) =>
							{
								this.DeletePostId = id;

								this.IsDeleting = true;

								//ShowViewModel<ActivityViewModel>(new DeleteParameter() { PostId = id });
							};

						}
					}



				}
				var employee = await client.GetEmployee();
				if (employee != null && employee.Successful)
				{
					this.TotalHoursGiven = employee.TotalHoursGiven;
					this.CompanyGoals.Clear();
                    this.CompanyGoals = employee.CompanyGoals.Where(x => x.Id != null).OrderBy(x => x.Name).ToList();
						
					//this.CompanyGoals.Clear();
					this.LatestLogPostList.Clear();


                    
					RaisePropertyChanged(() => CompanyGoals);
						
					var posts = await client.GetPosts(true);

					if (posts != null && posts.Successful)
					{
                        
						this.LatestLogPostList = posts.Payload;
						RaisePropertyChanged(() => LatestLogPostList);
						//RaisePropertyChanged(() => LatestPost);
						foreach (var post in posts.Payload)
						{

							post.OnDelete += (id) =>
							{
								this.DeletePostId = id;

								this.IsDeleting = true;

								//ShowViewModel<ActivityViewModel>(new DeleteParameter() { PostId = id });


							};


						}




					}
				}
                this.InFlight = false;
			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				InFlight = false;

			}

		}

		public async Task EditPost()
		{

			try
			{

				this.InFlight = true;
				LogPost.clear();
				LogPost.action = "edit";

				ShowViewModel<LogPostOrganizationViewModel>(new DeleteParameter() { PostId = this.DeletePostId });


				this.InFlight = false;

			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				InFlight = false;

			}

		}

        public async Task EditPostAndroid(){

			try
			{

				this.InFlight = true;


				ShowViewModel<LogHoursViewModel>(new DeleteParameter() { PostId = this.DeletePostId });


				this.InFlight = false;

			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				InFlight = false;

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
				//RaisePropertyChanged(() => LatestLogPostList);
			}
		}

		public string ProfilePicture
		{
			get
			{
				return _profilePic;
			}
			private set
			{
				_profilePic = value;
				RaisePropertyChanged(() => ProfilePicture);
			}
		}

		//Employee FirstName & LastName
		public string Name
		{
			get
			{
				return ""+FirstName+" "+LastName+"";
			}
		}

		public string FirstName
		{
			get
			{
				return _fname;
			}
			private set
			{
				_fname = value;
				RaisePropertyChanged(() => FirstName);
				RaisePropertyChanged(() => LastName);
				RaisePropertyChanged(() => Name);
			}
		}

		public string LastName
		{
			get
			{
				return _lname;
			}
			private set
			{
				_lname = value;
				RaisePropertyChanged(() => FirstName);
				RaisePropertyChanged(() => LastName);
				RaisePropertyChanged(() => Name);
			}
		}

		//Employee City, Province, Country
		public string Location
		{
			get
			{
				return _location;
			}
			private set
			{
				_location = value;
				RaisePropertyChanged(() => Location);
			}
		}

		public double TotalHoursGiven
		{
			get
			{
				return _totalHours;
			}
			private set
			{
				_totalHours = value;
				RaisePropertyChanged(() => TotalHoursGiven);
			}
		}
		public List<Goal> CompanyGoals
		{
			get
			{
				return _companyGoals.OrderBy(x => x.Name).ToList();
			}
			private set
			{
				_companyGoals = value;
				RaisePropertyChanged(() => CompanyGoals);
			}
		}

		//Find out how many hours the employee logged for a particular goal and calculate the percentage
		public double Progress
		{
			get
			{
				return _progress;
			}
			private set
			{
				_progress = value;
				RaisePropertyChanged(() => Progress);
			}
		}
		public HourLog LatestPost
		{
			get
			{
				if (LatestLogPostList.Count > 0)
				{
					return LatestLogPostList.FirstOrDefault();
				}
				return null;
			}
			private set
			{
				_latestPost = value;
				RaisePropertyChanged(() => LatestPost);
			}
		}
		public List<HourLog> LatestLogPostList
		{
			get
			{
				return _latestPostList;
			}
			private set
			{
				_latestPostList = value;

				Debug.WriteLine("LATEST POST SIZE "+_latestPostList.Count);

				RaisePropertyChanged(() => LatestLogPostList);
			}
		}
		public event EventHandler<EditLogPostEventArgs> GoEditLogEvent;
		public event EventHandler<SdkEventArgs> GetEmployeeDetailsEvent;

		public void PerformGetEmployeeDetailsEvent(bool success, string message = null)
		{
			if (GetEmployeeDetailsEvent != null)
			{
				try
				{
					GetEmployeeDetailsEvent(this, new SdkEventArgs(success, message));

				}
				catch (Exception ex)
				{
				}
			}
		}


		public IMvxCommand GoEditLogCommand
		{
			get
			{
				return _goEditLogCommand ?? (_goEditLogCommand = new MvxCommand<Guid>(PerformGoEditLog));
			}
		}

		private async void PerformGoEditLog(Guid postId)
		{
			InFlight = true;
			try
			{
				_settings.SetValue(POSTKEY, postId);
				PerformGoEditLogEvent(postId);
				LogPost.action = "edit";
				ShowViewModel<LogPostOrganizationViewModel>();
				InFlight = false;
			}

			catch (Exception ex)
			{

			}

		}

		private MvxCommand<HourLog> _postsItemSelectedCommand;
		public event EventHandler<PostItemEventArgs> PostItemClickEvent;
		public IMvxCommand PostItemSelectCommand
		{
			get { return _postsItemSelectedCommand ?? (_postsItemSelectedCommand = new MvxCommand<HourLog>(OnPostItemClick)); }
		}

		void OnPostItemClick(HourLog postItem)
		{

			PerformPostItemClickEvent(postItem);
		}

		private void PerformPostItemClickEvent(HourLog postItem)
		{

			if (PostItemClickEvent != null)
			{
				try
				{
					PostItemClickEvent(this, new PostItemEventArgs(postItem));

				}
				catch (Exception ex)
				{

				}
			}
		}

		private void PerformGoEditLogEvent(Guid postId)
		{
			if (GoEditLogEvent != null)
			{
				try
				{
					GoEditLogEvent(this, new EditLogPostEventArgs(postId));

				}
				catch
				{

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
		}

		public void GoToLogHours()
		{
			ShowViewModel<LogPostOrganizationViewModel>();
		}
	}

}