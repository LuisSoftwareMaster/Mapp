using System;
using CoreGraphics;
using PorpoiseMobileApp.ViewModels;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class InvitationConfirmationViewController : MvvmViewController<InvitationConfirmationViewModel>
    {
       

		public InvitationConfirmationViewController(IntPtr handle) : base (handle)
        {
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
				next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+uploaded+from+iOS-2.jpg");

			}
			else
			{

				next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+uploaded+from+iOS-2.jpg");

			}








			button.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(next, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);

			button.SetBackgroundImage(next, UIControlState.Normal);


			if (scale >= 2)
			{

				post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next%402x.png");



			}
			else
			{

				post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next.png");

			}

			postButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(post, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);


			postButton.SetBackgroundImage(post, UIControlState.Normal);


			UIBarButtonItem barButtonRightOne = new UIBarButtonItem(button);



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

			//NavigationItem.RightBarButtonItem = barButtonRightOne;



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

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Bindings.Bind(backbutton).To(vm => vm.BackCommand);
            Bindings.Bind(addcoworkerbutton).To(vm => vm.BackCommand);
            Bindings.Apply();
        }

        private void styleComponents(){

            UIImage logoImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Header+Logo.png");

            logoImage = Services.PorpoiseImage.resizeImage(logoImage, logo.Bounds.Width);

            this.addcoworkerbutton.BackgroundColor = PorpoiseColors.Turquoise;

            foreach(NSLayoutConstraint constraint in logo.Constraints){

                if(constraint.Description.Contains("width")){

                    constraint.Constant = logoImage.Size.Width;

                }

				if (constraint.Description.Contains("height"))
				{

                    constraint.Constant = logoImage.Size.Height;

				}

            }

			foreach (NSLayoutConstraint constraint in line.Constraints)
			{

				if (constraint.Description.Contains("width"))
				{

                    constraint.Constant = this.View.Bounds.Width /2;

				}

				

			}

            logo.Image = logoImage;

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.NavigationBarSetUp();

            this.styleComponents();
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

      
    }
}

