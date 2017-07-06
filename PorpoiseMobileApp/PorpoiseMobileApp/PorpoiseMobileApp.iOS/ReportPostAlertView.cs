using System;
using CoreAnimation;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class ReportPostAlertView : UIViewController
    {
        public ReportPostAlertView() : base("ReportPostAlertView", null)
        {
        }
        private UIViewController _parentViewController;

        public UIViewController ParentViewController{

            get{

                return _parentViewController;

            }set{

                _parentViewController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.StyleComponents();
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
            this.addEvents();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void StyleComponents()
        {

            this.porpoiseLogo.Image = Services.PorpoiseImage.getFromURL(Services.PorpoiseImage.PorpoiseLogo);
            this.contentView.Layer.CornerRadius = 10;
            nfloat borderWidth = 1.0f;

           
            contentView.Layer.BorderColor = PorpoiseColors.FromHex(0xF2F2F2).CGColor;
            contentView.Layer.BorderWidth = borderWidth;
            topView.roundCorners((UIRectCorner.TopLeft | UIRectCorner.TopRight), 10,10);
            topView.BackgroundColor = PorpoiseColors.FromHex(0xF2F2F2);
            ReportPost.TintColor = PorpoiseColors.FromHex(0xFB686C);
            ReportUser.TintColor = PorpoiseColors.FromHex(0xFB686C);


        }



        //add buttons events
        public void addEvents(){
            
            this.ReportPost.TouchDown += (sender, ea) => { 

           

                ReportCompletedViewController dialog = new ReportCompletedViewController();
                dialog.ParentViewController = this.ParentViewController;
               
                TransitionViewController transition = (TransitionViewController)this.ParentViewController;

				transition.dismissController(this, false);

				transition.presentController(dialog, false);




			};

           

            this.ReportUser.TouchDown += (sender, ea) =>
            {

              
                ReportUserViewController dialog = new ReportUserViewController();
                //dialog.View.Frame = this.View.Bounds;
                dialog.ParentViewController = this.ParentViewController;

                TransitionViewController transition = (TransitionViewController)this.ParentViewController;

                transition.dismissController(this, false);

                transition.presentController(dialog, false);

                //dialog.View.BackgroundColor = UIColor.Clear;
                //dialog.View.InsertSubview(beView, 0);
                //dialog.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;

                //dialog.PreviousViewController = this;
                //this.View.Hidden = true; 
                //ParentViewController.PresentViewController(dialog, false, null);


            };

        }
    }
}

