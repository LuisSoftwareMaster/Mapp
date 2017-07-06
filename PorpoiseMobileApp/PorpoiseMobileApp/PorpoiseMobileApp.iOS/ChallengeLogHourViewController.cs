using Foundation;
using System;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Models;
using System.Collections.Generic;
using MvvmCross.Binding.iOS.Views;
using System.Diagnostics;
using CoreGraphics;
using System.Linq;

namespace PorpoiseMobileApp.iOS
{
	public  partial class ChallengeLogHourViewController : MvvmViewController<ChallengeLogHourViewModel>
    {
		private List<Goal> goalsSource;



		public List<Goal> GoalsSource
		{

			get
			{

				return goalsSource;

			}

			set
			{

				goalsSource = value;

			}

		}


		void NavigationBarSetUp()
		{
            UIButton button = new UIButton();
			if (this.NavigationController != null)
			{
				//TODO: figure out how to make the status bar opaque.
				this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Default;
				//this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
				this.NavigationController.NavigationBar.ShadowImage = new UIImage();
				this.NavigationController.NavigationBar.BackgroundColor = UIColor.White;
				//this.NavigationController.NavigationBar.BackgroundColor = UIColor.White;
				this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
			}

			//this.NavigationController.NavigationBar.BackgroundColor = UIColor.Black;

			nfloat scale = UIScreen.MainScreen.Scale;

			NavigationController.NavigationBar.Translucent = false;
			float imageSize = 20f;

			float gap = 5f;

			float borderSize = 0f;

			float textHeight = 1f;

			float buttonWidth = 60;

			float buttonHeight = borderSize * 2 + gap * 3 + imageSize + textHeight;

			float imageOrigin = borderSize + gap;

			float textTop = imageOrigin + imageSize + gap;

			float textBottom = borderSize + gap;

			float imageBottom = textBottom + textHeight + gap;

			UIBarButtonItem[] rightButtons = new UIBarButtonItem[2];
			UIImage next = null;


			UIImage post = null;

			UIButton postButton = UIButton.FromType(UIButtonType.Custom);


			

		        button = UIButton.FromType(UIButtonType.Custom);

			
				if (scale >= 2)
				{
					next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Cancel%402x.png");

				}
				else
				{

					next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Cancel.png");

				}


			


			


			button.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(next, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);

			button.SetBackgroundImage(next, UIControlState.Normal);

            Bindings.Bind(button).To(vm => vm.CancelCommand).Apply();

				if (scale >= 2)
				{

					post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next%402x.png");



				}
				else
				{

					post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next.png");

				}

			postButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(post, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);


			postButton.SetBackgroundImage(post,UIControlState.Normal);

            Bindings.Bind(postButton).To(vm => vm.BackCommand).Apply();


			UIBarButtonItem barButtonRightTwo = new UIBarButtonItem(postButton);
			UIBarButtonItem barButtonRightOne = new UIBarButtonItem(button);

			foreach (NSLayoutConstraint constraint in button.Constraints)
			{

				Debug.WriteLine("BUTTON " + constraint.Description + " " + constraint.Constant);

			}

			rightButtons[0] = barButtonRightTwo;
			rightButtons[1] = barButtonRightOne;
			NSLayoutConstraint topConstraint = NSLayoutConstraint.Create(postButton, NSLayoutAttribute.Top, NSLayoutRelation.Equal, button, NSLayoutAttribute.Top, 1, 0);

			//this.NavigationController.NavigationBar.AddConstraint(topConstraint);
			//Add Constraints


			//NSLayoutConstraint.ActivateConstraints(constraints);
			//rightButton2.AddConstraint(alingY);


			this.NavigationController.NavigationBar.ContentMode = UIViewContentMode.Center;
			/*UIButton rigthButton = new UIButton();

            rigthButton.Frame = new CGRect(0, 0, buttonWidth, buttonHeight);

            rigthButton.Center = this.View.Center;

            //Image

            UIImage logout = new UIImage("logout.png");

            rigthButton.SetImage(logout, UIControlState.Normal);

            rigthButton.ImageEdgeInsets = new UIEdgeInsets(0, 15, 0, 0);

            rigthButton.SetTitle(Resource.Logout, UIControlState.Normal);

            rigthButton.TitleEdgeInsets = new UIEdgeInsets(textTop, -logout.Size.Width, textBottom, 0.0f);

            rigthButton.TitleLabel.Font = UIFont.FromName("Ubuntu-Light", 15f);

            rigthButton.TintColor = UIColor.Black;

            rigthButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            rigthButton.SetTitleShadowColor(UIColor.Blue, UIControlState.Normal);

            rigthButton.TouchUpInside += delegate
            {
                var user = NSUserDefaults.StandardUserDefaults;

                user.SetBool(true, "logged");

                //ViewModel.Logout();

            };*/

			NavigationItem.SetRightBarButtonItems(rightButtons, true);



			//NavigationItem.RightBarButtonItem.Title = Resource.Logout;

			//NavigationItem.RightBarButtonItem.Image = new UIImage("logout.png");

			UIImage leftImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/por-logo.png");

			UIButton leftButton = UIButton.FromType(UIButtonType.Custom);

			leftButton.UserInteractionEnabled = false;

			leftButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(leftImage, (nfloat)(NavigationController.NavigationBar.Bounds.Height * 0.6)), NavigationController.NavigationBar.Bounds.Height * 0.6);

