using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Com.Syncfusion.Gauges.SfCircularGauge;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Droid.Support.V7.RecyclerView;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.Droid.Converters;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.ViewModels;
using RoundedImageView;
using System;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Binding.BindingContext;
using Android.Content;
using System.Globalization;

using System.Diagnostics.Contracts;
using Java.Net;
using R = PorpoiseMobileApp.Resource;
using Android.Util;
using static Android.App.ActionBar;
using PorpoiseMobileApp.Droid.MvvmCross;

namespace PorpoiseMobileApp.Droid.Views
{

    [MenuItem(MenuItem.Profile)]
    public class ProfileView :MvvmFragment<ProfileViewModel>
	{
        private MvxAdapter adapter;
		private float bar_elevation;
		private LinearLayout layout_container;
		private ScrollView scrollview;
		private MvxRoundedImageView profilePic;
		private LinearLayout sticky_header;
		private TextView name;
		private TextView location;
		private TextView totalHours;
		private bool loaded = false;
		//private View latestPost;
		//private MvxImageView uploadedPic;
		//private TextView employeeName;
		//private TextView date;
		//private TextView details;
		//private Button editButton;
		//private Button wellDoneButton;
		private LinearLayout chartHolder;
		private SfCircularGauge gauge;
		private MvxRecyclerView charts_recyclerView;
		private LinearLayout chartDetails;
		private TextView goalName;
		private TextView goalHours;
		private LinearLayout chartsParentContainer;
		private LinearLayoutManager layoutManager;
		private GoalItemRecyclerAdapter goalsAdapter;
		private View emptyPost;
		private ImageView right_arrow;
		private ImageView left_arrow;
		private LinearLayout goals_linear_container;
        protected MvxListView list;
		private LinearLayout rootView;
        private View addNew;
        public ProfileView() : base(Resource.Layout.ProfileView)
		{

		}

		public override void OnViewModelSet()
		{
			base.OnViewModelSet();
		}
		
		

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			System.Console.WriteLine("RELOADING VIEW ON CREATE");
			loaded = false;
			ViewModel.LoadDetails();
		}

