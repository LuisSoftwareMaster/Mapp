using Foundation;
using System;
using UIKit;
using CoreGraphics;
using PorpoiseMobileApp.iOS.Services;
using MessageUI;

namespace PorpoiseMobileApp.iOS
{
    public partial class RequestAccountViewController : MvvmViewController<ViewModels.RequestAccountViewModel>
	{
		public RequestAccountViewController(IntPtr handle) : base(handle)
		{
		}
      
		public UIImage check;

		public bool ischeck = false;

        public UIButton Checkbox{

            get{

                return this.checkbox;

            }



        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Bindings.Bind(firstname).For(x => x.Text).To(vm => vm.Fullname);

			Bindings.Bind(company).For(x => x.Text).To(vm => vm.Company);

			Bindings.Bind(email).For(x => x.Text).To(vm => vm.WorkEmail);

			Bindings.Bind(lastname).For(x => x.Text).To(vm => vm.Lastname);

			Bindings.Bind(submit).To(vm => vm.RegisterEmployeeCommand);

			Bindings.Bind(back).To(vm => vm.GoBack);
            Bindings.Bind(topImage).For(x => x.Image).To(x => x.TopImage).WithConversion(new UriToImageConverter());

			Bindings.Apply();

			UIApplication.CheckForEventAndDelegateMismatches = false;

            this.firstname.WeakDelegate = this;

            //this.submitButtonEvent();
           
			email.EditingDidEnd += (sender, e) =>
			{
				email.RightViewMode = ViewModel.EmailValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
                //email.ColoredBorder(ViewModel.EmailValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.LightErrorRed.CGColor);
                if(!ViewModel.EmailValid){

                    email.Layer.BorderColor  = PorpoiseColors.LightErrorRed.CGColor;

                    email.Layer.BorderWidth = 1f;

                    email.Layer.CornerRadius = 5f;

                }
                else{

                    email.Layer.BorderColor = PorpoiseColors.LightGrey.CGColor;

					email.Layer.BorderWidth = 1f;

					email.Layer.CornerRadius = 5f;


                }


				//this.btnLogin.BecomeFirstResponder();
			};

			company.EditingDidEnd += (sender, e) =>
			{
				//email.RightViewMode = ViewModel.EmailValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
				//email.ColoredBorder(ViewModel.EmailValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.LightErrorRed.CGColor);
                if (!ViewModel.ValidField(company.Text))
				{

					company.Layer.BorderColor = PorpoiseColors.LightErrorRed.CGColor;

					company.Layer.BorderWidth = 1f;

					company.Layer.CornerRadius = 5f;

				}
				else
				{

					company.Layer.BorderColor = PorpoiseColors.LightGrey.CGColor;

					company.Layer.BorderWidth = 1f;

					company.Layer.CornerRadius = 5f;


				}


				//this.btnLogin.BecomeFirstResponder();
			};

            lastname.EditingDidEnd += (sender, e) =>
			{
				//email.RightViewMode = ViewModel.EmailValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
				//email.ColoredBorder(ViewModel.EmailValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.LightErrorRed.CGColor);
				if (!ViewModel.ValidField(lastname.Text))
				{

					lastname.Layer.BorderColor = PorpoiseColors.LightErrorRed.CGColor;

					lastname.Layer.BorderWidth = 1f;

					lastname.Layer.CornerRadius = 5f;

				}
				else
				{

					lastname.Layer.BorderColor = PorpoiseColors.LightGrey.CGColor;

					lastname.Layer.BorderWidth = 1f;

					lastname.Layer.CornerRadius = 5f;


				}


				//this.btnLogin.BecomeFirstResponder();
			};

            this.firstname.EditingDidEnd += (sender, e) =>
		  {
				//email.RightViewMode = ViewModel.EmailValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
				//email.ColoredBorder(ViewModel.EmailValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.LightErrorRed.CGColor);
				if (!ViewModel.ValidField(firstname.Text))
			  {

				  firstname.Layer.BorderColor = PorpoiseColors.LightErrorRed.CGColor;

				  firstname.Layer.BorderWidth = 1f;

				  firstname.Layer.CornerRadius = 5f;

			  }
			  else
			  {

				  firstname.Layer.BorderColor = PorpoiseColors.LightGrey.CGColor;

				  firstname.Layer.BorderWidth = 1f;

				  firstname.Layer.CornerRadius = 5f;


			  }


				//this.btnLogin.BecomeFirstResponder();
			};


			UITapGestureRecognizer screenTap = new UITapGestureRecognizer(() =>
			{
				company.ResignFirstResponder();
				email.ResignFirstResponder();
				firstname.ResignFirstResponder();
				lastname.ResignFirstResponder();

			});

			this.View.AddGestureRecognizer(screenTap);
            this.styleComponents();
			contentView.AddGestureRecognizer(screenTap);
		}



        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
		
        }

