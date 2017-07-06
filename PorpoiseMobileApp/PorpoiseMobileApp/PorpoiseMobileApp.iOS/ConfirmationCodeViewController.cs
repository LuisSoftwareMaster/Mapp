using Foundation;
using System;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using System.Diagnostics;
using PorpoiseMobileApp.iOS.Services;
using CoreGraphics;

namespace PorpoiseMobileApp.iOS
{
    public partial class ConfirmationCodeViewController : MvvmViewController<ConfirmationCodeViewModel>
    {
        public ConfirmationCodeViewController (IntPtr handle) : base (handle)
        {
        }

        private void styleView(){

            this.View.BackgroundColor = PorpoiseColors.Turquoise;

            this.contentForm.Layer.CornerRadius = 5;
            this.continueButton.BackgroundColor = PorpoiseColors.Turquoise;

            NSAttributedString attributed = new NSAttributedString(string.Format(Resource.ConfirmationCodeMessage,ViewModel.Email));

            this.message.AttributedText = attributed;

            System.Diagnostics.Debug.WriteLine("MESSAGE: "+attributed);

            ((PorpoiseLabel)this.message).resizeLabel();

            this.message.Bounds = new CoreGraphics.CGRect(this.message.Bounds.X, this.message.Bounds.Y, this.message.Bounds.Width, PorpoiseLabel.heightForLabelGlobal(message.Font, (float)message.Bounds.Width, attributed.ToString()));

			this.message.Frame = new CoreGraphics.CGRect(this.message.Bounds.X, this.message.Bounds.Y, this.message.Bounds.Width, PorpoiseLabel.heightForLabelGlobal(message.Font, (float)message.Bounds.Width, attributed.ToString()));

            this.logo.Image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png");

            //TextField Label

            this.confirmationCode.LeftViewMode = UITextFieldViewMode.Always;

			UIImageView confirmationLeftImage = new UIImageView();
			UIImage image = PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/laptop-computer.png");




			UIView confirmationLeftPadding = new UIView();



            confirmationLeftPadding.Frame = new CGRect(0, 0, confirmationCode.Frame.Height, confirmationCode.Frame.Height);



            confirmationLeftImage.Image = image;
            confirmationLeftImage.Frame = new CGRect(confirmationLeftPadding.Bounds.Width / 2 - ((confirmationCode.Frame.Height / 2) / 2), confirmationLeftPadding.Bounds.Height / 2 - ((confirmationCode.Frame.Height / 2) / 2), confirmationCode.Frame.Height / 2, confirmationCode.Frame.Height / 2);

            confirmationLeftPadding.Bounds = CGRect.Inflate(confirmationLeftPadding.Frame, 0, 0);



            confirmationLeftImage.BackgroundColor = UIColor.White;
            confirmationLeftPadding.AddSubview(confirmationLeftImage);

			

			this.confirmationCode.LeftView = confirmationLeftPadding;



			this.confirmationCode.LeftView.BackgroundColor = UIColor.White;

            confirmationCode.Layer.BorderWidth = 1;
            confirmationCode.Layer.BorderColor = PorpoiseColors.lightGrey.CGColor;
            confirmationCode.Layer.CornerRadius = 5;

            confirmationCode.ReturnKeyType = UIReturnKeyType.Done;
            confirmationCode.EnablesReturnKeyAutomatically = true;
			confirmationCode.ShouldReturn = field =>
			{
				field.ResignFirstResponder();
			
				return true;
			};

			var tap = new UITapGestureRecognizer(() =>
			{
                confirmationCode.ResignFirstResponder();
				

			});

            confirmationCode.EditingDidEnd += (sender, e) => {

               /* if(ViewModel.validCode()){

                    confirmationCode.Layer.BorderWidth = 1;

                    confirmationCode.Layer.BorderColor = PorpoiseColors.LightGrey.CGColor;

                    errorLabel.Hidden = true;

                }else{

					confirmationCode.Layer.BorderWidth = 1;

                    confirmationCode.Layer.BorderColor = PorpoiseColors.LightErrorRed.CGColor;

                    errorLabel.Hidden = false;

                }*/

            };

            this.View.AddGestureRecognizer(tap);

            errorLabel.Text = Resource.ConfirmationCodeError;

            this.contentForm.Layer.CornerRadius = 5;

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
		}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.styleView();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Bindings.Bind(confirmationCode).To(vm => vm.GeneratedCode);

           Bindings.Bind(this.back).To(vm => vm.BackCommand);

            Bindings.Bind(this.continueButton).To(vm => vm.ContinueCommand);

            Bindings.Apply();

        }




    }
}