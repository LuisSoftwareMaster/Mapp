using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class ReportCompletedViewController : UIViewController
    {
        public ReportCompletedViewController() : base("ReportCompletedViewController", null)
        {
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

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            styleComponents();
        }

        private void styleComponents(){

			this.porpoiseLogo.Image = Services.PorpoiseImage.getFromURL(Services.PorpoiseImage.PorpoiseLogo);
			this.contentView.Layer.CornerRadius = 10;
			nfloat borderWidth = 1.0f;

			//contentView.Frame = CGRectInset(self.frame, -borderWidth, -borderWidth);
			contentView.Layer.BorderColor = PorpoiseColors.FromHex(0xF2F2F2).CGColor;
			contentView.Layer.BorderWidth = borderWidth;

			topView.roundCorners((UIRectCorner.TopLeft | UIRectCorner.TopRight), 10, 10);
            topView.BackgroundColor = PorpoiseColors.FromHex(0xF2F2F2);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var screenTap = new UITapGestureRecognizer(() =>
            {
				this.DismissViewController(true, null);
				this.ParentViewController.DismissViewController(false, null);

            });
            this.View.AddGestureRecognizer(screenTap);
        }

      

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

