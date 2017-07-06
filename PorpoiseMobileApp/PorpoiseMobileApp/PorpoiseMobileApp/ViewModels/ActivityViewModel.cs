using System;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.Platform;
using Acr.Settings;
using System.Threading.Tasks;
using System.Collections.Generic;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Client;
using System.Linq;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;

namespace PorpoiseMobileApp.ViewModels
{
	public class ActivityViewModel : PorpoiseViewModel<ActivityViewModel>
	{
		private IPorpoiseWebApiClient client;
		private ISettings _settings;
		private List<HourLog> _companyPosts;
		private List<HourLog> _userPosts;
		private IMvxCommand _goEditLogCommand;
		private readonly string POSTKEY = "PostId";
		private bool _inFlight;
		private HourLog _updatedPost;

		private bool _showLoginTutorial;

		public bool ShowLoginTutorial
		{

			get
			{

				return _showLoginTutorial;

			}
			set
			{

				_showLoginTutorial = value;

			}

		}

		private bool _showDialog;

		private bool _changedWelldones = false;

		private int _postPosition;



		public HourLog UpdatedPost { 
		
			get {

				return _updatedPost;
			
			}
			set {

				_updatedPost = value;
			
			}
		
		}

		public int PostPosition { 
		
			get {

				return _postPosition;

			}

			set {

				_postPosition = value;

			}
		
		}

	
		public bool ChangedWelldones
		{

			get
			{

				return _changedWelldones;

			}

			set
			{

				_changedWelldones = value;

                RaisePropertyChanged(() => ChangedWelldones);

			}

		}

		public bool ShowDialog
		{
			get
			{
				return _showDialog;
			}
			set
			{
				_showDialog = value;
				RaisePropertyChanged(() => ShowDialog);
			}
		}


		private bool _isDeleting = false;

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
		//[ObsoleteAttribute("This property is obsolete. Use isDeleting instead.", false)]
		private bool _isEditing = false;

		//[ObsoleteAttribute("This method is obsolete. Call isDeleting instead.", true)]
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

		public ActivityViewModel(IPorpoiseWebApiClient client, ISettings settings) : base()
		{
			this.client = client;
			this._settings = settings;
		}

        public void showCustomDialog(){

            ShowViewModel<ReportPostAlertViewModel>();

        }

        public async void reportPost(){

            try{
                this.InFlight = true;
                var result = await this.client.ReportPost(DotActionPostId, AccountInfo.UserId);

                Debug.WriteLine("Post Flagged");
                this.InFlight = false;
            }
            catch(Exception ex){

                Debug.WriteLine(ex);
                this.InFlight = false;
            }
        }

        public async void reportUser(string reason){

            try{

                this.InFlight = true;

                var result = await this.client.ReportUser(DotActionPostId, AccountInfo.UserId, reason);

				Debug.WriteLine("Post Flagged");
                this.InFlight = false;
            }
            catch(Exception ex){

                Debug.WriteLine(ex);

                this.InFlight = false;

            }

        }

		public List<HourLog> CompanyPosts
		{
			get
			{
				if (_companyPosts != null)
				{
					return _companyPosts.OrderByDescending(vm => vm.Date).OrderByDescending(vm => vm.PostSticky).ToList(); ;
				}
				else
				{
					return new List<HourLog>();
				}
			}
			set
			{
				_companyPosts = value;
				RaisePropertyChanged(() => CompanyPosts);
			}
		}
		public List<HourLog> UserPosts
		{
			get
			{
				if (_userPosts != null)
				{
					return _userPosts.OrderByDescending(vm => vm.Date).ToList(); ;
				}
				else
				{
					return new List<HourLog>();
				}

			}
			set
			{
				_userPosts = value;
				RaisePropertyChanged(() => UserPosts);
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
			}
		}


        public async Task LoadPosts()
		{
			await GetUserPosts();
			await GetCompanyPosts();
			DoPostsLoaded(true);
		}

		public async void Init(DeleteParameter deleteParams)

		{

            this.ShowLoginTutorial = true;

			this.IsDeleting = !Equals(Guid.Empty, deleteParams.PostId);

			this.DeletePostId = deleteParams.PostId;



			Debug.WriteLine("IS Deleting " + IsDeleting.ToString());

			if (this.IsDeleting)
			{

				await this.updatePosts();

				Debug.WriteLine("Delete is not null: " + deleteParams.PostId.ToString());

			}

		}

		private async Task updatePosts()
		{

			try
			{
				if (this.client != null)
				{

					this.InFlight = false;

					this.UserPosts = await GetPosts(true, true);

					this.CompanyPosts = await GetPosts(false, true);

				}

			}
			catch (Exception ex)
			{

				Debug.WriteLine("Exception caugth");

			}

		}

