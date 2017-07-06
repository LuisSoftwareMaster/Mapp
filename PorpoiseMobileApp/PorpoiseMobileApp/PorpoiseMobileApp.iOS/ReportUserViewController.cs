using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class ReportUserViewController : UIViewController
    {
        public ReportUserViewController() : base("ReportUserViewController", null)
        {
        }

        private UIViewController _parentViewController;

        private UIViewController _previousViewController;

        public UIViewController PreviousViewController{

            get{

                return _previousViewController;

            }
            set{

                _previousViewController = value;

            }

        }

        public UIViewController ParentViewController{

            get{

                return _parentViewController;

            }

            set{

                _parentViewController = value;

            }

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.addButtonEvents();

        }

        public override void ViewWillAppear(bool animated)
        {


            base.ViewWillAppear(animated);
           // this.PreviousViewController.DismissViewController(false, null);
            styleComponents();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void styleComponents(){

            this.topView.BackgroundColor = PorpoiseColors.FromHex(0xF2F2F2);

            this.innapropriate.TintColor = PorpoiseColors.FromHex(0xFB686C);

			this.other.TintColor = PorpoiseColors.FromHex(0xFB686C);

			nfloat borderWidth = 1.0f;

			//contentView.Frame = CGRectInset(self.frame, -borderWidth, -borderWidth);
            contentView.Layer.BorderColor = PorpoiseColors.FromHex(0xF2F2F2).CGColor;
			contentView.Layer.BorderWidth = borderWidth;
            cancelView.Layer.BorderColor = PorpoiseColors.FromHex(0xF2F2F2).CGColor;
            cancelView.Layer.BorderWidth = borderWidth;
			topView.roundCorners((UIRectCorner.TopLeft | UIRectCorner.TopRight), 10, 10);

        }

        private void addButtonEvents(){

            this.cancel.TouchDown += (sender, ea) => {

                this.DismissViewController(true, null);
                this.ParentViewController.DismissViewController(false, null);
            };

            this.innapropriate.TouchDown += (sender, ea) =>
            {
                TransitionViewController transition = (TransitionViewController)this.ParentViewController;

                if (transition.ParentViewController is ActivityViewController)
				{

                    ActivityViewController controller = (ActivityViewController)transition.ParentViewController;

					controller.ViewModel.reportUser("inappropriate_content");

				}

				ReportCompletedViewController dialog = new ReportCompletedViewController();
				dialog.ParentViewController = this.ParentViewController;

				

				transition.dismissController(this, false);

				transition.presentController(dialog, false);
				


            };

             this.other.TouchDown += (sender, ea) =>
            {
				TransitionViewController transition = (TransitionViewController)this.ParentViewController;
                ReportOtherReasonViewController dialog = new ReportOtherReasonViewController();
				dialog.ParentViewController = this.ParentViewController;



				transition.dismissController(this, false);

				transition.presentController(dialog, false);


            };

        }
    }
}

