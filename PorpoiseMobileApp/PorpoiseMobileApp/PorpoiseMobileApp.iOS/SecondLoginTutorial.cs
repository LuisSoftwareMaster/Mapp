using System;
using System.Diagnostics;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class SecondLoginTutorial : UIViewController
    {
        public SecondLoginTutorial() : base("SecondLoginTutorial", null)
        {
        }

        private bool _checked = false;

        private UIViewController parentController;

        public UIViewController ParentController{

            get{

                return parentController;

            }
            set{

                parentController = value;

            }

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            UIApplication.SharedApplication.StatusBarHidden = true;

            UIImage background = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/loginTutorialBackground.png");

            this.backgroundImage.Image = background;

            this.backgroundImage.ContentMode = UIViewContentMode.ScaleAspectFill;

			this.backgroundImage.ClipsToBounds = true;

			NSLayoutConstraint constraint = NSLayoutConstraint.Create(confirmationButton, NSLayoutAttribute.Top, NSLayoutRelation.Equal, backgroundImage, NSLayoutAttribute.Top, 1, ((System.nfloat)(this.View.Bounds.Height * .1)));

			this.View.AddConstraint(constraint);

            //create check button

            UIButton checkButton = new UIButton();

            checkButton.Frame = new CoreGraphics.CGRect(this.container.Bounds.X, this.container.Bounds.Y, this.container.Bounds.Height*.6, this.container.Bounds.Height*.6);

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

            //center container

            foreach(NSLayoutConstraint aux in container.Constraints){

                if(aux.Description.Contains("width")){

                    aux.Constant = checkButton.Frame.Width + label.Frame.Width + (checkButton.Frame.Width / 2);

                    Debug.WriteLine("WIDTH FOUND");

                }

            
            }

            checkButton.TouchDown += (sender, e) =>
            {

                if(_checked){
                    
                    _checked = false;
				
					checkButton.SetBackgroundImage(null, UIControlState.Normal);

				}else{
                    
                    _checked = true;

                    UIImage checkImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/downloadedcheck.png");

                    checkImage.Scale(new CoreGraphics.CGSize(checkButton.Frame.Width*.8,checkButton.Frame.Height*.8));
				
                    checkButton.SetBackgroundImage(checkImage, UIControlState.Normal);

				}

            }; 

            this.container.AddSubview(label);

			this.confirmationButton.BackgroundColor = PorpoiseColors.Turquoise;

            this.confirmationButton.TouchDown += (sender, e) => {

                if(this.parentController is LoginTutorialFirst){

                    LoginTutorialFirst ltf = (LoginTutorialFirst)this.ParentController;

                    ActivityViewController avc = (ActivityViewController)ltf.ParentController;
                    if (_checked)
                    {
                        avc.FlagTutorial();
                    }
                }

                this.parentController.View.Hidden = true;

                this.DismissViewController(false, null);

                this.ParentController.DismissViewController(false, null);

            };



        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

