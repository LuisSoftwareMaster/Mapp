using System;
using System.Diagnostics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.iOS.Converters;
using PorpoiseMobileApp.Models;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public partial class CompanyPostItemCellController : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("CompanyPostItemCellController");
		public static readonly UINib Nib;

		MvxImageViewLoader _imageHelper;

		MvxImageViewLoader _profileImageHelper;

		static CompanyPostItemCellController()
		{
			Nib = UINib.FromName("CompanyPostItemCellController", NSBundle.MainBundle);
		}

        private void styleComponents(){

            PlayButton.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/PlayButton.png");

        }

		public CompanyPostItemCellController(IntPtr handle) : base("ImageUrl PhotoUrl", handle)
		{
			InitialiseImageHelper();

			var hourLog = DataContext as HourLog;
			var highlightTap = new UITapGestureRecognizer(() =>
			{

			});

			this.DelayBind(() =>
			{
				Console.WriteLine("BIND!!!");
				var set = this.CreateBindingSet<CompanyPostItemCellController, HourLog>();
                set.Bind(dots).To(vm => vm.DotCommand);
				set.Bind(PostDetails).For(x => x.Text).To(x => x.Highlight);
				//TODO - NEED TO HAVE COMPANY NAME IN HOUR LOG TO BIND HERE

				set.Bind(CompanyName).For(x => x.Text).To(x => x.CompanyName);
				set.Apply();
				//set.Bind(this.dots).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new DotsButtonHiddenConverter(AccountInfo.UserId.ToString()));

				//set.Bind(postdate).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter());

				//set.Bind(CompanyName).For(x => x.TextColor).To(PorpoiseColors.Orange);

				var imageTap = new UITapGestureRecognizer(() =>
			{
				if (!string.IsNullOrEmpty(((HourLog)DataContext).VideoUrl))
				{
					UIApplication.SharedApplication.OpenUrl(new NSUrl(((HourLog)DataContext).VideoUrl));
				}
			});
				imageTap.NumberOfTapsRequired = 1;
				imageTap.NumberOfTouchesRequired = 1;
				PostImage.UserInteractionEnabled = true;
				PostImage.AddGestureRecognizer(imageTap);

				if (CompanyName != null)
				{
					CompanyName.TextColor = PorpoiseColors.Orange;
				}

				

				companyImage.Layer.BorderWidth = 1;

				companyImage.Layer.MasksToBounds = false;

				companyImage.Layer.BorderColor = UIColor.White.CGColor;

				companyImage.Layer.CornerRadius = companyImage.Frame.Height / 2;

				companyImage.ClipsToBounds = true;

                this.styleComponents();

				Debug.WriteLine("IMAGE ROUNDED");
			});



		}
		public string ImageUrl
		{
			get
			{
				return _imageHelper.ImageUrl;
			}
			set
			{
				_imageHelper.ImageUrl = value;
			}
		}


		public UIImageView ProfileImage
		{

			get
			{

				return this.companyImage;

			}
			set
			{

				this.companyImage = value;

			}

		}

		public string ProfileImageHelper
		{
			get
			{


				return _profileImageHelper.ImageUrl;

			}
			set
			{


				_profileImageHelper.ImageUrl = value;

			}

		}

		public UILabel getPostDetails { 
		
			get {

				return this.PostDetails;

			}set {

				this.PostDetails = value;

			}
		
		}

		private void InitialiseImageHelper()
		{

			_imageHelper = new MvxImageViewLoader(() => PostImage);

			_profileImageHelper = new MvxImageViewLoader(() => this.companyImage);

		}

		public void ClearDisplay()
		{
			if (DataContext != null)
			{
				PostImage.Image = null;
			}
		}

		public UIImageView PlayIcon
		{
			get { return this.PlayButton; }

		}
		public UIImageView PostImageClickable
		{
			get { return this.PostImage; }

		}
	}
}
