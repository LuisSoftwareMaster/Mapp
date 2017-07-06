using System;
using System.Diagnostics;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class LoginTutorialFirst : UIViewController
    {
        public LoginTutorialFirst() : base("LoginTutorialFirst", null)
        {
        }

        private UIViewController parentController;

        public UIViewController ParentController{

            get{

                return parentController;

            }
            set{

                parentController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            UIApplication.SharedApplication.StatusBarHidden = true;
            UIImage image=Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/tutorialloginbackground.png");

            //image.Scale(new CoreGraphics.CGSize(this.View.Bounds.Width, this.View.Bounds.Height));

            this.backgroundImage.ContentMode = UIViewContentMode.ScaleAspectFill;

            this.backgroundImage.ClipsToBounds = true;

            this.backgroundImage.Image = image;

            nextButton.BackgroundColor = PorpoiseColors.Turquoise;

            NSLayoutConstraint constraint = NSLayoutConstraint.Create(nextButton, NSLayoutAttribute.Top, NSLayoutRelation.Equal, backgroundImage, NSLayoutAttribute.Top, 1, ((System.nfloat)(this.View.Bounds.Height * .1)));

            this.View.AddConstraint(constraint);

       

            this.nextButton.TouchDown += (sender, e) => {

                SecondLoginTutorial svc = new SecondLoginTutorial();

                svc.ParentController = this;

                this.PresentViewController(svc, false, null);

            };

            var tap = new UITapGestureRecognizer(()=>{

				this.DismissViewController(false, null);

            });

            this.skipLabel.AddGestureRecognizer(tap);

            skipLabel.UserInteractionEnabled = true;

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

