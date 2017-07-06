using System;

using Foundation;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using UIKit;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Converters;
using System.Threading.Tasks;
using System.Diagnostics;
using CoreGraphics;

namespace PorpoiseMobileApp.iOS
{
	//TODO: When dealing with images, ALWAYS use MvxImageHelper and you MUST have bindingText set for the Image bindings to work.
	public partial class PostItemCellController : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("PostItemCellController");
		public static readonly UINib Nib;

		MvxImageViewLoader _imageHelper;
		MvxImageViewLoader _profileImageHelper;

		Client.IPorpoiseWebApiClient _client;

		private string employeeId;

		public override void ReloadInputViews()
		{
			base.ReloadInputViews();
		}

		public string EmployeeId
		{

			get
			{

				return this.employeeId;

			}
			set
			{

				employeeId = value;

			}

		}



		public UILabel GivenWelldoneText
		{

			get
			{

				return this.givenWelldoneText;

			}
			set
			{

				this.givenWelldoneText = value;

			}

		}
		public UIImageView GivenWelldone
		{

			get
			{

				return this.givenWelldone;

			}
			set
			{

				this.givenWelldone = value;

			}

		}

		public PostItemCellController(string bindingText, IntPtr handle) : base(bindingText, handle)
		{

		}

		/*public override void LayoutSubviews()
		{
			base.LayoutSubviews();
		}*/


		public UIImageView ProfileImage
		{

			get
			{

				return this.profileImage;

			}
			set
			{

				this.profileImage = value;

			}

		}

		public UILabel DateLabel
		{

			get
			{

				return this.Date;

			}
			set
			{

				this.Date = value;

			}

		}



		public UILabel PostDetails
		{

			get
			{

				return this.postDetails;

			}
			set
			{

				this.postDetails = value;

			}

		}

		public static PostItemCellController Create()
		{
			return (PostItemCellController)Nib.Instantiate(null, null)[0];
		}

		public UIImageView GetUploadedImage
		{

			get
			{

				return this.UploadedImage;

			}
			set
			{

				this.UploadedImage = value;

			}
		}

		public UIView Line
		{

			get
			{

				return line;

			}
			set
			{

				this.line = value;

			}

		}

        public void styleComponents(){




            Debug.WriteLine("STYLING COMPONENTS");

            nfloat scale = UIScreen.MainScreen.Scale;

            UIImage dotsImage;

            UIImage pencilImage;

            if(scale >= 2){

                dotsImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/dots%402x.png");

                pencilImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/pencil%402x.png");
            }
            else{

                dotsImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/dots.png");

                pencilImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/pencil.png");

            }

            //dots.SetImage(dotsImage, UIControlState.Normal);

            dots.SetBackgroundImage(dotsImage, UIControlState.Normal);

            EditButton.SetBackgroundImage(pencilImage, UIControlState.Normal);

            givenWelldone.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/givenWelldones.png");

            dots.TintColor = UIColor.Black;

           

        }

