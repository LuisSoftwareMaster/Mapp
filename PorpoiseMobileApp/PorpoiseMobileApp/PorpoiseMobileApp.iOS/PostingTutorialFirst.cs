using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PostingTutorialFirst : UIViewController
    {
        public PostingTutorialFirst() : base("PostingTutorialFirst", null)
        {
        }

        private UIViewController parentController;

        public UIViewController ParentController{

            get{

                return parentController;

            }
            set{

                this.parentController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			UIApplication.SharedApplication.StatusBarHidden = true;

			this.backgroundImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Posting+tuto+1+-+BG.png");

			this.backgroundImage.ContentMode = UIViewContentMode.ScaleAspectFill;

			this.backgroundImage.ClipsToBounds = true;

            this.nextButton.BackgroundColor = PorpoiseColors.Turquoise;

            this.nextButton.TouchDown += (sender, e) => {

                PostingTutorialSecond pts = new PostingTutorialSecond();

                pts.ParentController = this;

                this.PresentViewController(pts, false, null);
            
            };

            var tap = new UITapGestureRecognizer(()=>{

                this.DismissViewController(false, null);

            });

            this.skipLabel.AddGestureRecognizer(tap);

            this.skipLabel.UserInteractionEnabled = true;
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

