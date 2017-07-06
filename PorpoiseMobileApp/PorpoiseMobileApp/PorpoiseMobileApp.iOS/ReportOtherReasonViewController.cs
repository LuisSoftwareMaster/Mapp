using System;
using CoreAnimation;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class ReportOtherReasonViewController : UIViewController
    {
        public ReportOtherReasonViewController() : base("ReportOtherReasonViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.addEvents();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private UIViewController _parentViewController;

        public UIViewController ParentViewController{

            get{

                return _parentViewController;

            }
            set{

                _parentViewController = value;

            }

        }


        private void styleComponents(){

            submit.TintColor = PorpoiseColors.FromHex(0xFB686C);

			nfloat borderWidth = 1.0f;

			//contentView.Frcoame = CGRectInset(self.frame, -borderWidth, -borderWidth);
            contentView.Layer.BorderColor = PorpoiseColors.FromHex(0xF2F2F2).CGColor;
			contentView.Layer.BorderWidth = borderWidth;

			topView.roundCorners((UIRectCorner.TopLeft | UIRectCorner.TopRight), 10, 10);
            topView.BackgroundColor = PorpoiseColors.FromHex(0xF2F2F2);
            UIBezierPath path = UIBezierPath.FromRoundedRect(reason.Bounds, (UIRectCorner.BottomLeft | UIRectCorner.BottomRight), new CoreGraphics.CGSize(10, 10));

			CAShapeLayer maskLayer = new CAShapeLayer();

			maskLayer.Frame = reason.Bounds;

			maskLayer.Path = path.CGPath;

			reason.Layer.Mask = maskLayer;

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			var screenTap = new UITapGestureRecognizer(() =>
			{
                reason.ResignFirstResponder();

			});

            this.View.AddGestureRecognizer(screenTap);

            this.styleComponents();
        }
       

        private void addEvents(){

             this.cancel.TouchDown += (sender, ea) => {



				 this.DismissViewController(true, null);
				 this.ParentViewController.DismissViewController(false, null);

            };

			this.submit.TouchDown += (sender, ea) =>
			{
                TransitionViewController transition = (TransitionViewController)this.ParentViewController;
                if (transition.ParentViewController is ActivityViewController && !string.IsNullOrEmpty(reason.Text))
                {
                    this.errorLabel.Hidden = false;

                    ActivityViewController controller = (ActivityViewController)transition.ParentViewController;

                    controller.ViewModel.reportUser(reason.Text);


					ReportCompletedViewController dialog = new ReportCompletedViewController();

					dialog.ParentViewController = this.ParentViewController;

					transition.dismissController(this, false);

					transition.presentController(dialog, false);
					

                }
                else{

                    //Reason is null

                    errorLabel.TextColor = PorpoiseColors.FromHex(0xFB686C);
                    this.errorLabel.Hidden = false;
					

                }

			};


		}

    }
}

