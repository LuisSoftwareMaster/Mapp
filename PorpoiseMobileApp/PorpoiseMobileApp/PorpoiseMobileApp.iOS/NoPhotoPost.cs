using System;
using System.Diagnostics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.iOS.Converters;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public partial class NoPhotoPost : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("NoPhotoPost");
		public static readonly UINib Nib;

		MvxImageViewLoader _profileImageHelper;

		public void styleComponents()
		{

			Debug.WriteLine("STYLING COMPONENTS");

			nfloat scale = UIScreen.MainScreen.Scale;

			UIImage dotsImage;

            UIImage pencilImage;

			if (scale >= 2)
			{

				dotsImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/dots%402x.png");

				pencilImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/pencil%402x.png");
			}
			else
			{

				dotsImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/dots.png");

				pencilImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/pencil.png");

			}

			//dots.SetImage(dotsImage, UIControlState.Normal);

			dots.SetBackgroundImage(dotsImage, UIControlState.Normal);

			EditButton.SetBackgroundImage(pencilImage, UIControlState.Normal);

            givenWelldone.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/givenWelldones.png");

			dots.TintColor = UIColor.Black;

		}
		private void changeimage()
		{
			string imageSrc = ((WelldoneButton)wellDoneButton).ImageSrc;

			if (imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png"))
			{

				nfloat scale = UIScreen.MainScreen.Scale;

				if (scale >= 2)
				{

					((WelldoneButton)wellDoneButton).BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png");
					((WelldoneButton)wellDoneButton).ImageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png";

				}
				else
				{

					((WelldoneButton)wellDoneButton).BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png");
					((WelldoneButton)wellDoneButton).ImageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png";

				}
			}
			else if (imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png"))
			{
				((WelldoneButton)wellDoneButton).ImageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png";
				((WelldoneButton)wellDoneButton).BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png");

			}
			else if (imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png"))
			{
				((WelldoneButton)wellDoneButton).ImageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png";
				((WelldoneButton)wellDoneButton).BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png");
			}

		}
		protected NoPhotoPost(string bindingText, IntPtr handle) : base(bindingText, handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void isCompany()
		{

            this.DelayBind(() =>
            {

                var set = this.CreateBindingSet<NoPhotoPost, Models.HourLog>();

                set.Bind(EmployeeName).To(vm => vm.CompanyName).Apply();

                set.Bind(_profileImageHelper).For(x => x.ImageUrl).To(vm => vm.CompanyLogo).Apply();

			});

           
             EmployeeName.TextColor = PorpoiseColors.Orange; 
            companyNameLocation.RemoveFromSuperview();
            EditButton.Hidden = true;
            dots.Hidden = true;

            EditButton.RemoveFromSuperview();

            dots.RemoveFromSuperview();
			wellDoneButton.RemoveFromSuperview();
			givenWelldone.RemoveFromSuperview();
			givenWelldoneText.RemoveFromSuperview();


            //Center Employee Name

            //EmployeeName.RemoveConstraints(EmployeeName.Constraints);

            var centerConstraint = NSLayoutConstraint.Create(EmployeeName, NSLayoutAttribute.Top, NSLayoutRelation.Equal, profileImage, NSLayoutAttribute.Top, 1, 15.5f);

            var heightConstraint = NSLayoutConstraint.Create(EmployeeName, NSLayoutAttribute.Height, NSLayoutRelation.Equal, 1, 13);

			var widthConstraint = NSLayoutConstraint.Create(EmployeeName, NSLayoutAttribute.Width, NSLayoutRelation.Equal, 1, 247);


            this.AddConstraint(centerConstraint);

            this.AddConstraint(heightConstraint);

            this.AddConstraint(widthConstraint);

            foreach (NSLayoutConstraint constraint in profileImage.Constraints){

                Debug.WriteLine("IMAGE CONSTRAINT IN CLASS "+constraint.Constant);

            }

		}

		protected NoPhotoPost(IntPtr handle) : base(handle)
		{
			InitialiseImageHelper();
			this.DelayBind(() =>
			{

				var set = this.CreateBindingSet<NoPhotoPost, Models.HourLog>();
                //this.ImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
                //set.Bind(UserId).To(vm => vm.PosterId);
                set.Bind(EmployeeName).To(vm => vm.EmployeeName);

                
				set.Bind(EditButton).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new EditPostButtonHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(Date).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter());
				set.Bind(postDetails).For(x => x.AttributedText).To(vm => vm).WithConversion(new AttributedPostDetailsConverter());
				set.Bind(EditButton).To(vm => vm.DeletePostCommand);
				set.Bind(wellDoneButton).For(x => x.Welldones).To(vm => vm.WellDones);
				set.Bind(wellDoneButton).For(x => x.Hidden).To(x => x.PosterId).WithConversion(new GiveWelldoneHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(wellDoneButton).For("TouchDown").To(vm => vm.GiveWellDoneCommand);
				set.Bind(givenWelldone).For(x => x.Hidden).To(vm => vm).WithConversion(new GivenWelldoneTextHidden(AccountInfo.UserId.ToString()));
				set.Bind(givenWelldoneText).For(x => x.Hidden).To(vm => vm).WithConversion(new GivenWelldoneTextHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(givenWelldoneText).For(x => x.Text).To(vm => vm.WellDones).WithConversion(new GivenWelldonesTextValueConverter());
				//set.Bind(higrhligth).For(x => x.Hidden).To(x => x.PosterId).WithConversion(new GivenWelldoneImageConverter());
				set.Bind(givenWelldone).For(x => x.Hidden).To(vm => vm).WithConversion(new GivenWelldoneTextHidden(AccountInfo.UserId.ToString()));
				set.Bind(companyNameLocation).For(x => x.Text).To(vm => vm).WithConversion(new CompanyNameLocationConverter());
				set.Bind(NoPostLabel).For(x => x.Text).To(vm => vm.Highlight);
				set.Bind(_profileImageHelper).For(x => x.ImageUrl).To(vm => vm).WithConversion(new ProfileImageConverter());
				set.Bind(NoPostView).For(x => x.Hidden).To(vm => vm).WithConversion(new PostColorImageConverter());
				set.Bind(NoPostView).For(x => x.BackgroundColor).To(vm => vm).WithConversion(new NoPhotoPostBackgroundColorConverter());
				set.Bind(NoPostLabel).For(x => x.Hidden).To(vm => vm).WithConversion(new PostColorImageConverter());
				set.Bind(dots).To(vm => vm.DotCommand);
				set.Bind(this.dots).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new DotsButtonHiddenConverter(AccountInfo.UserId.ToString()));
                set.Bind(this.dotsView).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new DotsButtonHiddenConverter(AccountInfo.UserId.ToString()));

				set.Apply();

                var screenTap = new UITapGestureRecognizer(() =>
            {
                    dots.SendActionForControlEvents(UIControlEvent.TouchUpInside);

            });

var tapRecognizer = new UITapGestureRecognizer(() =>
{
	
					this.wellDoneButton.SendActionForControlEvents(UIControlEvent.TouchDown);

});

			this.welldoneButtonContainer.AddGestureRecognizer(tapRecognizer);

                wellDoneButton.TouchDown+= (sender, e) => {

                    this.changeimage();

                };

				this.styleComponents();

                dotsView.AddGestureRecognizer(screenTap);

				//set.Bind(NoPostView).For(x => x.Frame).To(vm => vm).WithConversion(new NoPostViewSizeCconverter(NoPostView));
				companyNameLocation.TextColor = PorpoiseColors.companyNameLocationLabel;
				companyNameLocation.TextColor = PorpoiseColors.companyNameLocationLabel;

				postDetails.TextColor = PorpoiseColors.NewDark;

				NoPostLabel.resizeLabel();

				profileImage.Layer.CornerRadius = profileImage.Frame.Height / 2;

				profileImage.ClipsToBounds = true;

				var noPostLabelConstraint = NSLayoutConstraint.Create(this.NoPostLabel, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, this.NoPostView, NSLayoutAttribute.Left, 1, 30);

				this.AddConstraint(noPostLabelConstraint);

				this.NoPostView.SizeToFit();
			});
		}

        public UILabel Employeename{

            get{

                return EmployeeName;

            }
            set{

                EmployeeName = value;

            }

        }

        public UILabel CompanyNameLocation{

            get{

                return companyNameLocation;

            }set{

                companyNameLocation = value;

            }

        }

		public UILabel WelldonesText
		{

			get
			{

				return this.givenWelldoneText;

			}

			set
			{

				Debug.WriteLine("UPDATING WELLDONES BIND");

				this.givenWelldoneText = value;

			}

		}
		public PorpoiseLabel PostDetails { 
		
			get {

				return postDetails;

			}
			set {

				postDetails = value;
			
			}
		
		}

		public PorpoiseLabel noPostLabel {

			get {

				return NoPostLabel;
			
			}
			set {

				NoPostLabel = value;
			
			}
		
		}

		public UIView noPostView{
			get{

				return this.NoPostView;

			}
			set{

				this.NoPostView = value;

			}

		}

		public static NoPhotoPost Create()
		{
			return (NoPhotoPost)Nib.Instantiate(null, null)[0];
		}

        public UIImageView ProfileImage{

            get{

                return profileImage;

            }
            set{

                profileImage = value;

            }

        }

		private void InitialiseImageHelper()
		{

			///_imageHelper = new MvxImageViewLoader(() => UploadedImage);

			_profileImageHelper = new MvxImageViewLoader(() => this.profileImage);

			_profileImageHelper.ImageUrl = "noImage.png";


			//this.profileImage.ClipsToBounds = true;

		}

		public UIView Line{

			get { return line; }
			set { line = value; }

		}

		public string ProfileUrl
		{
			get
			{
				Debug.WriteLine("PROFILE IMAGE: ");

				return _profileImageHelper.ImageUrl;

			}
			set
			{

				if (value != null)
				{

					_profileImageHelper.ImageUrl = value;

				}



				Debug.WriteLine("PROFILE IMAGE " + value);

			}

		}
	}
}