		private async Task<List<HourLog>> GetPosts(bool onlyForUser, bool flight)
		{
			try
			{
				InFlight = flight;
				if (client != null)
				{
					var result = await client.GetPosts(onlyForUser);
					if (result != null && result.Successful)
					{
						InFlight = false;
						foreach (var post in result.Posts)
						{
							if (post.PostType == "user")
							{
								post.OnEdit += (id) =>
								{
									if (post.CanEdit)
									{
										ShowViewModel<LogHoursViewModel>(new EditParameters() { PostId = id });
									}
									else if (!post.CanEdit)
									{
										throw new PorpoiseException(Resource.InactiveGoalError);
									}
								};

								post.OnDelete += (id) =>
								{
									this.DeletePostId = id;

									this.IsDeleting = true;

									//ShowViewModel<ActivityViewModel>(new DeleteParameter() { PostId = id });
								};
                                
								post.OnGiveWellDone += (id) =>
								{
									//this.InFlight = true;

									this.GiveWelldoneId = id;

									//Debug.WriteLine("GIVING WELL DONE TO " + this.GiveWelldoneId.ToString());

									this.GiveWelldone();



								};

                                post.OnDot += (id) => {

                                    Debug.WriteLine("Dot changed "+id);

                                    DotActionPostId = id;

                                };
							}
						}
						return result.Posts;
					}
					DoPostsLoaded(false);
				}

				InFlight = false;
				return new List<HourLog>();

			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				//InFlight = false;
				return new List<HourLog>();
			}

		}

		public void GoToLogHours()
		{LogPost.clear();
			ShowViewModel<LogHoursViewModel>();
		}

		public async Task GetCompanyPosts()
		{
			CompanyPosts = await GetPosts(false, true);
		}

		public async Task GetUserPosts()
		{
			UserPosts = await GetPosts(true, true);
		}


		private void DoPostsLoaded(bool success, string message = null)
		{
			if (OnPostsLoaded != null)
			{
				try
				{
					OnPostsLoaded(this, new SdkEventArgs(success, message));

				}
				catch (Exception ex)
				{

				}
			}
		}
		public event EventHandler OnPostsLoaded;


