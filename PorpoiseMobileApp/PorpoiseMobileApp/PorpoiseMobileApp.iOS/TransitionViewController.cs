using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class TransitionViewController : UIViewController
    {
        public TransitionViewController() : base("TransitionViewController", null)
        {
        }

        UIViewController _parentViewController;

       public  UIViewController ParentViewController{

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
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void presentController(UIViewController controller, bool animation){
            controller.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;
            this.PresentViewController(controller, animation, null);

        }

        public void dismissController(UIViewController controller, bool animation){

            controller.DismissViewController(animation, null);

        }
    }
}

