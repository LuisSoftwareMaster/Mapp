using Foundation;
using System;
using UIKit;
using CoreGraphics;
using System.Diagnostics;

namespace PorpoiseMobileApp.iOS
{
    public partial class InviteCoworkerViewController : MvvmViewController<ViewModels.InviteCoworkerViewModel>
    {
        public InviteCoworkerViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			UIApplication.SharedApplication.StatusBarHidden = false;

			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;
			
            this.NavigationBarSetUp();

            this.styleElements();

            this.NavigationController.NavigationBar.Hidden = false;
        }


        private void styleElements(){

            string text = Resource.InviteCorworkerMessage;

            this.inviteTitle.Text = text;

            this.titleContainer.Layer.BorderWidth = 0.5f;

            this.titleContainer.Layer.BorderColor = PorpoiseColors.Grey.CGColor;

            this.namecontainer.Layer.BorderWidth = 0.5f;

            this.namecontainer.Layer.BorderColor = PorpoiseColors.Grey.CGColor;

			this.emailcontainer.Layer.BorderWidth = 0.5f;

            this.emailcontainer.Layer.BorderColor = PorpoiseColors.Grey.CGColor;

           

            //this.View.BringSubviewToFront(maincontainer);

            var nameContainerTap = new UITapGestureRecognizer(()=>{

                name.BecomeFirstResponder();

                email.ResignFirstResponder();

            });

			var emailContainerTap = new UITapGestureRecognizer(() =>
			{

				email.BecomeFirstResponder();

				name.ResignFirstResponder();

			});

            namecontainer.AddGestureRecognizer(nameContainerTap);

            emailcontainer.AddGestureRecognizer(emailContainerTap);

            var tap = new UITapGestureRecognizer(()=>{

                email.ResignFirstResponder();
                name.ResignFirstResponder();

            });

            this.View.AddGestureRecognizer(tap);

            name.ReturnKeyType = UIReturnKeyType.Done;

			name.ShouldReturn = field =>
			{
				field.ResignFirstResponder();
				
				return true;
			};

			email.ReturnKeyType = UIReturnKeyType.Done;

			email.ShouldReturn = field =>
			{
				field.ResignFirstResponder();

				return true;
			};


            name.EditingDidEnd += (sender, e) => {

                if(string.IsNullOrEmpty(name.Text)){

                    this.throwError("Please enter a name");

                }

            };

            email.EditingDidEnd += (sender, e) => {

				if (!ViewModel.EmailValid)
				{

					Debug.WriteLine("INVALID EMAIL");

                    this.throwError("Please enter a valid email");

				}
				else
				{
                    
                    this.removeErrorMessage();

				}

            };

           /* this.submitButton.TouchDown += (sender, e) => {

				if (string.IsNullOrEmpty(name.Text))
				{

					this.throwError("Please enter a name");

				}
                else if(!ViewModel.EmailValid){

					this.throwError("Please enter a valid email");


				}

                else{

                    ViewModel.ConfirmCommand.Execute(null);

                }

            };*/
         

            this.addButton.BackgroundColor = PorpoiseColors.Turquoise;

            this.submitButton.BackgroundColor = PorpoiseColors.Turquoise;

            this.errormessagelabel.TextColor = PorpoiseColors.LightErrorRed;

            this.maincontainer.BringSubviewToFront(namecontainer);

            this.emailcontainer.BringSubviewToFront(namecontainer);

            this.maincontainer.UserInteractionEnabled = true;

            this.name.UserInteractionEnabled = true;

            this.View.BringSubviewToFront(namecontainer);

            this.View.BringSubviewToFront(emailcontainer);
        }


        private void throwError(string error){

            //this.View.BringSubviewToFront(maincontainer);

            errormessagelabel.Hidden = false;

            errormessagelabel.Text = error;

			this.maincontainer.Layer.BorderWidth = 2;

			this.maincontainer.Layer.BorderColor = PorpoiseColors.ErrorBoldRed.CGColor;

        }

        private void removeErrorMessage(){

			errormessagelabel.Hidden = true;

			errormessagelabel.Text = "";

			this.maincontainer.Layer.BorderWidth = 0;

        }