		public SelectedPostsList SelectedPostsList
		{
			get;
			set;
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

		public void LogoutLogin(){

			ShowViewModel<LoginViewModel>();

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




		public Guid _deletePostId;

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

        public Guid _dotActionPostId;

        public Guid DotActionPostId{

            get{

                return _dotActionPostId;

            }
            set{
                _dotActionPostId = value;
                RaisePropertyChanged(() => DotActionPostId);
            }
        }

		public Guid _giveWelldoneId;

		public Guid GiveWelldoneId
		{

			get
			{

				return _giveWelldoneId;

			}

			set
			{

				_giveWelldoneId = value;

				//ChangeWelldoneImage = true;

				//RaisePropertyChanged(() => ChangeWelldoneImage);

			}

		}

        public async void FlagTutorial(){

            Debug.WriteLine("Flagging tutorial in ViewModel");

            var employee = await this.client.GetEmployee();

            if(employee!= null && employee.Successful){

                Guid employeeUid = employee.Payload.EmployeeUid;

                var result = await client.FlagTutorial(employeeUid, "profile");

                if(result!=null && result.Successful){

                    Debug.WriteLine("Tutorial flagged");

                }
            }

        }

		public async Task GiveWelldone()
		{
            try
            {

                //this.InFlight = true;

                ChangedWelldones = false;

                Debug.WriteLine("AccountID: " + AccountInfo.Email);

                if (client.GetEmployee() != null)
                {

                    Debug.WriteLine("EMPLOYEE IS NOT NULL");

                }

                Debug.WriteLine("GIVE WELL DONE ARRAY");

                bool removeWell = false;

                var postList = await this.GetPosts(false, false);
                if(postList!= null)
                {
                IList<HourLog> list = postList;

                HourLog post = null;

                //int pos = 0;
                if (list.Count > 0)
                {

                    Debug.WriteLine("LIST IS NOT NULL");

                }
                for (int i = 0; i < list.Count; i++)
                {

                    HourLog aux = (HourLog)list.ElementAt(i);

                    if (aux.Id == this.GiveWelldoneId)
                    {

                        post = aux;

                        Debug.WriteLine("POST POSITION: " + _postPosition);

                        _postPosition = i;

                        break;

                    }

                }



                if (post != null)
                {

                    Debug.WriteLine("BEFORE PERFORMING OPERATION WELL DONES " + post.WellDones.Length);

                    Debug.WriteLine("Post To Check well dones found");

                    var employee = await client.GetEmployee();

                    string userID = employee.Payload.UserId.ToString();

                    Debug.WriteLine("USERID: " + userID);


                    foreach (Welldones aux in post.WellDones)
                    {

                        if (aux.UserId.Equals(userID))
                        {

                            Debug.WriteLine("REMOVING WELL DONE");

                            removeWell = true;

                        }

                    }

                }


                if (!removeWell)
                {
                    Debug.WriteLine("ADDING WELLDONE");

                    if (this.client != null && this.GiveWelldoneId != null && !this.GiveWelldoneId.ToString().Equals(""))
                    {

                        var result = await client.GiveWelldone(this.GiveWelldoneId);

                        if (result != null && result.Successful)
                        {



                            //this.UserPosts = await GetPosts(true);
                            //Todo: May uncomment this
                            //this.CompanyPosts = await GetPosts(false);

                        }

                    }

                }

                else
                {

                    if (this.client != null && this.GiveWelldoneId != null && !this.GiveWelldoneId.ToString().Equals(""))
                    {

                        var result = await client.RemoveWelldone(this.GiveWelldoneId);

                        Debug.WriteLine("WELLDONE REMOVED");

                        Debug.WriteLine("POST ID " + post.Id);



                        if (result != null && result.Successful)
                        {



                            //this.UserPosts = await GetPosts(true);

                            //this.CompanyPosts = await GetPosts(false);

                        }

                    }

                }

                //var resultPost =  client.GetPost

                //post.WellDones = null;

                //this.UserPosts = await GetPosts(true);

                //this.CompanyPosts = await GetPosts(false);

                var updatedPost = await this.client.GetPost((System.Guid)post.Id);

                if (updatedPost != null)
                {

                    Debug.WriteLine("UPDATED POST IS NOT NULL");

                    HourLog aux = updatedPost.Payload;
                    _updatedPost = aux;
                    post.WellDones = aux.WellDones;

                    Debug.WriteLine("AUX WELL DONES " + aux.WellDones.Length);

                    if (aux != null)
                    {

                        Debug.WriteLine("AUX IS NOT NULL");

                    }

                }

                Debug.WriteLine("AFTER PERFORMING OPERATION WELL DONES " + post.WellDones.Length);




                //RaisePropertyChanged(() => CompanyPosts);

                //RaisePropertyChanged(() => ChangedWelldones);

                //InFlight = false;

                //Replace post on list

                for (int i = 0; i < this.CompanyPosts.Count(); i++)
                {

                    if (this.CompanyPosts[i].Id.Value.Equals(post.Id.Value))
                    {
                        Debug.WriteLine("POST REPLACED");
                        _companyPosts[i] = post;
                        break;

                    }

                }



                ChangedWelldones = true;

            }

			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				//InFlight = false;

			}

		}

		public async Task RemoveWelldone()
		{
			try
			{
				//this.InFlight = true;

				if (this.client != null && this.GiveWelldoneId != null && !this.GiveWelldoneId.ToString().Equals(""))
				{

					var result = await client.RemoveWelldone(this.GiveWelldoneId);

					if (result != null && result.Successful)
					{

						//this.InFlight = false;

						//this.UserPosts = await GetPosts(true);

						//this.CompanyPosts = await GetPosts(false);

					}

				}

				//this.InFlight = false;
			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				//this.InFlight = false;

			}


		}


		public async Task DeletePost()
		{

			try
			{
				this.InFlight = true;

				if (this.client != null)
				{

					Debug.WriteLine("BEFORE DELETING POST " + _companyPosts.Count);

					var result = await client.DeletePost(this.DeletePostId);


					this.UserPosts = await GetPosts(true, true);

					this.CompanyPosts = await GetPosts(false, true);

					Debug.WriteLine("AFTER DELETING POST " + _companyPosts.Count);





				}

				this.InFlight = false;

			}
			catch (Exception ex)
			{

				Debug.WriteLine(ex.Message);

				InFlight = false;

			}

		}


	}

	public class DeleteParameter
	{

		public Guid PostId
		{

			get;
			set;

		}

	}

	public enum SelectedPostsList
	{
		User, All
	}

	public class EditParameters
	{
		public Guid PostId { get; set; }
	}

	public class PostItemEventArgs
	{
		public HourLog Post;
		public string Title;

		public PostItemEventArgs(HourLog postItem)
		{
			this.Title = !string.IsNullOrEmpty(postItem.EmployeeName) ? ""+postItem.EmployeeName+"'s Highlight" : string.Empty; ;
			this.Post = postItem;


		}
	}
}