			leftButton.SetImage(leftImage, UIControlState.Normal);

			UIBarButtonItem leftButtonBar = new UIBarButtonItem(leftButton);
			//leftButton.TintColor = UIColor.Black;
			NavigationItem.SetLeftBarButtonItem(leftButtonBar, true);
		}

        public ChallengeLogHourViewController (IntPtr handle) : base (handle)
        {
        }



		public override  void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
            this.NavigationController.NavigationBar.Hidden = false;
			UIApplication.SharedApplication.StatusBarHidden = false;

			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;
            LogPost.clear();
			/*InvokeOnMainThread(() =>
					{
						ViewModel.LoadChallenges("");
					});*/

			//this.topHeaderView.BackgroundColor = PorpoiseColors.Turquoise;
			Debug.WriteLine("DISPLAY NAVIGATION BAR");



			this.NavigationBarSetUp();

			SetupChallengerSource("");

			this.searchBar.TextChanged += (sender, e) =>
			{

				Debug.WriteLine("Text Changed " + e.SearchText);



				SetupChallengerSource(e.SearchText);



			};

           


            try
            {

                if (this.TabBarController != null)
                {
                    nfloat tabBarHeight = this.TabBarController.TabBar.Bounds.Height;

                    this.TabBarController.TabBar.RemoveFromSuperview();

                    //this.challengers.Frame = new CGRect(this.challengers.Bounds.X, this.challengers.Bounds.Y, this.challengers.Bounds.Width, this.challengers.Bounds.Height + tabBarHeight);
                   // this.View.Frame = this.TabBarController.View.Frame;
                    this.TabBarController.View.BackgroundColor = UIColor.White;
                  //  this.View.BackgroundColor = UIColor.White;

                }
            }catch(System.NullReferenceException ex){



            }
		}
		public  override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.searchBar.SearchBarStyle = UISearchBarStyle.Minimal;
		
			this.styleComponents();
			

			//this.ViewModel.LoadChallenges();

		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);

			this.challengers.Delegate = null;
		}

		private async void SetupChallengerSource(String search) {


			await ViewModel.LoadChallenges(search);
			
			ViewModel.InFlight = true;

			//Set Up Goal Source

			goalsSource = new System.Collections.Generic.List<Goal>();

		
			goalsSource = ViewModel.Goals;


			//Debug.WriteLine("GOAL SOURCE SIZE: "+ViewModel.Goals.Count);

			var goalSource = new OrganisationTableSource(goalsSource,this.challengers,this);

			this.challengers.Source = goalSource;



			//challengers.SetNeedsLayout();
			//challengers.LayoutIfNeeded();
			this.challengers.ReloadData();
            if (!string.IsNullOrEmpty(this.ViewModel.GoalId.ToString()) && !this.ViewModel.GoalId.ToString().Equals("00000000-0000-0000-0000-000000000000"))
            {
                Debug.WriteLine("VIEWMOEL GOALID: "+this.ViewModel.GoalId);

                UITableViewCell[] cells = challengers.VisibleCells;

                OrganizationSearchItem cell = (OrganizationSearchItem)cells[0];

                cell.Check.Hidden = false;

            }

			ViewModel.InFlight = false;
		}

		public void navigate() {

			this.ViewModel.navigateLogPostOrganisation();
		
		}
		private void styleComponents()
		{
			this.headerBrackgroud.BackgroundColor = PorpoiseColors.Turquoise;
			foreach (NSLayoutConstraint constraint in this.headerContainer.Constraints)
			{
				if (constraint.Description.Contains("width"))
				{
					constraint.Constant = this.View.Bounds.Width;

				}

			}

			foreach (NSLayoutConstraint constraint in this.headerLabel.Constraints)
			{
				if (constraint.Description.Contains("width"))
				{
					constraint.Constant = (System.nfloat)(this.View.Bounds.Width * 0.8);

				}

			}

			//Center label
			NSLayoutConstraint centerConstraint = NSLayoutConstraint.Create(headerLabel, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this.headerContainer, NSLayoutAttribute.CenterX, 1, 0);
			this.headerContainer.AddConstraint(centerConstraint);
			this.headerContainer.UpdateConstraints();
		}

    }

	//Table Source


	public class OrganisationTableSource : MvxTableViewSource
	{
		bool resize = false;
		int numberLinesIncrease = 0;

		private nfloat heightIncrement = 0;

		public List<Goal> goals { get; set; }
		private static readonly NSString ChallengeCellIdentifier = new NSString("OrganizationSearchItem");

		public event EventHandler<RowSelectedEventArgs> IsRowSelected;
		private ChallengeLogHourViewController challengeController;

		private bool hidden;
		private nfloat reduce = 0;

		private UIFont textFont;



		public OrganisationTableSource(UITableView tableView) : base(tableView)
		{
			this.goals = new List<Goal>();

		}



		public OrganisationTableSource(List<Goal> goals, UITableView tableView, ChallengeLogHourViewController challengeLogHourViewController) : base(tableView)
		{
			


			this.goals = new List<Goal>();

            if(challengeLogHourViewController.ViewModel.GoalId != null && !challengeLogHourViewController.ViewModel.GoalId.Equals("00000000-0000-0000-0000-000000000000")){

				
                this.previousRow = NSIndexPath.FromRowSection(0, 0);

            }

			this.challengeController = challengeLogHourViewController;

			if (goals != null && goals.Count > 0)
			{
				Debug.WriteLine("GOALS IS NOT NULL IN TABLE VIEW SOURCE: "+goals.Count);
				
				tableView.RegisterNibForCellReuse(UINib.FromName("OrganizationSearchItem", NSBundle.MainBundle), ChallengeCellIdentifier);
				this.goals = goals;
				ItemsSource = this.goals;
				this.TableView.RowHeight = UITableView.AutomaticDimension;
				this.TableView.EstimatedRowHeight = 550f;
				tableView.SeparatorColor = UIColor.White;
				tableView.SeparatorInset = UIEdgeInsets.FromString("{1,0,0,1}");
			}

				tableView.SeparatorInset = UIEdgeInsets.Zero;

			this.TableView.ReloadData();
            NSIndexPath indexPath = NSIndexPath.FromRowSection(TableView.NumberOfSections()-1, TableView.NumberOfRowsInSection(TableView.NumberOfSections() - 1)-1);

           //indexPath.

			}


        private NSIndexPath previousRow = null;

        private string goalName = "";

        public override void Scrolled(UIScrollView scrollView)
        {
           // base.Scrolled(scrollView);

            foreach(UITableViewCell cell in TableView.VisibleCells){

                OrganizationSearchItem orgCell = (OrganizationSearchItem)cell;
               
                if(orgCell.Title.Text.ToLower().Equals(goalName.ToLower())){

                    orgCell.Check.Hidden = false;

                }
                else{

                    orgCell.Check.Hidden = true;

                }

            }
        }
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			base.RowSelected(tableView, indexPath);
			var goal = this.goals[indexPath.Row];

            if(previousRow !=null && tableView.CellAt(previousRow)!=null  && previousRow!=indexPath){

                OrganizationSearchItem previousCell = (PorpoiseMobileApp.iOS.OrganizationSearchItem)tableView.CellAt(previousRow);

                previousCell.Check.Hidden = true;

            }
            previousRow = indexPath;
			
			LogPost.goal = goal;

            OrganizationSearchItem row = (PorpoiseMobileApp.iOS.OrganizationSearchItem)tableView.CellAt(indexPath);

            row.Check.Hidden = !row.Check.Hidden;

            if(!row.Check.Hidden){

                goalName = goal.Name;

            }

			this.challengeController.ViewModel.Goal = goal;

			this.challengeController.navigate();

				if (IsRowSelected != null)
			{
				var args = new RowSelectedEventArgs(tableView, indexPath);
				IsRowSelected(this, args);
			};

			tableView.DeselectRow(indexPath, false);

		}







		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			Goal goal = this.goals.ElementAt(indexPath.Row);
			//testCell.PostDetails.Frame = new CGRect(testCell.PostDetails.Frame.X, testCell.PostDetails.Frame.Y, testCell.PostDetails.Frame.Width, this.numberLinesLabel(testCell.PostDetails));
			if (textFont != null)
			{

				return 44f + heightForLabel(textFont, (float)(TableView.Bounds.Width * 0.7), goal.Name);

			}
			else {

				return 44f;
			
			}
		}



		private nfloat heightForLabel(UIFont font, float width, string text)
		{

			UILabel label = new UILabel();

			label.Frame = new CGRect(0, 0, width, float.MaxValue);

			label.Lines = 0;

			label.LineBreakMode = UILineBreakMode.WordWrap;

			label.Font = font;

			label.Text = text;

			label.SizeToFit();



			return label.Frame.Height;

		}


		protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
		{
			
			Debug.WriteLine("TRYING TO CREATE CELL");
			this.numberLinesIncrease = 0;

			resize = false;

			var goal = (Goal)item;

			OrganizationSearchItem cell = (OrganizationSearchItem)tableView.DequeueReusableCell(ChallengeCellIdentifier, indexPath);

			foreach (NSLayoutConstraint constraint in cell.Constraints)
			{
				if (constraint.Description.Contains("width"))
				{
					constraint.Constant = this.TableView.Bounds.Width;

				}

			}

			textFont = cell.Title.Font;

			cell.Title.Text = goal.Name;

			cell.Title.resizeLabel();
			foreach (NSLayoutConstraint constraint in cell.Title.Constraints)
			{
				if (constraint.Description.Contains("width"))
				{
					constraint.Constant = (System.nfloat)(this.TableView.Bounds.Width * 0.7);

				}

			}
			cell.LayoutMargins = UIEdgeInsets.Zero;

			Debug.WriteLine("RETURNING CELL");
			cell.Frame = new CGRect(cell.Bounds.X, cell.Bounds.Y, cell.Bounds.Width*.8, cell.Bounds.Height);
			return cell;

		}




	}



}