		void NavigationBarSetUp()
		{
			UIButton button = new UIButton();
			if (this.NavigationController != null)
			{
				//TODO: figure out how to make the status bar opaque.
				this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Default;
				//this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
				this.NavigationController.NavigationBar.ShadowImage = new UIImage();
				this.NavigationController.NavigationBar.BackgroundColor = UIColor.White;
				//this.NavigationController.NavigationBar.BackgroundColor = UIColor.White;
				this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
			}

			//this.NavigationController.NavigationBar.BackgroundColor = UIColor.Black;

			nfloat scale = UIScreen.MainScreen.Scale;

			NavigationController.NavigationBar.Translucent = false;
			float imageSize = 20f;

			float gap = 5f;

			float borderSize = 0f;

			float textHeight = 1f;

			float buttonWidth = 60;

			float buttonHeight = borderSize * 2 + gap * 3 + imageSize + textHeight;

			float imageOrigin = borderSize + gap;

			float textTop = imageOrigin + imageSize + gap;

			float textBottom = borderSize + gap;

			float imageBottom = textBottom + textHeight + gap;

			UIBarButtonItem[] rightButtons = new UIBarButtonItem[2];
			UIImage next = null;


			UIImage post = null;

			UIButton postButton = UIButton.FromType(UIButtonType.Custom);




			button = UIButton.FromType(UIButtonType.Custom);


			if (scale >= 2)
			{
				next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+uploaded+from+iOS-2.jpg");

			}
			else
			{

				next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+uploaded+from+iOS-2.jpg");

			}


			button.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(next, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);

			button.SetBackgroundImage(next, UIControlState.Normal);

			
			if (scale >= 2)
			{

				post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next%402x.png");



			}
			else
			{

				post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Next.png");

			}

			postButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(post, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);


			postButton.SetBackgroundImage(post, UIControlState.Normal);

            Bindings.Bind(button).To(vm => vm.CancelCommand).Apply();

			UIBarButtonItem barButtonRightOne = new UIBarButtonItem(button);

			

			NSLayoutConstraint topConstraint = NSLayoutConstraint.Create(postButton, NSLayoutAttribute.Top, NSLayoutRelation.Equal, button, NSLayoutAttribute.Top, 1, 0);

			//this.NavigationController.NavigationBar.AddConstraint(topConstraint);
			//Add Constraints


			//NSLayoutConstraint.ActivateConstraints(constraints);
			//rightButton2.AddConstraint(alingY);


			this.NavigationController.NavigationBar.ContentMode = UIViewContentMode.Center;
            /*UIButton rigthButton = new UIButton();

            rigthButton.Frame = new CGRect(0, 0, buttonWidth, buttonHeight);

            rigthButton.Center = this.View.Center;

            //Image

            UIImage logout = new UIImage("logout.png");

            rigthButton.SetImage(logout, UIControlState.Normal);

            rigthButton.ImageEdgeInsets = new UIEdgeInsets(0, 15, 0, 0);

            rigthButton.SetTitle(Resource.Logout, UIControlState.Normal);

            rigthButton.TitleEdgeInsets = new UIEdgeInsets(textTop, -logout.Size.Width, textBottom, 0.0f);

            rigthButton.TitleLabel.Font = UIFont.FromName("Ubuntu-Light", 15f);

            rigthButton.TintColor = UIColor.Black;

            rigthButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            rigthButton.SetTitleShadowColor(UIColor.Blue, UIControlState.Normal);

            rigthButton.TouchUpInside += delegate
            {
                var user = NSUserDefaults.StandardUserDefaults;

                user.SetBool(true, "logged");

                //ViewModel.Logout();

            };*/

            NavigationItem.RightBarButtonItem = barButtonRightOne;



			UIImage leftImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/por-logo.png");

			UIButton leftButton = UIButton.FromType(UIButtonType.Custom);

			leftButton.UserInteractionEnabled = false;

			leftButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(leftImage, (nfloat)(NavigationController.NavigationBar.Bounds.Height * 0.6)), NavigationController.NavigationBar.Bounds.Height * 0.6);

			leftButton.SetImage(leftImage, UIControlState.Normal);

			UIBarButtonItem leftButtonBar = new UIBarButtonItem(leftButton);
			//leftButton.TintColor = UIColor.Black;
			NavigationItem.SetLeftBarButtonItem(leftButtonBar, true);
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Bindings.Bind(email).To(vm => vm.Email);

            Bindings.Bind(name).To(vm => vm.Name);

            Bindings.Bind(submitButton).To(vm => vm.ConfirmCommand);

            Bindings.Bind(addButton).To(vm => vm.AddEmployee);

            Bindings.Apply();

            ViewModel.ForPropertyChange(x => x.ThrowError, y =>
			{
                if(y){

					if (string.IsNullOrEmpty(name.Text))
					{

						this.throwError("Please enter a name");

					}
					else if (!ViewModel.EmailValid)
					{

						this.throwError("Please enter a valid email");


					}
                    else{

                        this.throwError(ViewModel.ApiMessage);

                    }


                }
			});


        }

    }
}