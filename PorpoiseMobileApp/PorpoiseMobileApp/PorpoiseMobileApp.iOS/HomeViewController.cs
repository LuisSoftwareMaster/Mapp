using System;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.iOS.Views;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace PorpoiseMobileApp.iOS
{

	public class HomeTabBarDelegate : UITabBarControllerDelegate
	{
		private HomeViewController ctrl;
		private HomeViewModel viewmodel;
		public HomeTabBarDelegate(HomeViewController ctrl, HomeViewModel viewmodel)
		{
			this.ctrl = ctrl;
			this.viewmodel = viewmodel;
		}
		public override bool ShouldSelectViewController(UITabBarController tabBarController, UIViewController viewController)
		{Console.WriteLine("SHOULD SELECT");
			LogPost.clear();
			LogPost.action = "add";
			var screen = tabBarController.SelectedViewController as IDirty;

			if (screen == null)
			{
				return true;
			}
			//else {
			//	ctrl.MoreNavigationController.PopToRootViewController(false);
			//}
			if (screen.IsDirty && (screen as PorpoiseTabNavigationController).MenuItem.Equals(MenuItem.LogHours))
			{
				ctrl.Confirm(Resources.AreYouSure, Resources.UnsavedChanges, null, ok =>
				{
					if (ok)
					{
						screen.Cleanup();
						ctrl.SelectedViewController = viewController;
					}
				});
				return false;
			}

			return true;
		}


	}

	//[Register ("HomeViewController")]
	public partial class HomeViewController : MvxTabBarViewController<HomeViewModel>, IHasDisplayHint
	{


		UIViewController selected;

		public HomeViewController(IntPtr handle) : base(handle)
		{
		}

		public override UIViewController SelectedViewController
		{
			get
			{
				return base.SelectedViewController;
			}
			set
			{
				base.SelectedViewController = value;
			}
		}

		public void FlagTutorial()
		{

			ViewModel.FlagTutorial();

		}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
			UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
           /* if (UIApplication.SharedApplication.StatusBarHidden)
            {

                UIApplication.SharedApplication.StatusBarHidden = false;

                UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

                //UIApplication.SharedApplication.StatusBarHidden = false;
            }*/
        }

        public void showChallenges(){

            this.ViewModel.showChallengesViewController();
            
            this.SelectedIndex = 2;

        }

		public void showInviteCoworker()
		{

            this.ViewModel.inviteCoworker();

			this.SelectedIndex = 2;

		}

        List<UIViewController> viewControllers;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();





			if (ViewModel == null)
				return;

			this.Delegate = new HomeTabBarDelegate(this, this.ViewModel);

			var menuItems = ViewModel.MenuItems;
			 viewControllers = new List<UIViewController>();
            var realizedMenuItems = menuItems.Where(x => x.MenuItem != MenuItem.Logout).ToList();
			selected = null;

			foreach (var item in realizedMenuItems)
			{

                //Create Post
                // item.Target = typeof(ActivityViewModel);

                    var tabv = CreateTabFor(item);

					if (SelectedTabDefault.HasValue && SelectedTabDefault.Value == tabv.MenuItem)
					{
						selected = tabv;
						SelectedTabDefault = null;
					}



                    viewControllers.Add(tabv);
                
                
                
				
			}

			if (selected == null)
            {
                //change to 0
				selected = viewControllers[1];
               
				SetViewControllers(viewControllers.ToArray(), false);

				this.TabBar.TintColor = PorpoiseColors.Grey;
				this.TabBar.SelectedImageTintColor = PorpoiseColors.Orange;
				this.TabBar.BarTintColor = UIColor.White;
               
				UITabBar.Appearance.SelectedImageTintColor = PorpoiseColors.Orange;
				CustomizableViewControllers = new UIViewController[] { };

				SelectedViewController = selected;
                //SelectedViewController.View.BackgroundColor = PorpoiseColors.Orange;
                //SelectedViewController.TabBarController.TabBar.Items[2].Image = UIImage.FromFile("plusIcon.png");

               //SelectedViewController.TabBarController.TabBar.Items[2].ImageInsets = new UIEdgeInsets(6, 0, -6, 0);
			}

		}


		public virtual bool CloseChildViewModel(IMvxViewModel viewModel)
		{
			// current implementation assumes the ViewModel to close is the currently shown ViewController 
			var navController = SelectedViewController as UINavigationController;
			if (navController != null)
			{
				navController.PopViewController(true);
				return true;
			}
			return false;
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			//set up for TabBar having more than 5 items
			//			var more = this.MoreNavigationController;
			//			more.Delegate = new MoreNavigationDelegate ();
			//
			//			//make the icons in the more menu Turquoise
			//			more.TopViewController.View.TintColor = PorpoiseColors.Turquoise;

		}

        public void createPost(){

            this.ViewModel.createPost();

        }

		private int _createdSoFarCount = 0;

		private PorpoiseTabNavigationController CreateTabFor(MenuItemViewModel menuItem)
		{
			string imageName;

			var controller = new PorpoiseTabNavigationController(menuItem);
            if (menuItem.MenuItem != MenuItem.LogHours)
            {
                var request = new MvxViewModelRequest(menuItem.Target, null, null, new MvxRequestedBy());

                var screen = Mvx.Resolve<IMvxIosViewCreator>().CreateView(request) as UIViewController;

                imageName = SelectTabImage(menuItem.MenuItem);
                SetTitleAndTabBarItem(screen, menuItem.Title, imageName);
                controller.PushViewController(screen, false);

            }
            else{

                var screen = new AddCoworkerViewController();

				imageName = SelectTabImage(menuItem.MenuItem);
				SetTitleAndTabBarItem(screen, menuItem.Title, imageName);
				controller.PushViewController(screen, false);

            }

			return controller;
		}

		private string SelectTabImage(MenuItem menuItem)
		{
			string imageName;
			switch (menuItem)
			{
				case MenuItem.Activity:
					imageName = "activityIcon";
					break;
				case MenuItem.LogHours:
					imageName = "plusIcon";
					break;
				case MenuItem.AccountSettings:
					imageName = "settings";
                    break;
				case MenuItem.Profile:
					imageName = "iconProfile";
					break;
				case MenuItem.Intercom:
					imageName = "intercom";
					break;
                default:
					imageName = null;
					break;
			}
			return imageName;
		}


		private void SetTitleAndTabBarItem(UIViewController screen, string title, string imageName)
		{
			//screen.Title = title;
			screen.TabBarItem = new UITabBarItem(null, GetTabImage(imageName), GetTabImage(imageName, true));
            UIImage image = GetTabImage(imageName, false);



            screen.TabBarItem.Tag = _createdSoFarCount;
            //screen.TabBarItem.Image = image.Scale(new CoreGraphics.CGSize(30,30));
			//Tab bar icon in the middle
			screen.TabBarItem.ImageInsets = new UIEdgeInsets(6, 0, -6, 0);
            //screen.TabBarItem.Image = screen.TabBarItem.Image.Scale(new CoreGraphics.CGSize(Services.PorpoiseImage.getAppropriateWidth(screen.TabBarItem.Image,(nfloat)(this.TabBar.Frame.Height * .7)), (nfloat)(this.TabBar.Frame.Height * .7)));
			_createdSoFarCount++;
		}

		private UIImage GetTabImage(string imageName, bool selected = false)
		{
            

            return  UIImage.FromFile(imageName+".png");
		}

		public void ShowGrandChild(IMvxIosView view)
		{
			var currentNav = SelectedViewController as UINavigationController;
			currentNav.PushViewController(view as UIViewController, true);
		}

		public bool ShowView(IMvxIosView view)
		{
			if (TryShowViewInCurrentTab(view))
				return true;

			return false;
		}

		private bool TryShowViewInCurrentTab(IMvxIosView view)
		{
			var navigationController = (UINavigationController)this.SelectedViewController;
			navigationController.PushViewController((UIViewController)view, true);
			return true;
		}

		#region IHasDisplayHint implementation

		public DisplayHint Hint
		{
			get
			{
				var hint = new DisplayHint();
				hint.FullScreen = true;
				hint.ClearToRoot = true;
				hint.Animate = false;
				return hint;
			}
		}

		#endregion

		public static MenuItem? SelectedTabDefault
		{
			get;
			set;
		}
	}
}