        private void submitButtonEvent(){

            this.submit.TouchDown += (sender, args) => {


				if (!string.IsNullOrEmpty(firstname.Text) && !string.IsNullOrEmpty(company.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(company.Text) && !string.IsNullOrEmpty(this.lastname.Text) && ischeck)
                {
                    this.ViewModel.presentConfirmationCode();
                }

            };

        }

        public override void UpdateViewConstraints()
        {
            base.UpdateViewConstraints();
            //NSLayoutConstraint leftConstraint = NSLayoutConstraint.Create(fullNameLeftImage, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal, fullnamee, NSLayoutAttribute.CenterY, 1, 0);

			//this.View.AddConstraint(leftConstraint)
        }

		void SetUpEmail()
		{

			var firstAttributes = new UIStringAttributes
			{
				ForegroundColor = PorpoiseColors.Turquoise
				//BackgroundColor = UIColor.Yellow,
				//Font = UIFont.FromName("Courier", 18f)
			};

			var secondAttributes = new UIStringAttributes
			{
				ForegroundColor = PorpoiseColors.DarkGrey
				//BackgroundColor = UIColor.Yellow,
				//Font = UIFont.FromName("Courier", 1
			};


			var prettyString = new NSMutableAttributedString("Need help? sos@getporpoise.com");
			prettyString.SetAttributes(secondAttributes.Dictionary, new NSRange(0, prettyString.Length));
			prettyString.SetAttributes(firstAttributes.Dictionary, new NSRange(11, 19));
			NSMutableAttributedString text = new NSMutableAttributedString("Not a member? Click here to join!");



			/* NSMutableAttributedString mutableAttstring = null;

			 var tempSentence = sentence;
			 if (tempSentence.Contains("<link>"))
			 {
				 mutableAttstring = new NSMutableAttributedString(sentence.Replace("<link>", ""));
				 mutableAttstring.AddAttributes(urlAttribute, new NSRange(sentence.IndexOf('<'), Here.Length));
			 }*/
			mail.AttributedText = prettyString;
			//ClickHereTextView.AttributedText = mutableAttstring;
			//ClickHereTextView.TextColor = PorpoiseColors.DarkGrey;
			mail.TextAlignment = UITextAlignment.Center;

			//tint color changes the links and cursor colours.
			//ClickHereTextView.TintColor = UIColor.White.ColorWithAlpha(0.5f);

			//ClickHereTextView.AddGestureRecognizer(tapGestureRecognizer);

			//System.Console.WriteLine

			var tapGestureRecognizer = new UITapGestureRecognizer(() =>
			  {
				  this.sendEmail();
			  });

			this.mail.AddGestureRecognizer(tapGestureRecognizer);

						}


		private void sendEmail() { 
			
MFMailComposeViewController mailController;

			if (MFMailComposeViewController.CanSendMail) {
  				mailController = new MFMailComposeViewController();

mailController.SetToRecipients (new string[]{"sos@getporpoise.com"});
mailController.SetSubject ("Mayday! Account Creation help required");


				mailController.Finished += ( object s, MFComposeResultEventArgs args) => {
  				Console.WriteLine (args.Result.ToString ());
  				args.Controller.DismissViewController (true, null);
				};


				this.PresentViewController (mailController, true, null);
			}
			
			}
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			this.SetUpEmail();
            company.ReturnKeyType = UIReturnKeyType.Done;
            email.ReturnKeyType = UIReturnKeyType.Done;
            firstname.ReturnKeyType = UIReturnKeyType.Done;
			lastname.ReturnKeyType = UIReturnKeyType.Done;
			
			this.View.BackgroundColor = PorpoiseColors.Turquoise;
			this.contentView.Layer.CornerRadius = 10;
			UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
			this.NavigationController.NavigationBar.Hidden = true;
          		this.firstname.Layer.CornerRadius = 0;
			//UIImageView fullNameLeftView = new UIImageView();
			//fullNameLeftView.Image = new UIImage("usericon.png");
			//fullNameLeftView.SizeToFit();
			//this.fullnamee.LeftView = fullNameLeftView;
			this.submit.BackgroundColor = PorpoiseColors.Turquoise;
			this.back.BackgroundColor = PorpoiseColors.lightGrey;
            firstname.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};
            company.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};
            email.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};

			lastname.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};
            this.styleComponents();
		}



        private void styleComponents(){
			//FULLNAME IMAGE PATH https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/avatar+(1).png

          		this.firstname.LeftViewMode = UITextFieldViewMode.Always;
			this.lastname.LeftViewMode = UITextFieldViewMode.Always;
            UIImageView fullNameLeftImage = new UIImageView();
            UIImage image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/avatar+(1).png");
           

            fullNameLeftImage.Image = image;
            fullNameLeftImage.Frame = new CGRect(0, 0, firstname.Frame.Height/2, firstname.Frame.Height / 2);

            UIView fullnameLeftPadding = new UIView();



            fullnameLeftPadding.Frame = new CGRect(0, 0, fullNameLeftImage.Bounds.Width/2, fullNameLeftImage.Bounds.Height);

            //fullnameLeftPadding.ContentMode = UIViewContentMode.;

            fullnameLeftPadding.Bounds = CGRect.Inflate(fullnameLeftPadding.Frame, 5.0f,0);

            fullnameLeftPadding.AddSubview(fullNameLeftImage);

           //fullnamee.ContentMode = UIViewContentMode.Center;

            this.firstname.LeftView = fullnameLeftPadding;

			//lastnameicon

			UIImageView lastNameLeftImage = new UIImageView();
			UIImage lastnameimage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/avatar+(1).png");


			lastNameLeftImage.Image = lastnameimage;
            lastNameLeftImage.Frame = new CGRect(0, 0, lastname.Frame.Height/2, lastname.Frame.Height / 2);

			UIView lastnameLeftPadding = new UIView();
			lastnameLeftPadding.Frame = new CGRect(0, 0, lastNameLeftImage.Bounds.Width/2, lastNameLeftImage.Bounds.Height);

			lastnameLeftPadding.Bounds = CGRect.Inflate(lastnameLeftPadding.Frame, 5.0f,0);

			lastnameLeftPadding.AddSubview(lastNameLeftImage);

		   //fullnamee.ContentMode = UIViewContentMode.Center;

			this.lastname.LeftView = lastnameLeftPadding;

			//COMPANY ICON
            this.company.LeftViewMode = UITextFieldViewMode.Always;
            UIImage companyImage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/building+(1).png");
			UIImageView companyLeftImage = new UIImageView();
            companyLeftImage.Image = companyImage;
            companyLeftImage.Frame = new CGRect(0, 0, company.Frame.Height / 2, company.Frame.Height / 2);
            UIView companyPaddingView = new UIView();
            companyPaddingView.Frame = new CGRect(0, 0, companyLeftImage.Bounds.Width / 2, companyLeftImage.Bounds.Height);
			companyPaddingView.Bounds = CGRect.Inflate(companyPaddingView.Frame, 5.0f, 0);

			companyPaddingView.AddSubview(companyLeftImage);
           // companyLeftImage.Image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/building+(1).png");
            this.company.LeftView = companyPaddingView;



			//Emvelope Icon https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/envelope.png
            this.email.LeftViewMode = UITextFieldViewMode.Always;
            UIImage emailImage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/envelope.png");
			UIImageView emailLeftImage = new UIImageView();
			emailLeftImage.Frame = new CGRect(0, 0, email.Frame.Height / 2, email.Frame.Height / 2);
            emailLeftImage.Image = emailImage;
			//emailLeftImage.Image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/envelope.png");
			UIView envelopeView = new UIView();
			envelopeView.Frame = new CGRect(0, 0, emailLeftImage.Bounds.Width / 2, emailLeftImage.Bounds.Height);
			envelopeView.Bounds = CGRect.Inflate(envelopeView.Frame, 5.0f, 0);

			envelopeView.AddSubview(emailLeftImage);

            //terms.TextColor = PorpoiseColors.Turquoise;



			var tapGestureRecognizerTerms = new UITapGestureRecognizer(() =>
			  {
                System.Console.WriteLine("PRESENTING");

                  TermConditions vc = new TermConditions();
                  vc.ParentViewController = this;

                this.PresentViewController(vc, false, null);
			  });



           //this.terms.AddGestureRecognizer();


			var firstAttributes = new UIStringAttributes
			{
				ForegroundColor = PorpoiseColors.Turquoise
				//BackgroundColor = UIColor.Yellow,
				//Font = UIFont.FromName("Courier", 18f)
			};

			var secondAttributes = new UIStringAttributes
			{
				ForegroundColor = PorpoiseColors.DarkGrey
				//BackgroundColor = UIColor.Yellow,
				//Font = UIFont.FromName("Courier", 1
			};


			var prettyString = new NSMutableAttributedString("I agree to the");
			prettyString.SetAttributes(secondAttributes.Dictionary, new NSRange(0, prettyString.Length));
            //prettyString.SetAttributes(firstAttributes.Dictionary, new NSRange(14, 19));

            //this.terms.AttributedText = prettyString;
            this.terms.ContentMode = UIViewContentMode.Center;
			UILabel grayLabel = new UILabel();

			grayLabel.AttributedText = prettyString;

			grayLabel.Font = UIFont.FromName("Helvetica", 12f);

            grayLabel.Frame = new CGRect(this.terms.Bounds.X, this.terms.Bounds.Y, 0f, this.terms.Bounds.Height);

            grayLabel.SizeToFit();

            NSLayoutConstraint grayConstraint = NSLayoutConstraint.Create(grayLabel, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal, terms, NSLayoutAttribute.CenterY, 1, 0);


                                                                          
            UILabel turquiseLabel = new UILabel();

            var turquiseString = new NSMutableAttributedString(" terms & conditions");

            turquiseString.SetAttributes(firstAttributes.Dictionary, new NSRange(0, turquiseString.Length));

            turquiseLabel.AttributedText = turquiseString;

            turquiseLabel.Frame = new CGRect(grayLabel.Bounds.Width, this.terms.Bounds.Y, 0f, this.terms.Bounds.Height);

            turquiseLabel.Font = UIFont.FromName("Helvetica", 12f);

            turquiseLabel.SizeToFit();

            turquiseLabel.Center = new CGPoint(turquiseLabel.Center.X, checkbox.Bounds.GetMidY());

            turquiseLabel.AddGestureRecognizer(tapGestureRecognizerTerms);

            turquiseLabel.UserInteractionEnabled = true;
            terms.UserInteractionEnabled = true;

			this.terms.AddSubview(grayLabel);

            this.terms.AddSubview(turquiseLabel);

            terms.AddConstraint(grayConstraint);

			this.terms.BringSubviewToFront(grayLabel);

            this.terms.BringSubviewToFront(turquiseLabel);

			this.email.LeftView = envelopeView;

            this.check = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/checked.png");

          		
			this.checkbox.Layer.BorderWidth = 1;

			this.checkbox.Layer.BorderColor = UIColor.LightGray.CGColor;


            var tapGestureRecognizer = new UITapGestureRecognizer(() =>
			  {

				if (!ischeck)
				{

					this.checkbox.SetBackgroundImage(check, UIControlState.Normal);

					this.ischeck = true;

                    this.ViewModel.Checked = this.ischeck;

				}
				else { 


				this.checkbox.SetBackgroundImage(null, UIControlState.Normal);

					this.ischeck = false;

                    this.ViewModel.Checked = this.ischeck;
				}
			  });


			this.checkbox.AddGestureRecognizer(tapGestureRecognizer);


		}
	}
}