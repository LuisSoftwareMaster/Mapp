using System;

using UIKit;
using System;
using Foundation;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Converters;
using Syncfusion.SfGauge.iOS;
using CoreGraphics;
using System.Linq;
using System.Diagnostics;
using PorpoiseMobileApp.Client;
using System.Globalization;
using System.Collections.Generic;
namespace PorpoiseMobileApp.iOS
{
    public partial class AddCoworkerViewController : UIViewController
    {
        public AddCoworkerViewController() : base("AddCoworkerViewController", null)
        {
			//Todo: Remove this line
			//AccountInfo.show_posting_tutorial = true;
        }
		void NavigationBarSetUp()
		{
			if (this.NavigationController != null)
			{
				//TODO: figure out how to make the status bar opaque.


				this.NavigationController.NavigationBar.BarStyle = UIBarStyle.BlackOpaque;
				this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
				this.NavigationController.NavigationBar.ShadowImage = new UIImage();
				this.NavigationController.NavigationBar.BackgroundColor = PorpoiseColors.Turquoise;
			}



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

			UIButton rigthButton = UIButton.FromType(UIButtonType.Custom);

			rigthButton.Center = this.View.Center;

			//Image

			UIImage logout = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/logout%402x.png");

			rigthButton.Frame = new CGRect(0, 15, buttonWidth, buttonHeight + 10);

			rigthButton.SetImage(logout, UIControlState.Normal);

			rigthButton.ImageEdgeInsets = new UIEdgeInsets(0, 15, 0, 10);

			rigthButton.ContentEdgeInsets = new UIEdgeInsets(0, 0, 15, 0);

			rigthButton.SetTitle(Resource.Logout, UIControlState.Normal);

			rigthButton.TitleEdgeInsets = new UIEdgeInsets(textTop, -logout.Size.Width, textBottom, 0.0f);

			rigthButton.TitleLabel.Font = UIFont.FromName("Ubuntu-Light", 15f);

			rigthButton.TouchUpInside += delegate
			{
				var user = NSUserDefaults.StandardUserDefaults;

				user.SetBool(true, "logged");

				//ViewModel.Logout();

			};

			NavigationItem.RightBarButtonItem = new UIBarButtonItem(rigthButton);


			//NavigationItem.RightBarButtonItem.Title = Resource.Logout;

			//NavigationItem.RightBarButtonItem.Image = new UIImage("logout.png");

			UIImage post = new UIImage("logo.png");


			UIButton leftButton = UIButton.FromType(UIButtonType.Custom);

			leftButton.UserInteractionEnabled = false;

			leftButton.Bounds = new CGRect(0, 0, post.Size.Width, post.Size.Height);

			//leftButton.Frame = new CGRect(0, 0, 30, 30);

			leftButton.SetImage(post, UIControlState.Normal);

			leftButton.SetImage(post, UIControlState.Disabled);

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem(leftButton);

			UILabel label = new UILabel();

			NavigationItem.LeftBarButtonItem.CustomView.Subviews.Append(label);


			NavigationItem.Title = "Porpoise";

		}

        private void styleComponents(){

            foreach(NSLayoutConstraint constraint in buttonsContainer.Constraints){

			
				if (constraint.Description.Contains("height"))
				{
					constraint.Constant = (System.nfloat)(this.View.Bounds.Height * .1);

				}

            }


            foreach (NSLayoutConstraint constraint in firstButton.Constraints)
			{


				if (constraint.Description.Contains("width"))
				{
                    constraint.Constant = (System.nfloat)(this.View.Bounds.Width /2);

				}

			}
            firstButton.UpdateConstraints();
            foreach (NSLayoutConstraint constraint in secondButton.Constraints)
			{


				if (constraint.Description.Contains("width"))
				{
					constraint.Constant = (System.nfloat)(this.View.Bounds.Width / 2);

				}

			}
            secondButton.UpdateConstraints();

            HomeViewController hvc = (HomeViewController)this.TabBarController;

            firstButton.TouchDown += (sender, e) => {

                hvc.createPost();

            };

            secondButton.TouchDown += (sender, e) =>
			{

                hvc.showInviteCoworker();

			};

        }

        public void FlagTutorial(){

			HomeViewController hvc = (HomeViewController)this.TabBarController;

            hvc.FlagTutorial();

        }

        public void redirectCreatePost(){

			HomeViewController hvc = (HomeViewController)this.TabBarController;

            hvc.createPost();

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

           
			if (AccountInfo.show_posting_tutorial)
			{
                PostingTutorialFirst vc = new PostingTutorialFirst();

				vc.ParentController = this;

				this.PresentViewController(vc, false, null);

				AccountInfo.show_posting_tutorial = false;
			}

            this.NavigationBarSetUp();

            this.styleComponents();

            Debug.WriteLine("SHOW POSTING TUTORIAL: "+AccountInfo.show_posting_tutorial);

			


        }
    }
}

