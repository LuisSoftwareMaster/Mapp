using System;

using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class CustomDialog : UIViewController
    {
        public CustomDialog() : base("CustomDialog", null)
        {
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

