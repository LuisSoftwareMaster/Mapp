using System;
using CoreGraphics;
using Foundation;
using PorpoiseMobileApp.iOS.Services;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PasswordConfirmationViewController : MvvmViewController<ViewModels.PasswordConfirmationViewModel>
    {
       

		public PasswordConfirmationViewController(IntPtr handle)
            : base(handle)
        {
		}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.styleComponents();
        }

        private void styleComponents(){

            this.View.BackgroundColor = PorpoiseColors.Turquoise;

            this.nextButton.BackgroundColor = PorpoiseColors.Turquoise;

            logo.Image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png");

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

			this.help.AttributedText = prettyString;

			help.TextAlignment = UITextAlignment.Center;

			//password text field

			this.password.LeftViewMode = UITextFieldViewMode.Always;

			UIImageView passwordLeftImage = new UIImageView();
			UIImage passwordimage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/key.png");




			UIView passwordLeftPadding = new UIView();



            passwordLeftPadding.Frame = new CGRect(0, 0, password.Frame.Height, password.Frame.Height);



			passwordLeftImage.Image = passwordimage;
			passwordLeftImage.Frame = new CGRect(passwordLeftPadding.Bounds.Width / 2 - ((password.Frame.Height / 2) / 2), passwordLeftPadding.Bounds.Height / 2 - ((password.Frame.Height / 2) / 2), password.Frame.Height / 2, password.Frame.Height / 2);

			passwordLeftPadding.Bounds = CGRect.Inflate(passwordLeftPadding.Frame, 0, 0);



			passwordLeftImage.BackgroundColor = UIColor.White;
			passwordLeftPadding.AddSubview(passwordLeftImage);



            this.password.LeftView = passwordLeftPadding;



			this.password.LeftView.BackgroundColor = UIColor.White;

			password.Layer.BorderWidth = 1;
			password.Layer.BorderColor = PorpoiseColors.lightGrey.CGColor;
			password.Layer.CornerRadius = 5;

			password.ReturnKeyType = UIReturnKeyType.Done;
			password.EnablesReturnKeyAutomatically = true;
			password.ShouldReturn = field =>
			{
				field.ResignFirstResponder();

				return true;
			};

			//password confirmation text view

            this.passwordConfirmation.LeftViewMode = UITextFieldViewMode.Always;

			UIImageView passwordConfirmationLeftImage = new UIImageView();
			UIImage passwordconfirmationimage = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/key.png");




			UIView passwordConfirmationLeftPadding = new UIView();



            passwordConfirmationLeftPadding.Frame = new CGRect(0, 0, passwordConfirmation.Frame.Height, passwordConfirmation.Frame.Height);



            passwordConfirmationLeftImage.Image = passwordconfirmationimage;
            passwordConfirmationLeftImage.Frame = new CGRect(passwordConfirmationLeftPadding.Bounds.Width / 2 - ((passwordConfirmation.Frame.Height / 2) / 2), passwordConfirmationLeftPadding.Bounds.Height / 2 - ((passwordConfirmation.Frame.Height / 2) / 2), passwordConfirmation.Frame.Height / 2, passwordConfirmation.Frame.Height / 2);

            passwordConfirmationLeftPadding.Bounds = CGRect.Inflate(passwordConfirmationLeftPadding.Frame, 0, 0);



            passwordConfirmationLeftImage.BackgroundColor = UIColor.White;
            passwordConfirmationLeftPadding.AddSubview(passwordConfirmationLeftImage);



            this.passwordConfirmation.LeftView = passwordConfirmationLeftPadding;



            this.passwordConfirmation.LeftView.BackgroundColor = UIColor.White;

			passwordConfirmation.Layer.BorderWidth = 1;
			passwordConfirmation.Layer.BorderColor = PorpoiseColors.lightGrey.CGColor;
			passwordConfirmation.Layer.CornerRadius = 5;

			passwordConfirmation.ReturnKeyType = UIReturnKeyType.Done;
			passwordConfirmation.EnablesReturnKeyAutomatically = true;
			passwordConfirmation.ShouldReturn = field =>
			{
				field.ResignFirstResponder();

				return true;
			};

			var tap = new UITapGestureRecognizer(() =>
			{
				password.ResignFirstResponder();

                passwordConfirmation.ResignFirstResponder();


			});

            this.View.AddGestureRecognizer(tap);

		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Bindings.Bind(nextButton).To(vm => vm.SetPassword);

            Bindings.Bind(password).To(vm => vm.Password);

            Bindings.Bind(passwordConfirmation).To(vm => vm.PasswordConfirmation);

            Bindings.Apply();
        }
       
    }
}