		public PostItemCellController(IntPtr handle) : base("ImageUrl PhotoUrl", handle)
		{



			InitialiseImageHelper();



			/*
			// add it to the image view
			givenWelldone.AddGestureRecognizer(tapGesture);
			// make sure imageView can be interacted with by user
			givenWelldone.UserInteractionEnabled = true;
*/
           

			this.DelayBind(() =>
			{

				var set = this.CreateBindingSet<PostItemCellController, HourLog>();
				//this.ImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
				//set.Bind(UserId).To(vm => vm.PosterId);
				set.Bind(EmployeeName).To(vm => vm.EmployeeName);
				//set.Bind(Label).To(vm => vm.PosterId);
				//set.Bind(Welldones).To(vm => vm.WellDones.Length);
				//set.Bind(DeleteButton).For("TouchDown").To(vm => vm.DeletePostCommand);
				//set.Bind(hidden_lblOrg).To(vm => vm.OrganisationName);
				//set.Bind(hidden_lblHours).To(vm => vm.NumberOfHours);
				set.Bind(EditButton).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new EditPostButtonHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(Date).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter());
				set.Bind(postDetails).For(x => x.AttributedText).To(vm => vm).WithConversion(new AttributedPostDetailsConverter());
				set.Bind(EditButton).To(vm => vm.DeletePostCommand);
				set.Bind(wellDoneButton).For(x => x.Welldones).To(vm => vm.WellDones);
				set.Bind(wellDoneButton).For(x => x.Hidden).To(x => x.PosterId).WithConversion(new GiveWelldoneHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(wellDoneButton).For("TouchDown").To(vm => vm.GiveWellDoneCommand);
                set.Bind(dots).To(vm => vm.DotCommand);
				set.Bind(givenWelldone).For(x => x.Hidden).To(vm => vm).WithConversion(new GivenWelldoneTextHidden(AccountInfo.UserId.ToString()));
				//set.Bind(givenWelldoneText).For(x => x.Hidden).To(vm => vm).WithConversion(new GivenWelldoneTextHidden());
				set.Bind(givenWelldoneText).For(x => x.Text).To(vm => vm.WellDones).WithConversion(new GivenWelldonesTextValueConverter());
				//set.Bind(higrhligth).For(x => x.Hidden).To(x => x.PosterId).WithConversion(new GivenWelldoneImageConverter());
				set.Bind(companyNameLocation).For(x => x.Text).To(vm => vm).WithConversion(new CompanyNameLocationConverter());
				set.Bind(highligth).For(x => x.Text).To(vm => vm.Highlight);
				set.Bind(wellDoneHeight).For(x => x.Constant).To(vm => vm).WithConversion(new WelldoneConstraintValue(AccountInfo.UserId.ToString())).OneWay();
				set.Bind(welldoneImageHeight).For(x => x.Constant).To(vm => vm).WithConversion(new WelldoneConstraintValue(AccountInfo.UserId.ToString())).OneWay();
				set.Bind(highlightLineConstraint).For(x => x.Constant).To(vm => vm).WithConversion(new HighlightLineConstraintConverter(AccountInfo.UserId.ToString())).OneWay();
				set.Bind(_profileImageHelper).For(x => x.ImageUrl).To(vm => vm).WithConversion(new ProfileImageConverter());
				set.Bind(this.dots).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new Converters.DotsButtonHiddenConverter(AccountInfo.UserId.ToString()));
				set.Bind(this.dotsView).For(x => x.Hidden).To(vm => vm.PosterId).WithConversion(new Converters.DotsButtonHiddenConverter(AccountInfo.UserId.ToString()));

				//set.Bind(NoPostView).For(x => x.Frame).To(vm => vm).WithConversion(new NoPostViewSizeCconverter(NoPostView));
				companyNameLocation.TextColor = PorpoiseColors.companyNameLocationLabel;
				companyNameLocation.TextColor = PorpoiseColors.companyNameLocationLabel;

				postDetails.TextColor = PorpoiseColors.NewDark;

				//postDetails.Font.S
				//set.Bind(wellDoneButton).For(x => x.BackgroundImage).WithConversion(new GivenWelldoneOrangeImageConverter());

				//set.Bind(_backGroundImage).For(x => x.ImageUrl).To(vm => vm).WithConversion(new GivenWelldoneOrangeImageConverter());
				//set1.Bind(hourLog).To(vm => vm.PostId);

				/*if (this.DeleteButton != null) {

					this.DeleteButton.Hidden = true;
				
				}*/

var tapRecognizer = new UITapGestureRecognizer(() =>
{ 
					
					this.wellDoneButton.SendActionForControlEvents(UIControlEvent.TouchDown);

});

			this.welldoneButtonContainer.AddGestureRecognizer(tapRecognizer);

				if (EmployeeName != null)
				{
					//EmployeeName.TextColor = PorpoiseColors.Turquoise;
				}

				set.Apply();
				var screenTap = new UITapGestureRecognizer(() =>
		  {
			  dots.SendActionForControlEvents(UIControlEvent.TouchUpInside);

		  });

                this.wellDoneButton.TouchDown += (sender, e) => {

                    Debug.WriteLine("WELLDONES CLICKED ON VIEW CONTROLLER");

                    this.changeimage();

                };

                this.styleComponents();

				dotsView.AddGestureRecognizer(screenTap);
                /*this.BeginInvokeOnMainThread(() =>
				{

					if (this.givenWelldoneText.Hidden || this.givenWelldone.Hidden)
					{

						Debug.WriteLine("THIS IS ONE OF YOUR POSTS AND HIDDEN " + this.highligth.Text);

						NSLayoutConstraint lineConstraint = NSLayoutConstraint.Create(this.highligth, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.line, NSLayoutAttribute.Bottom, 1, 8);

						this.AddConstraint(lineConstraint);


						//this.givenWelldone.RemoveFromSuperview();

						//this.givenWelldoneText.RemoveFromSuperview();

						foreach (UIView view in this.Subviews)
						{

							Debug.WriteLine("VIEW DESCRIPTION: " + view.Description);

							foreach (UIView subview in view.Subviews)

							{

								Debug.WriteLine("SUBVIEW DESCRIPTION: " + subview.Description);

								if (subview is UILabel)
								{

									UILabel label = (UILabel)subview;



								}

							}




						}

						foreach (NSLayoutConstraint constraint in this.givenWelldone.Constraints)
						{

							this.givenWelldone.RemoveConstraint(constraint);

						}
						foreach (NSLayoutConstraint constraint in this.line.Constraints)
						{

							Debug.WriteLine("LINE CONSTRAINT: " + constraint.Constant);

							if (constraint.Constant == 1)
							{

								constraint.Constant = 1;

							}

						}

						foreach (NSLayoutConstraint constraint in this.givenWelldoneText.Constraints)
						{

							this.givenWelldoneText.RemoveConstraint(constraint);

						}



						this.givenWelldone.RemoveFromSuperview();

						this.givenWelldoneText.RemoveFromSuperview();

						this.UpdateConstraints();

						this.SetNeedsLayout();

					}

				});*/

                this.profileImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/noImage.png");


				/*else {

					Debug.WriteLine("POSTHIGHLIGHT WITH THUMBS UP: "+this.Highlight.Text);
				
					NSLayoutConstraint wellDoneContraint = NSLayoutConstraint.Create(this.highligth, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.givenWelldone, NSLayoutAttribute.Bottom, 1, 8);

					this.AddConstraint(wellDoneContraint);

					this.UpdateConstraints();

					this.SetNeedsLayout();

				
				}*/

				/*foreach (NSLayoutConstraint aux in postDetails.Constraints) {

					Debug.WriteLine("CONSTRATINT "+aux.GetIdentifier()+" "+aux.Constant);
				
				}*/


				//Resize label

				/*CGSize contentSize = this.postDetails.SizeThatFits(postDetails.Bounds.Size);

				CGRect frame = postDetails.Frame;

				frame.Size.Height = contentSize.Height;

				self.myTextViewTitle.frame = frame


				aspectRatioTextViewConstraint = NSLayoutConstraint(item: self.myTextViewTitle, attribute: .Height, relatedBy: .Equal, toItem: self.myTextViewTitle, attribute: .Width, multiplier: myTextViewTitle.bounds.height / myTextViewTitle.bounds.width, constant: 1)

				self.myTextViewTitle.addConstraint(aspectRatioTextViewConstraint!)*/

				this.EmployeeName.TextColor = UIColor.FromRGB(63, 63, 63);

				ProfileImage.Layer.MasksToBounds = false;

				Layer.BorderColor = UIColor.White.CGColor;

				ProfileImage.Layer.CornerRadius = ProfileImage.Frame.Height / 2;

				ProfileImage.ClipsToBounds = true;

				/*if (this.givenWelldone.Hidden) {

					this.givenWelldoneText.RemoveFromSuperview();

					this.givenWelldone.RemoveFromSuperview();

					this.UpdateConstraints();
				
				}*/

				Debug.WriteLine("HEIGHT COMPONENT BEFORE RESIZE " + postDetails.Frame.Size.Height);


				//postDetails.Frame = new CGRect(postDetails.Frame.X,wellDoneButton.Frame.Y, postDetails.Frame.Width, postDetails.Frame.Height);

				/*Debug.WriteLine("POST DETAILS ORIGIN " + postDetails.Frame.Location.ToString());

				Debug.WriteLine("WELL DONES ORIGIN " + wellDoneButton.Frame.Location.ToString());

				Debug.WriteLine("EMPLOYEE ID: "+AccountInfo.UserId.ToString());

				Debug.WriteLine("USERID: "+this.UserId.Text);*/

				/*UIView lineView = new UIView(new CGRect(0, 0, 392, 1.0));

				lineView.Layer.BorderWidth = 1.0f;

				lineView.Layer.BorderColor = PorpoiseColors.Grey.CGColor;*/

				//lineView.UpdateConstraints();

				//this.AddSubview(lineView);

				/*NSLayoutConstraint welldoneConstraint = NSLayoutConstraint.Create(this.highligth, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.givenWelldone, NSLayoutAttribute.Bottom, 1, 0);

				welldoneConstraint.Priority = 1000;

				NSLayoutConstraint lineConstraint = NSLayoutConstraint.Create(this.highligth,NSLayoutAttribute.Width, NSLayoutRelation.Equal, 1, 351);
				*/
				//NSLayoutConstraint postDetailsConstraint = NSLayoutConstraint.Create(this.highligth, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.GivenWelldone, NSLayoutAttribute.Bottom, 1, 1);

				//NSLayoutConstraint[] constraints = new NSLayoutConstraint[1];

				//constraints[0] = postDetailsConstraint;

				//this.AddConstraints(constraints);

				//constraints[1] = welldoneConstraint;

				//constraints[2] = postDetailsConstraint;*/

				//this.AddConstraints(constraints);



				//lineView.AddConstraint(lineConstraint);


				//NSLayoutConstraint lineConstraint = NSLayoutConstraint.Create(this.highligth, NSLayoutAttribute.Width, NSLayoutRelation.Equal, this.givenWelldone, NSLayoutAttribute.Bottom, 1, 1);



				//this.AddConstraint(lineConstraint);

				//this.UpdateConstraints();

				//this.SetNeedsLayout();

				if (this.wellDoneButton.Hidden)
				{

					/*Debug.WriteLine("THIS IS YOUR POST");

					this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width,(this.Frame.Height* 0.5));

					this.Bounds = new CGRect(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, (this.Bounds.Height * 0.5));

					this.SizeToFit();

					this.SetNeedsLayout();*/


				}


				//NSLayoutConstraint highligthContraint = NSLayoutConstraint.Create(this.givenWelldone, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this.highligth, NSLayoutAttribute.Top, 1, 1);

				//NSLayoutConstraint dateConstraint = NSLayoutConstraint.Create(this.givenWelldone, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this.highligth, NSLayoutAttribute.Top, 1, 1);

				//this.AddConstraint(dateConstraint);

				//this.SetNeedsLayout();


				//this.getUserId().ContinueWith(OnMyAsyncMethodFailed, TaskContinuationOptions.OnlyOnFaulted);

				//Debug.WriteLine("EMPLOYEENAME: "+UserId.Text);

				//Debug.WriteLine("EMPLOYEEID: " + AccountInfo.UserId);


				//

				//NSLayoutConstraint(item: myView, attribute: .Height, relatedBy: .Equal, toItem: myView, attribute:.Width, multiplier: 2.0, constant: 0.0).active = true

				//public static NSLayoutConstraint Create(NSObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation, nfloat multiplier, nfloat constant);

				/*postDetails.Frame = new CGRect(postDetails.Frame.Location.X,postDetails.Frame.Location.Y, postDetails.Frame.Size.Width, postDetails.Frame.Size.Height*3);

				postDetails.Lines = 3;

				NSLayoutConstraint constraint = NSLayoutConstraint.Create(postDetails, NSLayoutAttribute.Height, NSLayoutRelation.Equal, 2, 26);

				postDetails.AddConstraint(constraint);

				postDetails.UpdateConstraints();
				postDetails.Bounds = new CGRect(postDetails.Bounds.Location.X, postDetails.Bounds.Location.Y, postDetails.Bounds.Width, postDetails.Bounds.Height*2);

				Debug.WriteLine("COMPONENT VALUE "+postDetails.Text+ postDetails.IntrinsicContentSize.Height);

				Debug.WriteLine("HEIGHT COMPONENT AFTER RESIZE " + postDetails.Frame.Size.Height);

				this.postDetails.SizeToFit();

				this.postDetails.LineBreakMode = UILineBreakMode.WordWrap;

				this.SetNeedsDisplay();

*/

				/*if (_profileImageHelper != null) { 
				
				ProfileUrl = profileImage;
				
				}*/
				/*UIView lineView = new UIView(new CGRect(0, (this.givenWelldoneText.Frame.Location.Y+this.givenWelldoneText.Frame.Size.Height) , 392, 1.0));

				lineView.Layer.BorderWidth = 1.0f;

				lineView.Layer.BorderColor = PorpoiseColors.Grey.CGColor;

				this.AddSubview(lineView);*/

				//this.modifyConstraints();

				/*
				this.postDetails.Lines = 0;

				this.postDetails.SizeToFit();

				this.UpdateConstraintsIfNeeded();

				this.SetNeedsLayout();*/

				//this.resizeLabel(this.postDetails);

				//this.resizeLabel(this.highligth);

				/*if (this.wellDoneButton.Hidden) {

					this.wellDoneButton.Frame = new CGRect(this.wellDoneButton.Frame.X, this.wellDoneButton.Frame.Y, this.wellDoneButton.Frame.Width, 0);

					this.givenWelldone.Frame = new CGRect(this.givenWelldone.Frame.X, this.givenWelldone.Frame.Y, this.givenWelldone.Frame.Width, 0);

					this.givenWelldoneText.Frame = new CGRect(this.givenWelldoneText.Frame.X, this.givenWelldoneText.Frame.Y, this.givenWelldoneText.Frame.Width, 0);

				}*/

				//this.profileImage.Frame = new CGRect(33f, 33f, this.profileImage.Bounds.X, this.profileImage.Bounds.Y);
				float increaseCell = 0;

				/*if (this.numberLines(this.postDetails)>1)
				{
					
					increaseCell = increaseCell + (this.numberLines(this.postDetails) * 12);
				
				}
				if (this.numberLines(this.highligth) > 1)
				{

					increaseCell = increaseCell + (this.numberLines(this.highligth) * 11);

				}*/



				//this.Frame = new CGRect(this.Bounds.Width, (this.Bounds.Height + increaseCell), this.Bounds.X, this.Bounds.Y);

				this.LayoutIfNeeded();


			



			});



		}

		/*private void redefineConstraints() { 
		
			//postDetails

			this.UploadedImage.RemoveFromSuperview();

			NSLayoutConstraint topConstraint = NSLayoutConstraint.Create(postDetails, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.NoPostView, NSLayoutAttribute.Bottom, 1, 10);

			this.highligth.RemoveFromSuperview();

			NSLayoutConstraint dateConstraint = NSLayoutConstraint.Create(this.Date, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.givenWelldoneText, NSLayoutAttribute.Bottom, 1, 10);

			NSLayoutConstraint viewConstraint = NSLayoutConstraint.Create(this, NSLayoutAttribute.Height, NSLayoutRelation.Equal, 1, 200);

			this.AddConstraint(topConstraint);

			this.AddConstraint(dateConstraint);

			this.AddConstraint(viewConstraint);

			this.Superview.AddConstraint(viewConstraint);

			//this.Frame = new CGRect(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, 200f);

			//this.SizeToFit();
		}*/

		/*private void StylishComponentsLabelConstraints()
		{

			NSLayoutConstraint topConstraint = NSLayoutConstraint.Create(NoPostLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.NoPostView, NSLayoutAttribute.Top, 1, 20);

			//NSLayoutConstraint leftConstraint = NSLayoutConstraint.Create(NoPostLabel, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, this, NSLayoutAttribute.Left, 1, 30);

			//this.AddConstraint(leftConstraint);

			//NSLayoutConstraint bottomConstraint = NSLayoutConstraint.Create(NoPostLabel, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this.NoPostView, NSLayoutAttribute.Bottom, 1, 20);



			//this.AddConstraint(bottomConstraint);

			nfloat viewHeight = 0;

			viewHeight = 60 + NoPostLabel.Bounds.Height;

			NoPostView.Frame = new CGRect(NoPostView.Bounds.X, NoPostView.Bounds.Y, NoPostView.Bounds.Width, 100f);

			//NoPostView.SizeToFit();
			this.AddConstraint(topConstraint);
		}*/
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
		public NSLayoutConstraint highlightConstraint()
		{

			return this.highlightLineConstraint;

		}

		public override void MovedToSuperview()
		{
			this.LayoutIfNeeded();
		}

		private nfloat numberLines(UILabel label)
		{
			CGSize maximumSize = new CGSize(label.Frame.Width, float.MaxValue);

			NSString text = new NSString(label.Text);

			UIFont font = label.Font;

			NSAttributedString attributedText = new NSAttributedString(text, font);

			CGRect rect = attributedText.GetBoundingRect(maximumSize, NSStringDrawingOptions.UsesLineFragmentOrigin, null);

			//CGSize stringSize = new CGSize(text.StringSize(font));

			/*foreach (NSLayoutConstraint constraint in label.Constraints) {

				Debug.WriteLine(constraint.GetIdentifier()+" : "+constraint.Constant);

				constraint.Constant = rect.Height;

				//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, (this.Frame.Height+ (this.lable)));
					
			
			}*/

			//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, (this.Frame.Height + (rect.Height - label.Frame.Height)));

			//label.Frame = new CGRect(label.Frame.X, label.Frame.Y, label.Frame.Width, rect.Height);

			//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, 600f);

			/*NSLayoutConstraint lineConstraint = NSLayoutConstraint.Create(highligth, NSLayoutAttribute.Bottom, NSLayoutRelation.LessThanOrEqual, Date, NSLayoutAttribute.Top, 1, -15);

			this.AddConstraint(lineConstraint);*/

			label.PreferredMaxLayoutWidth = rect.Width;

			//this.UpdateConstraints();

			//this.SetNeedsDisplay();

			Debug.WriteLine("RECOMMENDED HEIGHT " + rect.Height + " FOR: " + label.Text);

			return rect.Height;

		}

		private void resizeLabel(UILabel label)
		{

			Debug.WriteLine("TEXT VALUE: " + label.Text);

			CGSize maximumSize = new CGSize(label.Frame.Width, float.MaxValue);

			NSString text = new NSString(label.Text);

			UIFont font = label.Font;

			NSAttributedString attributedText = new NSAttributedString(text, font);

			CGRect rect = attributedText.GetBoundingRect(maximumSize, NSStringDrawingOptions.UsesLineFragmentOrigin, null);

			//CGSize stringSize = new CGSize(text.StringSize(font));

			/*foreach (NSLayoutConstraint constraint in label.Constraints) {

				Debug.WriteLine(constraint.GetIdentifier()+" : "+constraint.Constant);

				constraint.Constant = rect.Height;

				//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, (this.Frame.Height+ (this.lable)));
					
			
			}*/

			//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, (this.Frame.Height + (rect.Height - label.Frame.Height)));

			//label.Frame = new CGRect(label.Frame.X, label.Frame.Y, label.Frame.Width, rect.Height);

			//this.Frame = new CGRect(this.Frame.X, this.Frame.Y, this.Frame.Width, 600f);

			/*NSLayoutConstraint lineConstraint = NSLayoutConstraint.Create(highligth, NSLayoutAttribute.Bottom, NSLayoutRelation.LessThanOrEqual, Date, NSLayoutAttribute.Top, 1, -15);

			this.AddConstraint(lineConstraint);*/

			label.PreferredMaxLayoutWidth = rect.Width;

			//this.UpdateConstraints();

			//this.SetNeedsDisplay();

			Debug.WriteLine("RECOMMENDED HEIGHT " + rect.Height + " FOR: " + label.Text);

		}

		public static void OnMyAsyncMethodFailed(Task task)
		{
			Exception ex = task.Exception;
			// Deal with exceptions here however you want
		}

		private async Task getUserId()
		{

			var employee = await _client.GetEmployee();

			if (employee != null)
			{

				employee.UserId.Value.ToString();

				//Debug.WriteLine("EMPLOYEENAME: " + UserId.Text);

				Debug.WriteLine("EMPLOYEE ID: " + this.getUserId());

			}

		}
		private async Task modifyConstraints()
		{

			var employee = await _client.getEmployeeRow((System.Guid)AccountInfo.UserId);

			if (employee != null)
			{

				Debug.WriteLine("EMPLOYEE NAME: " + employee.FirstName);

			}

			Debug.WriteLine("WINDOW HIGHT: " + this.Frame.Height);


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

		public UILabel Highlight
		{

			get
			{

				return this.highligth;

			}

			set
			{

				this.highligth = value;

			}

		}

		public string ImageUrl
		{
			get
			{
				return _imageHelper.ImageUrl;
			}
			set
			{
				Debug.WriteLine("IMAGE URL: " + value);

				Debug.WriteLine("PROFILE IMAGE: " + this.ProfileUrl);


				_imageHelper.ImageUrl = value;


			}
		}




		private void InitialiseImageHelper()
		{

			_imageHelper = new MvxImageViewLoader(() => UploadedImage);

			_profileImageHelper = new MvxImageViewLoader(() => this.profileImage);

			_profileImageHelper.ImageUrl = "noImage.png";


			//this.profileImage.ClipsToBounds = true;

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

		private void resizeView()
		{

			if (this.givenWelldone.Hidden && this.givenWelldoneText.Hidden)
			{

				this.givenWelldone.RemoveFromSuperview();

				this.givenWelldoneText.RemoveFromSuperview();
			}

		}

		/*public UILabel PostDetails { 
		
			get {

				Debug.WriteLine("RETURNING POST DETAILS");

				return this.postDetails;
			
			}set {

				this.postDetails.TextColor = UIColor.Blue;

				this.postDetails = value;


			
			}
		
		}*/

		public UIButton WellDoneButton
		{

			get
			{


				return this.wellDoneButton;

			}
			set
			{

				this.wellDoneButton = (WelldoneButton)value;

				Debug.WriteLine("CHANGING BUTTON");

			}

		}



		internal void ClearDisplay()
		{
			if (DataContext != null)
			{
				UploadedImage.Image = null;

				this.profileImage = null;
			}
		}


	}


}