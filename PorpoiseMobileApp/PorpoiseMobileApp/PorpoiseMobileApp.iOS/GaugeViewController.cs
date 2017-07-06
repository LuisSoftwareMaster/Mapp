using System;

using UIKit;

using Foundation;

namespace PorpoiseMobileApp.iOS
{
    public partial class GaugeViewController : UIViewController
    {
        public GaugeViewController() : base("GaugeViewController", null)
        {
        }

       /* private void loadImages(){

            nfloat scale = UIScreen.MainScreen.Scale;

            if(scale>=2){

                individualImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team%402x.png");

                groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19%402x.png");


            }
            else{

				individualImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team.png");

				groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19.png");

            }

        }

        private void styleComponents(){

            foreach(NSLayoutConstraint constraint in individualImage.Constraints){

               

                    Console.WriteLine("GAUGE CONSTRAINT: " + constraint.Description + ", CONSTANT: " + constraint.Constant + "VIEW " + this.View.Bounds.Height);

                

            }

        }*/

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            //this.loadImages();

            //this.styleComponents();

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

