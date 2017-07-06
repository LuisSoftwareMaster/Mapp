using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PostingTutorialThird : UIViewController
    {
        public PostingTutorialThird() : base("PostingTutorialThird", null)
        {
        }

        private UIViewController parentController;
        private bool check;

        public UIViewController ParentController{

            get{

                return this.parentController;

            }
            set{

                this.parentController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			UIApplication.SharedApplication.StatusBarHidden = true;

			this.backgroundImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/posting+tuto+3+BG.png");

            this.backgroundImage.ContentMode = UIViewContentMode.ScaleAspectFill;

            this.backgroundImage.ClipsToBounds = true;

            NSLayoutConstraint constraint = NSLayoutConstraint.Create(popupImage, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Top, 1, this.View.Bounds.Height / 3);

            this.View.AddConstraint(constraint);

            this.closeButton.TintColor = PorpoiseColors.Turquoise;

            this.postButton.TintColor = PorpoiseColors.Turquoise;

            this.gotButton.BackgroundColor = PorpoiseColors.Turquoise;

            this.closeButton.TouchDown += (sender, e) => {

                if(this.parentController is PostingTutorialSecond){

                    ((PostingTutorialSecond)this.parentController).TutoFour = true;

                    this.DismissViewController(false, null);

                }
            
            };

			this.check = false;


			//create check button

			UIButton checkButton = new UIButton();

			checkButton.Frame = new CoreGraphics.CGRect(this.container.Bounds.X, this.container.Bounds.Y, this.container.Bounds.Height * .6, this.container.Bounds.Height * .6);

			checkButton.BackgroundColor = UIColor.Clear;

			checkButton.Layer.BorderWidth = 1;

			checkButton.Layer.BorderColor = UIColor.White.CGColor;

			this.container.AddSubview(checkButton);

			//create label

			UILabel label = new UILabel();

			label.Text = "Don't show this again";

			label.Font = UIFont.FromName("Helvetica", 14f);

			label.TextColor = UIColor.White;

			label.Frame = new CoreGraphics.CGRect(this.container.Bounds.X + checkButton.Frame.Width + (checkButton.Frame.Width / 2), checkButton.Frame.Y, 0, 0);

			label.SizeToFit();

			label.Center = new CoreGraphics.CGPoint(label.Center.X, checkButton.Center.Y);

			this.container.AddSubview(label);

			//center container

			foreach (NSLayoutConstraint aux in container.Constraints)
			{

				if (aux.Description.Contains("width"))
				{

					aux.Constant = checkButton.Frame.Width + label.Frame.Width + (checkButton.Frame.Width / 2);

					//Debug.WriteLine("WIDTH FOUND");

				}


			}

			checkButton.TouchDown += (sender, e) =>
	   {

		   if (check)
		   {

			   check = false;

			   checkButton.SetBackgroundImage(null, UIControlState.Normal);

		   }
		   else
		   {

			   check = true;

			   UIImage checkImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/downloadedcheck.png");

			   checkImage.Scale(new CoreGraphics.CGSize(checkButton.Frame.Width * .8, checkButton.Frame.Height * .8));

			   checkButton.SetBackgroundImage(checkImage, UIControlState.Normal);

		   }
            
            };

            this.postButton.TouchDown += (sender, e) => {

                ((AddCoworkerViewController)(((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).ParentController)).redirectCreatePost();


				if (this.parentController is PostingTutorialSecond)
				{

					((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).View.Hidden = true;

					((PostingTutorialSecond)this.parentController).View.Hidden = true;

					((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).ParentController.DismissViewController(false, null);

					((PostingTutorialSecond)this.parentController).ParentController.DismissViewController(false, null);

					this.parentController.DismissViewController(false, null);

					this.DismissViewController(false, null);

				}

            };

            this.gotButton.TouchDown += (sender, e) => {
                //Change to false post tutorial in the api
                if(this.check){

                    ((AddCoworkerViewController)((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).ParentController).FlagTutorial();

                }

                if(this.parentController is PostingTutorialSecond){

                   ((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).View.Hidden = true;

                    ((PostingTutorialSecond)this.parentController).View.Hidden = true;

                    ((PostingTutorialFirst)((PostingTutorialSecond)this.parentController).ParentController).ParentController.DismissViewController(false, null);

                    ((PostingTutorialSecond)this.parentController).ParentController.DismissViewController(false, null);

					this.parentController.DismissViewController(false, null);

					this.DismissViewController(false, null);

                }

				

            };



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
    }
}

