
using System;
using System.Drawing;
using CoreGraphics;
using Foundation;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.iOS.Services;
using PorpoiseMobileApp.iOS.Utils;
using PorpoiseMobileApp.ViewModels;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    partial class LoginViewController : MvvmViewController<LoginViewModel>
    {

       CGRect originalPosition;
		CGRect? loginFrame;

		UIGestureRecognizer clickHere;

		UITapGestureRecognizer screenTap;

		public LoginViewController(IntPtr handle)
			: base(handle)
		{
		}




		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

			if (NavigationController != null)
			{
				this.NavigationController.NavigationBar.Hidden = true;
			}
			screenTap = new UITapGestureRecognizer(() =>
			{
				txtEmail.ResignFirstResponder();
				txtPassword.ResignFirstResponder();

			});


			FormContainer.AddGestureRecognizer(screenTap);

			Bindings.Bind(txtEmail).For(x => x.Text).To(vm => vm.Email);
			Bindings.Bind(txtPassword).For(x => x.Text).To(vm => vm.Password);
			Bindings.Bind(btnLogin).To(vm => vm.SignInCommand);
			Bindings.Bind(Waiting).For(x => x.Hidden).To(vm => vm.InFlight).WithConversion(new InverseConverter());
			Bindings.Apply();

			ViewModel.SignInEvent += (sender, e) =>
			{
				if (!e.Successful)
				{
					this.Alert(UIAlertActionStyle.Default, Resources.ProblemOccurred, e.Message, null, btnLogin);
				}
			};


			txtEmail.RightView = MakeInputErrorInfo(() => Resources.InvalidEmail);
			txtEmail.RightView.TintColor = PorpoiseColors.LightErrorRed;
			txtPassword.RightView = MakeInputErrorInfo(() => Resources.InvalidPassword);
			txtPassword.RightView.TintColor = PorpoiseColors.LightErrorRed;

			txtEmail.ReturnKeyType = UIReturnKeyType.Done;
			txtEmail.ShouldReturn = field =>
			{
				txtPassword.BecomeFirstResponder();
				return true;

			};
			txtEmail.EditingDidEnd += (sender, e) =>
			{
				txtEmail.RightViewMode = ViewModel.EmailValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
				//txtEmail.ColoredBorder(ViewModel.EmailValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.Grey.CGColor);
			};
			txtPassword.EnablesReturnKeyAutomatically = true;
			txtPassword.ShouldReturn = field =>
			{
				field.ResignFirstResponder();
				ViewModel.SignInCommand.Execute();
				return true;
			};
			txtPassword.ReturnKeyType = UIReturnKeyType.Done;
			txtPassword.EditingDidEnd += (sender, e) =>
			{
				txtPassword.RightViewMode = ViewModel.PasswordValid ? UITextFieldViewMode.Never : UITextFieldViewMode.UnlessEditing;
				//txtPassword.ColoredBorder(ViewModel.PasswordValid ? PorpoiseColors.Grey.CGColor : PorpoiseColors.Grey.CGColor);
				this.btnLogin.BecomeFirstResponder();
			};

			StyleFormElements();
			//ClickHereTextView.DataDetectorTypes = UIDataDetectorType.Link;
			SetUpRegisterUrl();
			//ClickHereTextView.AddGestureRecognizer(tapGestureRecognizer);

			//ForgotPwText.DataDetectorTypes = UIDataDetectorType.Link;
			SetupForgotPwUrl();

			this.NavigationController.InteractivePopGestureRecognizer.Enabled = false;

		}
		private string sentence = "Not a member? Click <link>here to join!";
		private const string Here = "here";

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
			this.View.BackgroundColor = PorpoiseColors.Turquoise;
            this.logoImage.Image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png");
			//this.FormContainer.BringSubviewToFront(logoImage);
			this.btnLogin.BackgroundColor = PorpoiseColors.Turquoise;
			this.LoginContainer.Layer.CornerRadius = 5;
			this.LoginContainer.Layer.MasksToBounds = true;
			this.btnLogin.Layer.CornerRadius = 5;
			this.btnLogin.Layer.MasksToBounds = true;


			//.Layer.CornerRadius = 5;
            //this.FormContainer.Layer.MasksToBounds = true;

		}
		void SetUpRegisterUrl()
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


			var prettyString = new NSMutableAttributedString("Not a member? Click");
			prettyString.SetAttributes(secondAttributes.Dictionary, new NSRange(0, prettyString.Length));
			//prettyString.SetAttributes(firstAttributes.Dictionary, new NSRange(20,4));
			//NSMutableAttributedString text = new NSMutableAttributedString("Not a member? Click here to join!");



			//string text = "Not a member? Click here to join!";
			var urlAttribute = new UIStringAttributes
			{
				Link = new NSUrl(ViewModel.JoinURL)

			};
			var tapGestureRecognizer = new UITapGestureRecognizer(() =>
			  {
				  ViewModel.navigateRequestEmployeeViewController();
			  });
			/* NSMutableAttributedString mutableAttstring = null;

			 var tempSentence = sentence;
			 if (tempSentence.Contains("<link>"))
			 {
				 mutableAttstring = new NSMutableAttributedString(sentence.Replace("<link>", ""));
				 mutableAttstring.AddAttributes(urlAttribute, new NSRange(sentence.IndexOf('<'), Here.Length));
			 }*/
			//ClickHereTextView.AttributedText = prettyString;
			//ClickHereTextView.AttributedText = mutableAttstring;
			//ClickHereTextView.TextColor = PorpoiseColors.DarkGrey;
			//ClickHereTextView.TextAlignment = UITextAlignment.Center;

			//tint color changes the links and cursor colours.
			//ClickHereTextView.TintColor = UIColor.White.ColorWithAlpha(0.5f);

			var hereString = new NSMutableAttributedString(" here ");
            hereString.SetAttributes(firstAttributes.Dictionary, new NSRange(0, hereString.Length));

            UILabel registrationLabel = new UILabel();



            registrationLabel.Font = UIFont.FromName("Helvetica", 12f);

            ClickHereTextView.ContentMode = UIViewContentMode.Center;



            registrationLabel.AttributedText = prettyString;

            registrationLabel.SizeToFit();

            //registrationLabel.Center = new CGPoint(ClickHereTextView.Bounds.GetMidX(), registrationLabel.Center.Y);

			//here label

			UILabel hereLabel = new UILabel();

			hereLabel.Font = UIFont.FromName("Helvetica", 12f);

			

			hereLabel.TextAlignment = UITextAlignment.Center;

			hereLabel.AttributedText = hereString;

            hereLabel.Frame = new CGRect(registrationLabel.Bounds.Width, registrationLabel.Bounds.Y, 0, registrationLabel.Bounds.Height);

			hereLabel.SizeToFit();

			//hereLabel.Center = new CGPoint(ClickHereTextView.Bounds.GetMidX(), registrationLabel.Center.Y);

			//join label

			var joinString = new NSMutableAttributedString(" to join!");
			joinString.SetAttributes(secondAttributes.Dictionary, new NSRange(0, joinString.Length));


			UILabel joinLabel = new UILabel();

			joinLabel.Font = UIFont.FromName("Helvetica", 12f);



			joinLabel.TextAlignment = UITextAlignment.Center;

			joinLabel.AttributedText = joinString;

            joinLabel.Frame = new CGRect(hereLabel.Frame.X + hereLabel.Frame.Width, registrationLabel.Bounds.Y, 0, registrationLabel.Bounds.Height);

			joinLabel.SizeToFit();

            ClickHereTextView.AddSubview(registrationLabel);

            ClickHereTextView.AddSubview(hereLabel);

            ClickHereTextView.AddSubview(joinLabel);

            ClickHereTextView.BringSubviewToFront(registrationLabel);

            hereLabel.AddGestureRecognizer(tapGestureRecognizer);

            hereLabel.UserInteractionEnabled = true;

			//ClickHereTextView.AddGestureRecognizer(tapGestureRecognizer);

            foreach(NSLayoutConstraint constraint in ClickHereTextView.Constraints){

                if(constraint.Description.Contains("width")){

                    constraint.Constant = hereLabel.Bounds.Width + registrationLabel.Bounds.Width + joinLabel.Bounds.Width;

                }

            }

			//System.Console.WriteLine();
		}

		private string pwSentence = "Forgot password?";
		private const string password = "password";
		void SetupForgotPwUrl()
		{
			var urlAttribute = new UIStringAttributes
			{
				Link = new NSUrl(ViewModel.ForgotPasswordURL)
			};
			var tapGestureRecognizer = new UITapGestureRecognizer(() =>
		   {


			   UIApplication.SharedApplication.OpenUrl(urlAttribute.Link);
		   });
			NSMutableAttributedString mutableAttstring = null;

			var tempSentence = pwSentence;
			if (tempSentence.Contains("<link>"))
			{
				mutableAttstring = new NSMutableAttributedString(pwSentence.Replace("<link>", ""));
				mutableAttstring.AddAttributes(urlAttribute, new NSRange(pwSentence.IndexOf('<'), password.Length));
			}

			ForgotPwText.Text = pwSentence;
			ForgotPwText.TextColor = PorpoiseColors.Turquoise;
			ForgotPwText.TextAlignment = UITextAlignment.Center;
			ForgotPwText.TintColor = UIColor.White.ColorWithAlpha(0.5f);
			ForgotPwText.AddGestureRecognizer(tapGestureRecognizer);
		}




		void StyleFormElements()
		{
			((PorpoiseEditText)txtEmail).Bordered = true;
			//txtEmail.Layer.BorderWidth = 5;
			txtEmail.Layer.CornerRadius = 5;
			txtEmail.Layer.BorderWidth = 0.5f;
            txtEmail.Layer.MasksToBounds = true;
			txtEmail.Layer.BorderColor = UIColor.LightGray.CGColor;

			//txtEmail.BackgroundColor = UIColor.Clear;
			//txtEmail.TextColor = UIColor.White;
			//txtEmail.AttributedPlaceholder = new NSAttributedString(Resources.Email, null, UIColor.White);
			txtEmail.ReturnKeyType = UIReturnKeyType.Continue;
			((PorpoiseEditText)txtPassword).Bordered = true;
			//txtPassword.BackgroundColor = UIColor.Clear;
			//txtPassword.TextColor = UIColor.White;
			//txtPassword.AttributedPlaceholder = new NSAttributedString(Resources.Password, null, UIColor.White);
			txtPassword.SecureTextEntry = true;
			txtPassword.Layer.CornerRadius = 5;
			txtPassword.Layer.BorderWidth = 0.5f;
            txtPassword.Layer.MasksToBounds = true;
			txtPassword.Layer.BorderColor = UIColor.LightGray.CGColor;
			txtPassword.ReturnKeyType = UIReturnKeyType.Done;

			//email left image
            this.txtEmail.LeftViewMode = UITextFieldViewMode.Always;

			UIImageView fullNameLeftImage = new UIImageView();
            UIImage image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/envelope.png");




            UIView fullnameLeftPadding = new UIView();



			fullnameLeftPadding.Frame = new CGRect(0, 0, txtEmail.Frame.Height,  txtEmail.Frame.Height );

//fullnameLeftPadding.ContentMode = UIViewContentMode.;

			fullNameLeftImage.Image = image;
			fullNameLeftImage.Frame = new CGRect(fullnameLeftPadding.Bounds.Width/2-((txtEmail.Frame.Height / 3)/2), fullnameLeftPadding.Bounds.Height/2-((txtEmail.Frame.Height / 3)/2), txtEmail.Frame.Height/3, txtEmail.Frame.Height / 3);

			fullnameLeftPadding.Bounds = CGRect.Inflate(fullnameLeftPadding.Frame, 0,0);

			//fullnameLeftPadding.BackgroundColor = UIColor.White;

			//fullnameLeftPadding.ContentMode = UIViewContentMode.Center;

			fullNameLeftImage.BackgroundColor = UIColor.White;
            fullnameLeftPadding.AddSubview(fullNameLeftImage);

		   //fullnamee.ContentMode = UIViewContentMode.Center;

			this.txtEmail.LeftView = fullnameLeftPadding;



			this.txtEmail.LeftView.BackgroundColor = UIColor.White;



			//password left image


			this.txtPassword.LeftViewMode = UITextFieldViewMode.Always;

			UIImageView passwordLeftImage = new UIImageView();
UIImage passwordImage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/key.png");




UIView passwordLeftPadding = new UIView();



passwordLeftPadding.Frame = new CGRect(0, 0, txtPassword.Frame.Height, txtPassword.Frame.Height);

//fullnameLeftPadding.ContentMode = UIViewContentMode.;

passwordLeftImage.Image = passwordImage;
			passwordLeftImage.Frame = new CGRect(passwordLeftPadding.Bounds.Width / 2 - ((txtEmail.Frame.Height / 3) / 2), passwordLeftPadding.Bounds.Height / 2 - ((txtPassword.Frame.Height / 3) / 2), txtPassword.Frame.Height / 3, txtPassword.Frame.Height / 3);

passwordLeftPadding.Bounds = CGRect.Inflate(passwordLeftPadding.Frame, 0, 0);

			//fullnameLeftPadding.BackgroundColor = UIColor.White;

			//fullnameLeftPadding.ContentMode = UIViewContentMode.Center;

passwordLeftImage.BackgroundColor = UIColor.White;

passwordLeftPadding.AddSubview(passwordLeftImage);

		   //fullnamee.ContentMode = UIViewContentMode.Center;

			this.txtPassword.LeftView = passwordLeftPadding;



            this.txtPassword.LeftView.BackgroundColor = UIColor.White;

		}

		public override UIStatusBarStyle PreferredStatusBarStyle()
		{
			return UIStatusBarStyle.LightContent;
		}


		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
			if (loginFrame.HasValue)
			{
				FormContainer.Frame = loginFrame.Value;
			}
			else if (originalPosition != CGRect.Empty)
			{
				FormContainer.Frame = originalPosition;
			}
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			SetupKeyboardObserver();
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
			KeyboardManager.KeyboardDown -= HandleKeyboardDown;
			KeyboardManager.KeyboardUp -= HandleKeyboardUp;

		}

		void SetupKeyboardObserver()
		{
			KeyboardManager.KeyboardUp += HandleKeyboardUp;
			KeyboardManager.KeyboardDown += HandleKeyboardDown;
		}

		void HandleKeyboardUp(SizeF keyboardSize)
		{
			if ((View.Bounds.Height - keyboardSize.Height) < (FormContainer.Frame.Top + FormContainer.Frame.Height))
			{
				var available = (View.Bounds.Height - keyboardSize.Height);
				var y = (available - FormContainer.Frame.Height) / 2;
				if (y < 16)
				{
					y = 16;
				}
				if (originalPosition == CGRect.Empty)
				{
					originalPosition = FormContainer.Frame;
				}
				loginFrame = new CGRect(FormContainer.Frame.X, y, FormContainer.Frame.Width, FormContainer.Frame.Height);
				FormContainer.Frame = loginFrame.Value;
			}
		}

		public override bool PrefersStatusBarHidden()
		{
			return false;
		}

		void HandleKeyboardDown()
		{
			if (originalPosition != CGRect.Empty)
			{
				FormContainer.Frame = originalPosition;
			}
			loginFrame = null;
		}

    }

}