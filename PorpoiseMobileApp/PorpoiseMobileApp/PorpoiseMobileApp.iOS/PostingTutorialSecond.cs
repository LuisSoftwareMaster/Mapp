using System;
using System.Diagnostics;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PostingTutorialSecond : UIViewController
    {
        public PostingTutorialSecond() : base("PostingTutorialSecond", null)
        {
        }

        private UIViewController parentController;

        private bool tutoFour = false;

        private bool check = false;

        public bool TutoFour{

            get{

                return tutoFour;

            }
            set{

                tutoFour = value;

            }

        }

        public UIViewController ParentController{

            get{

                return this.parentController;

            }
            set{

                this.parentController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			UIApplication.SharedApplication.StatusBarHidden = true;

			this.backgroundImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/posting+tuto+2+and+4+-+BG.png");

            this.backgroundImage.ContentMode = UIViewContentMode.ScaleAspectFill;

            this.backgroundImage.ClipsToBounds = true;

           
            gaugeButton.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Gauge+Button.png");

            NSLayoutConstraint constraint = NSLayoutConstraint.Create(gaugeButton, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.backgroundImage, NSLayoutAttribute.Top, 1, ((System.nfloat)(this.View.Bounds.Height * 0.32)));

            this.View.AddConstraint(constraint);

            this.nextButton.BackgroundColor = PorpoiseColors.Turquoise;

            var tap = new UITapGestureRecognizer(()=>{

				PostingTutorialThird ptt = new PostingTutorialThird();

				ptt.ParentController = this;

				this.PresentViewController(ptt, false, null);

            });

            this.gaugeButton.UserInteractionEnabled = true;

            this.gaugeButton.AddGestureRecognizer(tap);

			this.nextButton.TouchDown += (sender, e) =>
				  {
                      if (!tutoFour)
                      {

                          PostingTutorialThird ptt = new PostingTutorialThird();

                          ptt.ParentController = this;

                          this.PresentViewController(ptt, false, null);

                }else{

                    if(this.check){

                              ((AddCoworkerViewController)((PostingTutorialFirst)this.ParentController).ParentController.ParentViewController).FlagTutorial();

                    }

						  ((PostingTutorialFirst)this.ParentController).ParentController.DismissViewController(false, null);

						  this.parentController.View.Hidden = true;

						  this.ParentController.DismissViewController(false, null);

						  this.DismissViewController(false, null);


					  }

				  };


            var skipTapped = new UITapGestureRecognizer(() => {

                Debug.WriteLine("SKIPPING");

                ((PostingTutorialFirst)this.ParentController).ParentController.DismissViewController(false, null);

                    this.parentController.View.Hidden = true;

                    this.ParentController.DismissViewController(false, null);

                    this.DismissViewController(false, null);
                
            
            });

            this.skipLabel.UserInteractionEnabled = true;

            this.skipLabel.AddGestureRecognizer(skipTapped);



            this.View.BringSubviewToFront(skipLabel);

            if(tutoFour){

                this.skipLabel.Hidden = true;

                this.check = false;

                this.nextButton.SetTitle("Got it", UIControlState.Normal);

				//create check button

				UIButton checkButton = new UIButton();

				checkButton.Frame = new CoreGraphics.CGRect(this.container.Bounds.X, this.container.Bounds.Y, this.container.Bounds.Height * .6, this.container.Bounds.Height * .6);

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

                this.container.AddSubview(label);

				//center container

				foreach (NSLayoutConstraint aux in container.Constraints)
				{

					if (aux.Description.Contains("width"))
					{

						aux.Constant = checkButton.Frame.Width + label.Frame.Width + (checkButton.Frame.Width / 2);

						//Debug.WriteLine("WIDTH FOUND");

					}


				}

				checkButton.TouchDown += (sender, e) =>
		   {

			   if (check)
			   {

				   check = false;

				   checkButton.SetBackgroundImage(null, UIControlState.Normal);

			   }
			   else
			   {

				   check = true;

				   UIImage checkImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/downloadedcheck.png");

				   checkImage.Scale(new CoreGraphics.CGSize(checkButton.Frame.Width * .8, checkButton.Frame.Height * .8));

				   checkButton.SetBackgroundImage(checkImage, UIControlState.Normal);

			   }

		   };

			

            }
            else{

                this.nextButton.SetTitle("Next", UIControlState.Normal);

				
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
    }
}