		public override  void OnActivityCreated(Bundle savedInstanceState)
		{
			try
			{
				base.OnActivityCreated(savedInstanceState);

                Helper.clearList();

				Console.WriteLine("RELOADING VIEW ON ACTIVITY CREATED");

				//employee details
				Bindings.Bind(name).For(x => x.Text).To(vm => vm.Name);
				Bindings.Bind(profilePic).For(x => x.ImageUrl).To(vm => vm.ProfilePicture);
				Bindings.Bind(location).For(x => x.Text).To(vm => vm.Location);
				Bindings.Bind(totalHours).For(x => x.Text).To(vm => vm.TotalHoursGiven);
				name.SetTextColor(Android.Graphics.Color.White);

				//goals
				Bindings.Bind(charts_recyclerView).For(x => x.ItemsSource).To(x => x.CompanyGoals);


				//latest posts
				//Bindings.Bind(latestPost).For(x => x.Visibility).To(vm => vm.LatestPost).WithConversion(new LatestPostVisibilityConverter());
				//Bindings.Bind(uploadedPic).For(x => x.ImageUrl).To(x => x.LatestPost.PhotoUrl);
				//Bindings.Bind(employeeName).For(x => x.Text).To(x => x.LatestPost.EmployeeName);
				//Bindings.Bind(date).For(x => x.Text).To(x => x.LatestPost.Date).WithConversion(new LongDateConverter("MMMM dd, yyyy"));
				//Bindings.Bind(editButton).To(x => x.LatestPost.GoEditLogCommand);
				Bindings.Apply();
				var turquoise = Android.Graphics.Color.Rgb(65, 193, 201);
				//employeeName.SetTextColor(turquoise);

                Console.WriteLine("NUMBER OF POSTS: " + ViewModel.LatestLogPostList.Count);


				ViewModel.GetEmployeeDetailsEvent += (s, e) =>
				{
					if (!e.Successful)
					{
						this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.Error, e.Message, null, Resource.Style.PorpoiseDialogTheme);
						this.Activity.NavigateUpTo(new Android.Content.Intent(this.Activity, type: typeof(LoginView)));
					}
					else
					{

						//Declre list of objects

                        IList<HourLog> temporarylist = new List<HourLog>();

						Client.IPorpoiseWebApiClient apiClient = new Client.PorpoiseWebApiClient();

						var employee =  apiClient.GetEmployee();
						//Todo: uncomment
						//temporarylist.Add(employee.Result);

						//temporarylist.Add(employee);

						foreach (HourLog hourLog in ViewModel.LatestLogPostList.OrderByDescending(x => x.Date)) {

							temporarylist.Add(hourLog);

                           
						
						}


						//this.ViewModel.LoadDetails();
                        IOrderedEnumerable<HourLog> data_list;

						data_list =ViewModel.LatestLogPostList.OrderByDescending(x => x.Date);
						System.Console.WriteLine("LOADING POSTS");

                        //list.ItemsSource = data_list;
                        //MvxAdapter adapter = new PostItemAdapter(this.Activity, (IMvxAndroidBindingContext)this.BindingContext, this);
                        //list.Adapter = adapter;
                        //list.NestedScrollingEnabled = false;
                        //list.Set


                        //Todo: initialize list here

                        //rootView.RemoveAllViews();
                        Helper.loaded = false;
                        Helper.index = 0;
                        Helper.elements = temporarylist.Count()*7;
						
                       //Console.WriteLine("DATALIST SIZE: "+data_list.Count());
                        list.ItemsSource = data_list;
                        this.adapter = new PostItemAdapterProfile(this.Activity, (IMvxAndroidBindingContext)this.BindingContext, this);
						list.Adapter = adapter;
                      // Helper.setListViewHeightBasedOnChildren(list);
						//Helper.SetListViewHeightBasedOnChildren(list);

                     
                       list.AddHeaderView(addNew);

                        //list.RequestLayout();
						ViewModel.RaiseAllPropertiesChanged();
						Activity.RunOnUiThread(() =>
						{
							//TODO: Uncomment this later

								if ((charts_recyclerView != null && goalsAdapter == null))
								{
									charts_recyclerView.HasFixedSize = true;
									layoutManager = new LinearLayoutManager(this.Activity, LinearLayoutManager.Horizontal, false);
									charts_recyclerView.SetLayoutManager(layoutManager);

									goalsAdapter = new GoalItemRecyclerAdapter(this.Activity, this.BindingContext as IMvxAndroidBindingContext);
									charts_recyclerView.Adapter = goalsAdapter;
									charts_recyclerView.RequestLayout();
									/*goalsAdapter.onGoalClick += (gs, ge) =>
									{
										var dialog = BuildGoalDetailsDialog(ge.Goal);
										dialog.Show();
									};*/
									//    GoalsRecyclerViewLayoutListener layoutListener = null;
									//    layoutListener = new GoalsRecyclerViewLayoutListener(() =>
									//    {
									//        var minWidth = this.goals_linear_container.Width - 20;
									//        var maxWidth = this.goals_linear_container.Width;
									//        if (goalsAdapter.ContentWidth >= minWidth && goalsAdapter.ContentWidth <= maxWidth)
									//        {
									//            right_arrow.Visibility = ViewStates.Invisible;
									//            left_arrow.Visibility = ViewStates.Invisible;
									//        }
									//        else
									//        {
									//            right_arrow.Visibility = ViewStates.Visible;
									//            left_arrow.Visibility = ViewStates.Visible;
									//        }
									//        charts_recyclerView.ViewTreeObserver.RemoveGlobalOnLayoutListener(layoutListener);
									//    });

									//    charts_recyclerView.ViewTreeObserver.AddOnGlobalLayoutListener(layoutListener);
								}

							});
						
					}
				};

				this.ViewModel.PostItemClickEvent += (s, pe) =>
				{

					HourLog postItem = pe.Post;
					AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this.Activity, Resource.Style.PorpoiseDialogTheme);
					AlertDialog alertDialog = builder.Create();

					alertDialog.SetTitle(pe.Title);
					alertDialog.SetIcon(Resource.Drawable.logo_small2_cyan);
					alertDialog.SetMessage(postItem.Highlight);
					alertDialog.SetButton(PorpoiseMobileApp.Resource.Done, (s2, e2) => { });
					alertDialog.Show();
				};



			}
			catch (Exception ex)
			{

                System.Console.Write(ex.Message);
			}
		}

		private string GivenwelldoneText(int people)
		{

			if (people == 0)
			{

				return "Be the first to give a WellDone!";

			}
			else if (people == 1)
			{

				return "1 Person gave a WellDone!";

			}
			else
			{

				return people + " People gave a WellDone!";

			}

		}
       
        public override void OnStart()
        {
            base.OnStart();

            System.Console.WriteLine("ON START METHOD");

            //MvxRecyclerView view = View.FindViewById<MvxRecyclerView>(Resource.Id.goals_recycler_view);

           // view.Invalidate();

           // view.RequestLayout();
            
           // this.ViewModel.LoadDetails();

            /*if (view != null)
            {
                view.RemoveAllViews();

                view.RefreshDrawableState();
            }*/
        }

        public override void OnViewStateRestored(Bundle savedInstanceState)
        {
            base.OnViewStateRestored(savedInstanceState);
            System.Console.WriteLine("ON VIEW STATE RESTORED");
        }

        public override void OnPause()
        {
            base.OnPause();
            System.Console.WriteLine("ON PAUSE METHOD");

			
		
        }
        
        

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = base.OnCreateView(inflater, container, savedInstanceState);

			System.Console.WriteLine("RELOADING VIEW ON CREATE VIEW");

			//Profile details//		
			try
			{
                list = view.FindViewById<MvxListView>(Resource.Id.posts_list_profile);
                addNew = inflater.Inflate(Resource.Layout.profile_item, list, false);
				charts_recyclerView = addNew.FindViewById<MvxRecyclerView>(Resource.Id.goals_recycler_view);
				//goals_linear_container = addNew.FindViewById<LinearLayout>(Resource.Id.goals_linear_container);
				//layout_container = addNew.FindViewById<LinearLayout>(Resource.Id.layout_container);
				//scrollview = view.FindViewById<ScrollView>(Resource.Id.scrollView);
				sticky_header = view.FindViewById<LinearLayout>(Resource.Id.sticky_header);
				profilePic = view.FindViewById<MvxRoundedImageView>(Resource.Id.profile_picture);
				name = view.FindViewById<TextView>(Resource.Id.employeeName);
				location = view.FindViewById<TextView>(Resource.Id.location);
				totalHours = view.FindViewById<TextView>(Resource.Id.total_hours_amount);

				//Latest Post Stuff//
				//emptyPost = view.FindViewById(Resource.Id.profile_empty_post_item);
				//latestPost = view.FindViewById(Resource.Id.post_item);
				//uploadedPic = view.FindViewById<MvxImageView>(Resource.Id.image);
				//employeeName = view.FindViewById<TextView>(Resource.Id.post_details_name);
				//date = view.FindViewById<TextView>(Resource.Id.post_details_date);
				//details = view.FindViewById<TextView>(Resource.Id.details);
				//editButton = view.FindViewById<Button>(Resource.Id.edit_button);
				//wellDoneButton = view.FindViewById<Button>(Resource.Id.well_done);
				//right_arrow = addNew.FindViewById<ImageView>(Resource.Id.right_arrow);
				//left_arrow = addNew.FindViewById<ImageView>(Resource.Id.left_arrow);
               
                list.Divider = null;
                //list.Clickable = false;
                //list.setExpanded(true);
                //list.scrol
				//list = view.FindViewById<MvxListView>(Resource.Id.posts_list);
                //Todo: uncomment this
				//rootView = view.FindViewById<LinearLayout>(Resource.Id.AdvancedCatalogContainer);

				if (charts_recyclerView != null && !this.ViewModel.Reload)
				{
					charts_recyclerView.HasFixedSize = true;
					layoutManager = new LinearLayoutManager(this.Activity, LinearLayoutManager.Horizontal, false);
					charts_recyclerView.SetLayoutManager(layoutManager);

					goalsAdapter = new GoalItemRecyclerAdapter(this.Activity, this.BindingContext as IMvxAndroidBindingContext);
					charts_recyclerView.Adapter = goalsAdapter;
					charts_recyclerView.RequestLayout();
					//TODO: UNCOMMENT
                    goalsAdapter.onGoalClick += (gs, ge) =>
					{
						var dialog = BuildGoalDetailsDialog(ge.Goal);
						dialog.Show();
					};
					//    GoalsRecyclerViewLayoutListener layoutListener = null;
					//    layoutListener = new GoalsRecyclerViewLayoutListener(() =>
					//    {
					//        var minWidth = this.goals_linear_container.Width - 20;
					//        var maxWidth = this.goals_linear_container.Width;
					//        if (goalsAdapter.ContentWidth >= minWidth && goalsAdapter.ContentWidth <= maxWidth)
					//        {
					//            right_arrow.Visibility = ViewStates.Invisible;
					//            left_arrow.Visibility = ViewStates.Invisible;
					//        }
					//        else
					//        {
					//            right_arrow.Visibility = ViewStates.Visible;
					//            left_arrow.Visibility = ViewStates.Visible;
					//        }
					//        charts_recyclerView.ViewTreeObserver.RemoveGlobalOnLayoutListener(layoutListener);
					//    });

					//    charts_recyclerView.ViewTreeObserver.AddOnGlobalLayoutListener(layoutListener);

                    this.ViewModel.Reload = true;
				}
        


				Context.SetTheme(Resource.Style.PorpoiseDialogTheme);

			}
			catch (Exception ex)
			{
				System.Console.Write(ex.Message);
				this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.Error, PorpoiseMobileApp.Resource.RetrieveProfileError, y => { ViewModel.Logout(); }, Resource.Style.PorpoiseDialogTheme);
			}

			return view;

		}


		public int fillLayout( HourLog post, Context cont)
		{
			
			//root.RemoveAllViews();
			var v = LayoutInflater.From(Context).Inflate(Resource.Layout.post_item, null, false);
			//MvvmFragment<HourLog> fragment = v;

			//var set = this.CreateBindingSet<ProfileView, post>();
			//v.Bind((IMvxBindingContextOwner)post, "HourLog");
			Typeface employeeNameFont = Typeface.CreateFromAsset(cont.Assets, "AvenirLT-Book.ttf");

			Typeface locationFont = Typeface.CreateFromAsset(cont.Assets, "AvenirLT-Book.ttf");

            var employeeName = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.post_details_name);
			var profilePicture = v.FindViewById<MvxRoundedImageView>(Resource.Id.profileImage);
			var postLocation = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.post_city_name);
            var postPicture = v.FindViewById<scaleimageview.ScaleImageView>(Resource.Id.image);
			var welldoneButton = v.FindViewById<Button>(Resource.Id.well_done);
			var givenWelldoneContainer = v.FindViewById<LinearLayout>(Resource.Id.given_Welldone_container);
			var givenWelldoneText = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.givenwelldones_text);
			var postDetail = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.post);
			var details = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.details);
			var date = v.FindViewById<porpoisetextview.PorpoiseTextView>(Resource.Id.post_details_date);
			var editButton = v.FindViewById<Button>(Resource.Id.edit_button);
            //Bindings.Bind(editButton).To(vm => vm.LatestLogPostList.ElementAt(vm.LatestLogPostList.IndexOf(post)).DeletePostCommand);
			//date.Text = post.DateString;
			welldoneButton.Visibility = ViewStates.Gone;
			profilePicture.ImageUrl = post.ProfileImage;

			postPicture.ImageUrl = post.PhotoUrl;
			//postPicture.SetScaleType(ImageView.ScaleType.CenterCrop);

			PorpoiseMobileApp.Converters.LongDateConverter dateConverter = new LongDateConverter("MMMM dd");

			string format = "MMMM dd";
			string dateConverted = ((DateTime)post.Date).ToString(format, CultureInfo.CurrentCulture);
			System.Console.WriteLine("CONVERTED DATE: " + dateConverted);
			date.Text = dateConverted;
			//Bindings.Bind(employeeName).For(x => x.Text).To(vm => vm.LatestLogPostList.ElementAt(vm.LatestLogPostList.IndexOf(post)).EmployeeName);

			//set.Bind(employeeName).For(x => x.Text).To(vm => vm.EmployeeName);
			System.Console.WriteLine("EMPLOYEE NAME "+post.EmployeeName);
			employeeName.Text = post.EmployeeName;
			postLocation.Text = post.Location;
			employeeName.SetTypeface(employeeNameFont, TypefaceStyle.Bold);

			postLocation.SetTypeface(locationFont, TypefaceStyle.Bold);

			if (post.WellDones.Count() <= 0)
			{

				givenWelldoneContainer.Visibility = ViewStates.Gone;

			}
			else {

				givenWelldoneText.Text = this.GivenwelldoneText(post.WellDones.Count());
			
			}
			postDetail.Text = post.Highlight;
			postPicture.SetScaleType(ImageView.ScaleType.CenterCrop);

			//editButton.SetHintTextColor(Color.White);
			//editButton.Hint = post.Id.Value.ToString();
			DesignPostLayoutHelper.SetupDetailsTextView(this.Context, details, post);
			editButton.Click -= (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, post.Id.Value.ToString()); };
			editButton.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, post.Id.Value.ToString()); };
            //Todo: Uncomment this
            return  v.LayoutParameters.Height;
            //return v.Height;

		}
		void buttonNext_Click(object sender, EventArgs e, String id)
		{
			System.Console.WriteLine("ID VALUE: "+id);
			ViewModel.DeletePostId = System.Guid.Parse(id);
			var popup = CreatePopupWindow(this.Context);
			popup.ShowAsDropDown((View)sender, 0, 0);

		}

		private void menuItemFolder_Click_Helper(object sender, EventArgs e, object Owner, object DataType)
		{
			// implement details here
		}

		private PopupWindow _popupWindow;

		private ListView _listView;


		private PopupWindow CreatePopupWindow(Context cont)
		{
			_popupWindow = new PopupWindow(cont);
			_popupWindow.Focusable = true;
			_popupWindow.Touchable = true;
			_popupWindow.OutsideTouchable = true;

			

			TextView edit = new TextView(cont);

			edit.Text = "Edit Post";

			var adapter = new ArrayAdapter<String>(cont, Android.Resource.Layout.SimpleDropDownItem1Line, new String[] { "Edit Post", "Delete Post", "Cancel" });
			
			_listView = new ListView(cont) { Adapter = adapter };

			_listView.DescendantFocusability = DescendantFocusability.BlockDescendants;

		   
			_listView.ItemClick += async (sender, args) =>
			{
				System.Console.WriteLine("SELECTING");

				switch (args.Position)
				{

					case 0: //Edit Post    

						await ViewModel.EditPostAndroid();
						_popupWindow.Dismiss();
						break;
					case 1: //Delete Post
							//set alert for executing the task
					   AlertDialog.Builder alert = new AlertDialog.Builder(cont);
						alert.SetTitle("Confirm delete");
						alert.SetMessage("Are you sure you want to delete this post?");
						alert.SetPositiveButton("Delete", async (senderAlert, argss) =>
						{
							//await CurrentActivity.ViewModel.DeletePost();
							//await CurrentActivity.ViewModel.LoadPosts();

							ViewModel.IsDeleting = true;

							await ViewModel.DeletePost();

							this.loaded = false;

							for (int i = 0; i < ViewModel.LatestLogPostList.Count; i++)
							{

								HourLog aux = ViewModel.LatestLogPostList.ElementAt(i);

								System.Console.WriteLine("ADDING POST");

								//fillLayout(rootView, aux, i,cont);

								//loaded = true;

							}

							this.OnCreate(null);
							this.OnActivityCreated(null);
							_popupWindow.Dismiss();

						});

						alert.SetNegativeButton("Cancel", (senderAlert, argss) =>
					  {
						   //Toast.MakeText(cont, "Cancelled!", ToastLength.Short).Show();
						  _popupWindow.Dismiss();
					   });

						Dialog dialog = alert.Create();
						dialog.Show();
						_popupWindow.Dismiss();
						break;
					case 2:
						_popupWindow.Dismiss();
						break;
				}


			};

			
			_popupWindow.ContentView = _listView;
			_popupWindow.Width = ViewGroup.LayoutParams.WrapContent;
			_popupWindow.Height = ViewGroup.LayoutParams.WrapContent;
			ViewGroup.LayoutParams parameters = _listView.LayoutParameters;
			System.Console.WriteLine("List View Width "+_listView.Width);
			System.Console.WriteLine("Popup View Width " + _popupWindow.Width);
			//parameters.Width = _popupWindow.Width;

		   
			//_listView.LayoutParameters.Width = LinearLayout.LayoutParams.WrapContent; 
			return _popupWindow;
		}

		private void Post_EditButton_Click(object sender, EventArgs e)
		{
			/*_menu.Gravity = GravityFlags.Right;
			_menu.Show();*/
			Button button = (Button)sender;
			System.Console.WriteLine("ID: " + button.Hint);
			var popup = CreatePopupWindow(this.Context);
			popup.ShowAsDropDown((View)sender, 0, 0);

		}

		
		private AlertDialog BuildGoalDetailsDialog(Goal goal)
		{
			Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this.Context, Resource.Style.PorpoiseDialogTheme);
			var detailsView = LayoutInflater.From(Context).Inflate(Resource.Layout.goal_details_dialog, null);
	  
			Android.App.AlertDialog alertDialog = builder.Create();

			alertDialog.SetView(detailsView);
			var goalName = detailsView.FindViewById<TextView>(Resource.Id.dialog_goal_name);
			var goalHours = detailsView.FindViewById<TextView>(Resource.Id.dialog_goal_hours_invested);
			var description = detailsView.FindViewById<TextView>(Resource.Id.dialog_goal_description);
			var reward = detailsView.FindViewById<TextView>(Resource.Id.dialog_goal_reward);
			var descriptionContainer = detailsView.FindViewById<LinearLayout>(Resource.Id.goal_description_container);

			goalName.Text = goal.Name;
			goalHours.Text = goal.HoursAgainstGoal+" of "+goal.Hours+" hours";
			if (!string.IsNullOrEmpty(goal.Description))
			{
				descriptionContainer.Visibility = ViewStates.Visible;
				description.Text = goal.Description;
			}
			else
			{
				descriptionContainer.Visibility = ViewStates.Gone;
			}

			reward.Text = goal.GiftName;

			alertDialog.SetButton(PorpoiseMobileApp.Resource.Ok, (sender, e) =>
			{
				alertDialog.Dismiss();
			});

			return alertDialog;

			// alertDialog.Show();
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			base.OnViewCreated(view, savedInstanceState);

		}

		public override void OnResume()
		{
			base.OnResume();
			var actionBar = ((Android.Support.V7.App.AppCompatActivity)Activity).SupportActionBar;
			bar_elevation = actionBar.Elevation;
			actionBar.Elevation = 0;
			ViewModel.LoadDetails();
            Console.WriteLine("ON RESUME METHOD");
		}

		public override void OnStop()
		{
			base.OnStop();
			var actionBar = ((Android.Support.V7.App.AppCompatActivity)Activity).SupportActionBar;
			actionBar.Elevation = bar_elevation;
		}

	}
	public class GoalItemRecyclerAdapter : MvxRecyclerAdapter
	{
		public Activity Context { get; set; }
		public List<Goal> Goals { get; private set; }
		public int ContentWidth { get; set; }
		private SfCircularGauge gauge;

		public GoalItemRecyclerAdapter(Activity activity, IMvxAndroidBindingContext context)
			: base(context)
		{
			this.Context = activity;
		}



		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{

			try
			{
				MvxAndroidBindingContext mvxAndroidBindingContext = new MvxAndroidBindingContext(parent.Context, this.BindingContext.LayoutInflaterHolder, null);
				GoalItemViewHolder vh = new GoalItemViewHolder(this.InflateViewForHolder(parent, viewType, mvxAndroidBindingContext), mvxAndroidBindingContext);
				return vh;
			}
			catch (Exception ex)
			{

				System.Console.WriteLine(ex.Message);
				throw;
			}
		}


		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			base.OnBindViewHolder(holder, position);

			Goal goal = GetItem(position) as Goal;
			GoalItemViewHolder vh = holder as GoalItemViewHolder;
			SfCircularGauge goalChart = BuildGaugeChart(goal);
			LinearLayout.LayoutParams lp = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
			lp.RightMargin = 5;
			lp.LeftMargin = 5;
			this.Context.RunOnUiThread(() =>
			{
				if (vh.ChartHolder.GetChildAt(position) == null)
				{
					vh.ChartHolder.AddView(goalChart, lp);
					ContentWidth += vh.ChartHolder.Width;

                    if (!vh.ChartHolder.HasOnClickListeners)
                    {
                        vh.ChartHolder.Click += (s, e) =>
                        {
                            onGoalClick.Invoke(s, new GoalClickEventArgs(goal));
                            //var dialog = BuildGoalDetailsDialog(goal);
                            //dialog.Show();
                        };
                    }
                    }
				
			});
		}

		public event EventHandler<GoalClickEventArgs> onGoalClick;


		public SfCircularGauge BuildGaugeChart(Goal goal)
		{
			System.Console.WriteLine("BUILDING GAUGE. Goal Hours: " + goal.Hours);
			gauge = new SfCircularGauge(this.Context);
			var scales = new List<CircularScale>();
			var scale = new CircularScale();
			scale.StartValue = 0.5;
			scale.EndValue = goal.Hours;
			scale.Interval = 1;
			scale.StartAngle = 0;
			scale.SweepAngle = 360;
			scale.RimWidth = 10;
			scale.ShowTicks = false;
			scale.ShowLabels = false;
			scale.RimColor = Color.Rgb(211, 211, 211);
			scale.LabelColor = Color.Rgb(65, 193, 201);
			scale.LabelOffset = 0.2f;
			List<CircularPointer> pointers = new List<CircularPointer>();
			RangePointer rangePointer = new RangePointer();
			System.Console.WriteLine("BUILDING GAUGE. Goal Hours Against Goal: " + goal.HoursAgainstGoal);
			rangePointer.Value = goal.HoursAgainstGoal;
			rangePointer.Width = 10;

			Header header = new Header();
			double percentage = (goal.HoursAgainstGoal / goal.Hours);
			if (percentage * 100 >= 100)
			{
				rangePointer.Value = 100;
				header.Text = percentage.ToString("P0");
				rangePointer.Color = Color.Rgb(255, 212, 63);
			}
			else if (percentage <= 0 || goal.HoursAgainstGoal == 0)
			{

				header.Text = "0 %";
				rangePointer.Value = 100;
				rangePointer.Color = Color.Rgb(211, 211, 211);
			}
			else
			{
				header.Text = percentage.ToString("P0");
				System.Console.WriteLine("PERCENTAGE FOR " + goal.Name+" "+header.Text);
				rangePointer.Color = Color.Rgb(65, 193, 201);
			}
			header.Position = new Android.Graphics.PointF(0.5f, 0.5f);
			header.TextColor = Color.Rgb(65, 193, 201);
			header.TextSize = 16;
			header.TextStyle = Android.Graphics.Typeface.DefaultBold;
			gauge.Headers.Add(header);
			pointers.Add(rangePointer);
			scale.CircularPointers = pointers;
			scales.Add(scale);
			gauge.CircularScales = scales;
			return gauge;

		}


	}

	public class GoalItemViewHolder : MvxRecyclerViewHolder
	{

		private int _itemTemplateId = Resource.Layout.goal_item;
		public TextView GoalName { get; set; }
		public TextView GoalHours { get; set; }
		public LinearLayout ChartHolder { get; set; }
		public LinearLayout Parent_ChartHolder { get; set; }
		public int ItemTemplateId
		{
			get
			{
				return this._itemTemplateId;
			}
			set
			{
				this._itemTemplateId = value;
			}
		}

		public GoalItemViewHolder(View itemView, IMvxAndroidBindingContext context)
			: base(itemView, context)
		{

			GoalName = itemView.FindViewById<TextView>(Resource.Id.goal_name);
			GoalHours = itemView.FindViewById<TextView>(Resource.Id.goal_hours);
			ChartHolder = itemView.FindViewById<LinearLayout>(Resource.Id.chart_holder);
			Parent_ChartHolder = itemView.FindViewById<LinearLayout>(Resource.Id.charts_parent_container);
		}
	}

	public class GoalsRecyclerViewLayoutListener : Java.Lang.Object, ViewTreeObserver.IOnGlobalLayoutListener
	{

		public GoalsRecyclerViewLayoutListener(Action onGlobalLayout)
		{

			this.onGlobalLayout = onGlobalLayout;
		}

		Action onGlobalLayout;

		public void OnGlobalLayout()
		{
			onGlobalLayout();
		}


	}

    public class PostItemAdapterProfile : MvxAdapter
	{
		private int _itemTemplateId = Resource.Layout.post_item;
		private ActivityView CurrentActivity;

		public override int ItemTemplateId
		{
			get
			{
				return this._itemTemplateId;
			}
			set
			{
				this._itemTemplateId = value;
			}
		}

		public Context context { get; set; }

		public PostItemAdapterProfile(Context context, IMvxBindingContext bindingContext, object activity = null) : base(context, (IMvxAndroidBindingContext)bindingContext)
		{
			this.context = context;
			if (activity is ActivityView)
			{
				this.CurrentActivity = (ActivityView)activity;
			}
		}

        Android.Widget.PopupMenu _menu;

		private PopupWindow _popupWindow;

		private ListView _listView;

		private PopupWindow CreatePopupWindow(Context cont)
		{
			_popupWindow = new PopupWindow(cont);

			var adapter = new ArrayAdapter<string>(cont, Android.Resource.Layout.SimpleDropDownItem1Line, new string[] { "Edit Post", "Delete Post", "Cancel" });
			_listView = new ListView(cont) { Adapter = adapter };

			_listView.ItemClick += async (sender, args) =>
			{

				switch (args.Position)
				{

					case 0: //Edit Post    
					   CurrentActivity.ViewModel.IsEditing = true;
						await CurrentActivity.ViewModel.EditPost();
						_popupWindow.Dismiss();
						break;
					case 1: //Delete Post
							//set alert for executing the task
					   AlertDialog.Builder alert = new AlertDialog.Builder(cont);
						alert.SetTitle("Confirm delete");
						alert.SetMessage("Are you sure you want to delete this post?");
						alert.SetPositiveButton("Delete", async (senderAlert, argss) =>
						{
							await CurrentActivity.ViewModel.DeletePost();
							await CurrentActivity.ViewModel.LoadPosts();
						});

						alert.SetNegativeButton("Cancel", (senderAlert, argss) =>
					  {
						   //Toast.MakeText(cont, "Cancelled!", ToastLength.Short).Show();
					   });

						Dialog dialog = alert.Create();
						dialog.Show();
						_popupWindow.Dismiss();
						break;
					case 2:
						_popupWindow.Dismiss();
						break;
				}


			};

			_popupWindow.Width = ViewGroup.LayoutParams.WrapContent;
			_popupWindow.Height = ViewGroup.LayoutParams.WrapContent;
			_popupWindow.ContentView = _listView;
			return _popupWindow;
		}

		private string GivenwelldoneText(int people)
		{

			if (people == 0)
			{

				return "Be the first to give a WellDone!";

			}
			else if (people == 1)
			{

				return "1 Person gave a WellDone!";

			}
			else
			{

				return people + " People gave a WellDone!";

			}

		}




		private bool givenWelldone(Welldones[] array)
		{

			foreach (Welldones aux in array)
			{

				if (aux.UserId.Equals(AccountInfo.UserId.ToString()))
				{

					return true;

				}


			}

			return false;

		}


		private int resourceId;

		protected override View GetBindableView(View convertView, object dataContext, int templateId)
		{
			Console.WriteLine("DATACONTEXT TYPE: "+dataContext.GetType().ToString());



				templateId = Resource.Layout.post_item;

				var view = base.GetBindableView(convertView, dataContext, templateId);
				var hourLog = dataContext as HourLog;

                var uploadedPic = view.FindViewById<scaleimageview.ScaleImageView>(Resource.Id.image);
				//uploadedPic.SetOnTouchListener(this);
				var employeeName = view.FindViewById<TextView>(Resource.Id.post_details_name);
				var date = view.FindViewById<TextView>(Resource.Id.post_details_date);

				var details = view.FindViewById<TextView>(Resource.Id.details);
				var editButton = view.FindViewById<Button>(Resource.Id.edit_button);
				var profileImage = view.FindViewById<RoundedImageView.MvxRoundedImageView>(Resource.Id.profileImage);

				var wellDoneButton = view.FindViewById<Button>(Resource.Id.well_done);
				var play_button = view.FindViewById<ImageView>(Resource.Id.imgSecond);
				var post_details = view.FindViewById<TextView>(Resource.Id.post);
				var listItem = ((MvxListItemView)view);
				var bindings = listItem.CreateBindingSet<MvxListItemView, HourLog>();
				var location = view.FindViewById<TextView>(Resource.Id.post_city_name);
				var givenWelldonePanel = view.FindViewById<LinearLayout>(Resource.Id.given_Welldone_container);
				var givenWelldoneText = view.FindViewById<TextView>(Resource.Id.givenwelldones_text);
				var lineContainer = view.FindViewById<LinearLayout>(Resource.Id.line_container);
				var givenWelldonesContaner = view.FindViewById<LinearLayout>(Resource.Id.given_Welldone_container);
				var highlightContainer = view.FindViewById<LinearLayout>(Resource.Id.post_details_container_2);
				var imageContainer = view.FindViewById<FrameLayout>(Resource.Id.image_container);
            TextView highlight = new TextView(this.context);
				Typeface employeeNameFont = Typeface.CreateFromAsset(this.context.Assets, "AvenirLT-Book.ttf");

				Typeface locationFont = Typeface.CreateFromAsset(this.context.Assets, "AvenirLT-Book.ttf");

				employeeName.SetTypeface(employeeNameFont, TypefaceStyle.Bold);

				location.SetTypeface(locationFont, TypefaceStyle.Bold);

				



				//UNCOMMENT
				bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.ProfileImage);
				bindings.Bind(location).For(x => x.Text).To(x => x.Location);
				bindings.Bind(date).For(x => x.Text).To(x => x.Date).WithConversion(new LongDateConverter("MMMM dd"));

				//context.SetTheme(Resource.Style.PorpoiseDialogTheme); 

				_menu = new Android.Widget.PopupMenu(context, view.FindViewById<Button>(Resource.Id.edit_button), GravityFlags.Right);

				_menu.Menu.Add(1, 1, 1, R.EditPost);
				_menu.Menu.Add(1, 2, 1, R.DeletePost);
				_menu.Menu.Add(1, 3, 3, R.Cancel);

				context.SetTheme(Resource.Style.PorpoiseDialogTheme);

				_menu.MenuItemClick += async (s2, arg2) =>
				{
					var clicked = arg2.Item;
					switch (clicked.ItemId)
					{
						case 1: //Edit Post    
						CurrentActivity.ViewModel.IsEditing = true;
							await CurrentActivity.ViewModel.EditPost();
							break;
						case 2: //Delete Post
						await CurrentActivity.ViewModel.DeletePost();
							await CurrentActivity.ViewModel.LoadPosts();
							break;
					}
					_menu.Dismiss();
				};

             

				//wellDoneButton.SetBackgroundColor(Android.Graphics.Color.Yellow);

				editButton.Click -= Post_EditButton_Click; //unti double click
				editButton.Click += Post_EditButton_Click;


				bindings.Bind(editButton).CommandParameter(ItemTemplateId).To(x => x.DeletePostCommand);
				GivenWelldoneObject obj = new GivenWelldoneObject();

				obj.Button = wellDoneButton;

				obj.HourLog = hourLog;

				bindings.Bind(wellDoneButton).For(x => x).To(x => x).WithConversion(new WelldoneButoonConverter(wellDoneButton));
				bindings.Bind(wellDoneButton).CommandParameter(ItemTemplateId).To(x => x.GiveWellDoneCommand);

				if (AccountInfo.UserId.ToString().Equals(hourLog.PosterId))
				{
					wellDoneButton.Visibility = ViewStates.Gone;

					if (hourLog.WellDones.Length == 0)
					{

						givenWelldonePanel.Visibility = ViewStates.Gone;

					}
					else
					{

						givenWelldoneText.Text = this.GivenwelldoneText(hourLog.WellDones.Length);

					}


				}
				else
				{

					givenWelldoneText.Text = this.GivenwelldoneText(hourLog.WellDones.Length);

					resourceId = Resource.Drawable.wellDoneGray;

					if (givenWelldone(hourLog.WellDones))
					{

						wellDoneButton.SetBackgroundResource(Resource.Drawable.wellDoneOrange);

						resourceId = Resource.Drawable.wellDoneOrange;


					}
				}



				if (hourLog.PostType == "company")
				{
					bindings.Bind(employeeName).For(x => x.Text).To(x => x.CompanyName);
					bindings.Bind(details).For(x => x.Text).To(x => x.Highlight);
					bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.CompanyLogo);
					date.Visibility = ViewStates.Invisible;
					lineContainer.Visibility = ViewStates.Gone;

					wellDoneButton.Visibility = ViewStates.Gone;

					givenWelldonesContaner.Visibility = ViewStates.Gone;

					highlightContainer.Visibility = ViewStates.Gone;
				}
				else
				{
					bindings.Bind(employeeName).For(x => x.Text).To(x => x.EmployeeName);
					bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.ProfileImage);
					bindings.Bind(post_details).For(x => x.Text).To(x => x.Highlight);
				}

			
                //this.scaleImage(uploadedPic);
                //uploadedPic.SetScaleType(Android.Widget.ImageView.ScaleType.CenterCrop);

                //uploadedPic.LayoutParameters.Height = uploadedPic.MeasuredWidth;
                //this.setScaleImage(uploadedPic, uploadedPic.ImageUrl);
                Console.WriteLine("LIST ITEM HEIGHT: "+ uploadedPic.Height);
				if (hourLog.PostType == "user")
				{
					DesignPostLayoutHelper.SetupDetailsTextView(this.Context, details, hourLog);

				}






				//if it's the user's post, display the edit button
				if (string.Equals(hourLog.PosterId, AccountInfo.UserId.Value.ToString()))
				{
					editButton.Visibility = ViewStates.Visible;
				}
				else
				{
					editButton.Visibility = ViewStates.Gone;
				}

				if (hourLog.PostType == "company" && hourLog.MediaType == "youtube" && !hourLog.MediaType.Equals("none"))
				{
					play_button.Visibility = ViewStates.Visible;
				}
				else
				{
					play_button.Visibility = ViewStates.Gone;
				}

            //ViewGroup.LayoutParams lp = view.LayoutParameters;

            //lp.Height = view.Height + uploadedPic.Height;

            //view.LayoutParameters = lp;
            Console.WriteLine("POST MEDIA TYPE: "+hourLog.MediaType);
            if (hourLog.MediaType.ToString().ToLower().Equals("none"))
				{
					DisplayMetrics displayMetrics = new DisplayMetrics();

					((Activity)this.context).WindowManager.DefaultDisplay.GetMetrics(displayMetrics);
					int height = displayMetrics.HeightPixels;
					int width = displayMetrics.WidthPixels;
					uploadedPic.Visibility = ViewStates.Gone;

					imageContainer.LayoutParameters.Height = width / 3;

					imageContainer.SetBackgroundColor(Color.ParseColor(hourLog.BackgroundColor));

					

					highlight.Text = hourLog.Highlight;

					highlight.Gravity = (GravityFlags.CenterVertical | GravityFlags.Left);

					imageContainer.AddView(highlight);

					highlightContainer.Visibility = ViewStates.Gone;

					lineContainer.Visibility = ViewStates.Gone;

					FrameLayout.LayoutParams llp = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
					llp.SetMargins(100, 0, 0, 0); // llp.setMargins(left, top, right, bottom);
					llp.Gravity = GravityFlags.CenterVertical;
					highlight.LayoutParameters = llp;

					highlight.SetTextColor(Color.White);

					highlight.TextSize = 20f;

				}
            else{
                //FrameLayout.LayoutParams llp = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
                //imageContainer.LayoutParameters = new ViewGroup.LayoutParams(LayoutParams.FillParent,LayoutParams.WrapContent);
                uploadedPic.Visibility = ViewStates.Visible;
                //imageContainer.RemoveView(highlight);
                bindings.Bind(uploadedPic).For(x => x.ImageUrl).To(x => x.PhotoUrl).WithConversion(new DynamicMvxImageViewConverter());

            }

			bindings.Apply();

				return view;

			
		}
		public Bitmap getBitmapFromURL(String src)
		{
			try
			{
				URL url = new URL(src);
				System.Console.WriteLine("SRC: " + src);
				HttpURLConnection connection = (HttpURLConnection)url.OpenConnection();
				connection.DoInput = true;
				connection.Connect();
				var input = connection.InputStream;
				Bitmap myBitmap = BitmapFactory.DecodeStream(input);
				return myBitmap;
			}
			catch (Exception e)
			{
				// Log exception
				return null;
			}
		}

		private Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;

            using (var webClient = new System.Net.WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}

			return imageBitmap;
		}

		/*public void setScaleImage(MvxImageView view, string path)
        {
             Get the ImageView and its bitmap
            Drawable drawing = view.Drawable;
            var bitmap = this.GetImageBitmapFromUrl(path);
             Get current dimensions
            int width = bitmap.Width;
            int height = bitmap.Height;

            float xScale = ((float)4) / width;
            float yScale = ((float)4) / height;
            float scale = (xScale <= yScale) ? xScale : yScale;

            Matrix matrix = new Matrix();
            matrix.PostScale(scale, scale);

            Bitmap scaledBitmap = Bitmap.CreateBitmap(bitmap, 0, 0, width, height, matrix, true);
            BitmapDrawable result = new BitmapDrawable(scaledBitmap);
            width = scaledBitmap.Width;
            height = scaledBitmap.Height;

            view.SetImageDrawable(result);

            var pparams = view.LayoutParameters;
            pparams.Width = width;
            pparams.Height = width;
            System.Console.WriteLine("WIDTH: " + pparams.Width);
            System.Console.WriteLine("HEIGHT: " + pparams.Height);

            view.LayoutParameters = pparams;
        }*/



		private void Post_EditButton_Click(object sender, EventArgs e)
		{
			/*_menu.Gravity = GravityFlags.Right;
            _menu.Show();*/

			var popup = CreatePopupWindow(context);
			popup.ShowAsDropDown((View)sender, 0, 0);




		}




	}





}