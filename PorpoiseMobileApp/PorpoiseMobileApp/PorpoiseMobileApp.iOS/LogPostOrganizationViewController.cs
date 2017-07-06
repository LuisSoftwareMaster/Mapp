using Foundation;
using System;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.Binding.iOS.Views;
using PorpoiseMobileApp.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using CoreGraphics;
using System.Linq;

using Acr.Settings;
using MvvmCross.Platform;
using PorpoiseMobileApp.Converters;

namespace PorpoiseMobileApp.iOS
{
    public partial class LogPostOrganizationViewController : MvvmViewController<LogPostOrganizationViewModel>
    {
		UIPickerView _orgPicker;
		UIDatePicker _datepicker;
		private bool loaded = false;
		private ISettings _settings;
		private const int ORG_PICKER_TAG = 0;
		private string highlightBeforeChanged="";
        NSLayoutConstraint navigationConstraint;
		private UIButton button;
        public LogPostOrganizationViewController (IntPtr handle) : base (handle)
        {
        }

		public override  void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			UIApplication.SharedApplication.StatusBarHidden = false;

			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;
			//MvxPickerViewModel orgsPickerModel =  SetupOrganisationsPickerModel(_orgPicker);
			OrganisationSelection.InputView = _orgPicker;
			//_orgPicker.Tag = ORG_PICKER_TAG;

			//SetUpPickerToolbar(OrganisationSelection, _orgPicker, orgsPickerModel);
			Debug.WriteLine("DISPLAY NAVIGATION BAR");
			this.NavigationController.NavigationBar.Hidden = false;
			this.NavigationBarSetUp();

		}

        public override void UpdateViewConstraints()
        {
            base.UpdateViewConstraints();
            //this.View.AddConstraint(navigationConstraint);
        }

		//Hold highlight value
		private UITextField spareHightlight;

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

			spareHightlight = new UITextField();

			spareHightlight.Frame = new CGRect(this.highlight.Bounds.X, this.highlight.Bounds.Y, 30, 30);

			spareHightlight.Hidden = true;

			this.View.Add(spareHightlight);

			spareHightlight.Text = "Hello";

			UIApplication.CheckForEventAndDelegateMismatches = false;

			this.highlight.WeakDelegate = this;

			this._settings = Mvx.Resolve<ISettings>();

			_orgPicker = BuildOrganisationPicker();

			var result = await SetupOrganisationsPickerModel(_orgPicker);


			MvxPickerViewModel orgsPickerModel = result;

			_orgPicker.Tag = ORG_PICKER_TAG;
			SetUpPickerToolbar(OrganisationSelection, _orgPicker, orgsPickerModel);




			UITapGestureRecognizer screenTap = new UITapGestureRecognizer(() =>
			{
				DateSelection.ResignFirstResponder();

				OrganisationSelection.ResignFirstResponder();

				highlight.ResignFirstResponder();

				unit.ResignFirstResponder();


			});

/*UITapGestureRecognizer highlightTap = new UITapGestureRecognizer(() =>
{
	

				if (this.ViewModel.Highlight.Equals("Add a description"))
	{

					this.ViewModel.Highlight = "";

		highlight.TextColor = UIColor.LightGray;

		LogPost.highlight = "";

	}

	this.highlight.BecomeFirstResponder();

			});

			this.highlight.AddGestureRecognizer(highlightTap);*/

			this.View.AddGestureRecognizer(screenTap);

			_datepicker = BuildDatePicker();

			NSDateFormatter dateFormatter = new NSDateFormatter();

			dateFormatter.DateFormat = "dd-MMM-yy";

			_datepicker.MaximumDate = NSDate.Now;
			DateSelection.InputView = _datepicker;
			OrganisationSelection.TouchUpInside += (sender, e) =>
			{
				ShowPicker(_orgPicker);
			};



			if (ViewModel.IsEditing || LogPost.isEditing)
			{

				Bindings.Bind(metricLabel).For(x => x.Text).To(vm => vm.NumberMetricLabel);
				Bindings.Bind(OrganisationLabel).For(x => x.Text).To(vm => vm.OrganisationRequired);
				Bindings.Bind(waiting).For(x => x.Hidden).To(vm => vm.InFlight).WithConversion(new InverseConverter());
				Bindings.Bind(Overlay).For(x => x.Hidden).To(vm => vm.InFlight).WithConversion(new InverseConverter());
				Bindings.Bind(unit).For(x => x.Text).To(vm => vm.ContributionAmount).WithConversion(new DoubleCantBe0ToStringConverter());
				Bindings.Bind(orgsPickerModel).For(x => x.ItemsSource).To(vm => vm.Organisations);
				//Bindings.Bind(orgsPickerModel).For(x => x.SelectedItem).To(vm => vm.Organisation);
				Bindings.Bind(OrganisationSelection).For(x => x.Text).To(vm => vm.Organisation.Name);
				Bindings.Bind(DateSelection).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter());
				Bindings.Bind(_datepicker).For(x => x.Date).To(vm => vm.Date).WithConversion(new DateToNSDateConverter());
				Bindings.Bind(spareHightlight).For(x => x.Text).To(vm => vm.Highlight);
                //Bindings.Bind(postButton).To(vm => vm.LogHoursCommand);
                //Bindings.Bind(UploadedImage).To(vm => vm.Bytes).WithConversion("InMemoryImage").Apply();
              
                //Bindings.Bind(UploadedImage).To(vm => vm.PhotoUrl).WithConversion(new UriToImageConverter());
				//Bindings.Bind(highlight).For(x => x.Text).To(vm => vm.Highlight);
                //TODO: Probably uncomment this
				//postButton.Enabled = true;


			}
            else
			{
				ViewModel.Date = DateTime.Today;
                //Bindings.Bind(button).To(vm => vm.BackCommand);
				Bindings.Bind(metricLabel).For(x => x.Text).To(vm => vm.NumberMetricLabel);
				Bindings.Bind(OrganisationLabel).For(x => x.Text).To(vm => vm.OrganisationRequired);
				Bindings.Bind(waiting).For(x => x.Hidden).To(vm => vm.InFlight).WithConversion(new InverseConverter());
				Bindings.Bind(Overlay).For(x => x.Hidden).To(vm => vm.InFlight).WithConversion(new InverseConverter());
				Bindings.Bind(unit).For(x => x.Text).To(vm => vm.ContributionAmount).WithConversion(new DoubleCantBe0ToStringConverter());
				Bindings.Bind(orgsPickerModel).For(x => x.ItemsSource).To(vm => vm.Organisations);
				//Bindings.Bind(orgsPickerModel).For(x => x.SelectedItem).To(vm => vm.Organisation);
				Bindings.Bind(OrganisationSelection).For(x => x.Text).To(vm => vm.Organisation.Name);
				Bindings.Bind(DateSelection).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter());
				Bindings.Bind(_datepicker).For(x => x.Date).To(vm => vm.Date).WithConversion(new DateToNSDateConverter());
				Bindings.Bind(spareHightlight).For(x => x.Text).To(vm => vm.Highlight);

                if(!LogPost.imageChanged){
				Bindings.Bind(UploadedImage).To(vm => vm.Bytes).WithConversion("InMemoryImage");
				//Bindings.Bind(postButton).To(vm => vm.LogHoursCommand);
                }


			}
            if ((ViewModel.IsEditing || LogPost.isEditing) && !LogPost.imageChanged)
            {

				Bindings.Bind(UploadedImage).To(vm => vm.PhotoUrl).WithConversion(new UriToImageConverter());
            
            }

            if(LogPost.imageChanged){

                Bindings.Bind(UploadedImage).To(vm => vm.Bytes).WithConversion("InMemoryImage");
            }

			Bindings.Bind(highlight).For(x => x.Text).To(vm => vm.Highlight);

			Bindings.Bind(surveyLabel).For(x => x.Text).To(vm => vm.CompanyName);

			Bindings.Apply();

			DateSelection.TouchUpInside += (sender, e) =>
			{
				ShowPicker(_datepicker);
			};

			/*UITapGestureRecognizer tap1 = new UITapGestureRecognizer(onSingleTap);

			UITapGestureRecognizer tap2 = new UITapGestureRecognizer(onDoubleTap);


			tap2.NumberOfTapsRequired = 2;

			var dummieView = new UIView(this.unit.Frame);

			dummieView.BackgroundColor = UIColor.FromRGBA((nfloat)1.0, (nfloat)0.0, (nfloat)0.0, (nfloat)0.25);
			dummieView.Hidden = true;
			this.View.AddSubview(dummieView);

			dummieView.AddGestureRecognizer(tap1);

			dummieView.AddGestureRecognizer(tap2);*/

			/*UITapGestureRecognizer highlightTapRecognizer = new UITapGestureRecognizer(() =>
		   {


			   Debug.WriteLine("INSIDE UITapGestureRecognizer");
			   if (highlight.Text.Trim().Equals("Add a description"))
			   {

				   highlight.Text = "";

			   }
			   //this.highlight.BecomeFirstResponder();

			  
		   });

			highlight.AddGestureRecognizer(highlightTapRecognizer);*/

			ViewModel.ForPropertyChange(x => x.IsEditing, y =>
			{
			Debug.WriteLine("CREATING CLICK EVENT IN LOG POST");



			if (y)
			{
				this.NavigationBarSetUp();

				Bindings.Bind(button).To(vm => vm.CancelCommand).Apply();



			}
			else
			{
				this.NavigationBarSetUp();

				}

			});

			ViewModel.ForPropertyChange(x => x.Alert, y => {

				if(y){

					Debug.WriteLine("ALERT FIRED");
					this.displaeyErrorAlert();
				}
			
			});
					

			ViewModel.ForPropertyChange(x => x.Highlight, y =>
			{
				
				if (ViewModel.IsEditing)
				{	
					//this.RemoveConstraints();

					LogPost.highlight = y;

					//highlight.Text = LogPost.highlight;
				}
			});

			ViewModel.ForPropertyChange(x => x.RemoveConstraints, y =>
			{
				Debug.WriteLine("ISDELETING HAS CHANGED "+ViewModel.RemoveConstraints);
				//Bindings.Bind(postButton).To(vm => vm.UpdateLogCommand).Apply();
				if (ViewModel.RemoveConstraints.Equals("remove"))
				{

					//this.RemoveConstraints();

					this.removeConstraintsUpdate();

				}

			});

			ViewModel.ForPropertyChange(x => x.Organisation, y =>
			{
				Debug.WriteLine("LOGPOST CONTROLLER " + ViewModel.Highlight);
				if (ViewModel.IsEditing)
				{if (ViewModel.Organisation != null)
					{
						OrganisationSelection.Text = ViewModel.Organisation.Name;

					}
				}
			});


            ViewModel.ForPropertyChange(x => x.CompanyName, y => {

                Debug.WriteLine("CompanyName Changed in view controller "+y);

                //this.surveyLabel.Text = y;

                surveyLabel.SizeToFit();

            });




			ViewModel.ForPropertyChange(x => x.Bytes, y =>
			{
                this.NavigationBarSetUp();
				

                  //Bindings.Bind(UploadedImage).To(vm => vm.Bytes).WithConversion("InMemoryImage").Apply();

              
				
			});

			this.StyleElements();

			this.RemoveConstraints();
			/*if (!string.IsNullOrEmpty(LogPost.highlight)) {

				this.highlight.Text = LogPost.highlight;
			
			}*/
		}
		//Display error alert
		private void displaeyErrorAlert(){

			//Create Alert
			var okAlertController = UIAlertController.Create("Error", ViewModel.AlertMessage, UIAlertControllerStyle.Alert);

			//Add Action
			okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

			// Present Alert
			PresentViewController(okAlertController, true, null);

		}

		private void removeConstraintsUpdate() {

			if (ViewModel.Bytes == null || ViewModel.Bytes.Length == 0)
			{
				Debug.WriteLine("NUll photo");
				NSLayoutConstraint[] constraints = new NSLayoutConstraint[1];
				/*foreach (NSLayoutConstraint constraint in highlight.Constraints) {

					Debug.WriteLine("CONSTRAINT: "+constraint.Identifier()+" VALUE: "+constraint.Constant);

				}*/

				this.UploadedImage.RemoveFromSuperview();

				NSLayoutConstraint alingY = NSLayoutConstraint.Create(highlight, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

				constraints[0] = alingY;

				NSLayoutConstraint.ActivateConstraints(constraints);


			}
			else {

				UITapGestureRecognizer photoTapped = new UITapGestureRecognizer(() =>
				{
					Debug.WriteLine("PHOTO TAPPED");
					ViewModel.NavigatePickPhoto();

				});

				this.UploadedImage.AddGestureRecognizer(photoTapped);

				this.UploadedImage.UserInteractionEnabled = true;
			
			}


			if (LogPost.goal != null)
			{
				if (LogPost.goal.MetricName == null || LogPost.goal.MetricName.Equals("") || LogPost.goal.MetricName.ToLower().Equals("none") || LogPost.goal.MetricName.ToLower().Equals("posts"))
				{
					NSLayoutConstraint[] constraints = new NSLayoutConstraint[2];

					metricLabel.RemoveFromSuperview();

					unit.RemoveFromSuperview();

					NSLayoutConstraint alingDateLabel = NSLayoutConstraint.Create(dateLabel, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

					NSLayoutConstraint alingDateText = NSLayoutConstraint.Create(DateSelection, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

					constraints[0] = alingDateLabel;

					constraints[1] = alingDateText;

					NSLayoutConstraint.ActivateConstraints(constraints);

					this.contributionLabel.RemoveFromSuperview();

					UIView view = this.topHeader;

					topHeader.Frame = new CGRect(topHeader.Bounds.X, topHeader.Bounds.Y, topHeader.Bounds.Width, topHeader.Bounds.Height - 21);
				}
			}
		
		}

		/*[Export("textViewDidChange:")]
		public void MyTextViewChanged(UITextView textView)
		{
			if (textView.Text != null && !textView.Text.Equals("Add a description"))
			{
				LogPost.highlight = textView.Text;

				Debug.WriteLine("NEW VALUE FOR  SPARE "+LogPost.highlight);
			}
		}*/

		/*[Export("textViewDidBeginEditing:")]
		public void TextViewDidBeginEditing(UITextView textView)
		{
			Debug.WriteLine("Text started editing");


		}*/
		/*
		[Export("textViewDidChangeSelection:")]
		private void textViewDidChangeSelection(UITextView textView)
		{
			Debug.WriteLine("ChangeSelection");

			Debug.WriteLine("Selected Range: " + highlight.SelectedRange.Location+" LENGTH: "+highlight.SelectedRange.Length);

			if (highlight.SelectedRange.Length > 0) {

				NSRange range = new NSRange();

				range.Length = 0;
				if (highlight.Text.Length>0)
				{
					range.Location = highlight.Text.Length;

					highlight.SelectedRange = range;
				}
			
			}

		}

		[Export("textView:shouldChangeTextInRange:replacementText:")]
		private void ShouldChangeTextIn(UITextView textView, NSRange range, string replacementText) {

			Debug.WriteLine("ShouldChangeTextIn"+replacementText);

			if (replacementText.Equals("\n"))
			{

				this.highlight.ResignFirstResponder();

			}
			else if (replacementText == "")
			{

				Debug.WriteLine("Backspace pressed");

				if (!string.IsNullOrEmpty(this.highlight.Text))
				{

					if (this.highlight.SelectedRange.Location == this.highlight.Text.Length)
					{

						this.highlight.Text = this.highlight.Text.Substring(0, this.highlight.Text.Length - 1);

					}else if(this.highlight.Text.Length > 1 && this.highlight.SelectedRange.Location!=0){

						int location = (int)highlight.SelectedRange.Location;
						string partialStartString = this.highlight.Text.Substring(0,(int) this.highlight.SelectedRange.Location -1);

						string partialFinalString = this.highlight.Text.Substring((int)this.highlight.SelectedRange.Location, this.highlight.Text.Length - (int)this.highlight.SelectedRange.Location);


						Debug.WriteLine("PARTIAL STRING VALUE "+partialStartString+", FINAL STRING: "+partialFinalString);

						this.highlight.Text = partialStartString + partialFinalString;

						NSRange rangeV = new NSRange();


						rangeV.Location = location - 1;

						rangeV.Length = 0;

						this.highlight.SelectedRange = rangeV;
					}
				}

			}
			else {
				//TODO: If text in highlight is not updates, uncomment this out

				string partialText = this.highlight.Text;

				bool updated = false;

				Debug.WriteLine("PARTIAL TEXT VALUE: "+partialText);

				string partialTextEnd = "";

				int location = (int)highlight.SelectedRange.Location;

				if (!string.IsNullOrEmpty(partialText)) { 
				
					//highlight.SelectedRange = new NSRange(0, partialText.Length);
				
				}

				string partialTextStart = partialText.Substring(0, (int)highlight.SelectedRange.Location);
				if (partialText.Length > 1 && (highlight.SelectedRange.Location < partialText.Length - 2))
				{
					int lastPosition = highlight.Text.Length;

					Debug.WriteLine("INITIAL POSITION: " + (int)highlight.SelectedRange.Location + ", FINAL POSITION: " + partialText.Count());
					Debug.WriteLine("LAST POSITION: " + lastPosition);
					partialTextEnd = highlight.Text.Substring((int)highlight.SelectedRange.Location, lastPosition - partialTextStart.Length);
					updated = true;
				
				}


				partialTextStart = partialTextStart + replacementText;

				Debug.WriteLine("PartialString Start " + partialTextStart);
				this.highlight.Text = partialTextStart+partialTextEnd;
				if (updated) { 
				
					NSRange rangeV = new NSRange();


					rangeV.Location = location+1;

					rangeV.Length = 0;

					this.highlight.SelectedRange = rangeV;
				
				}

				//this.highlight.Text = this.highlight.Text + replacementText;
				//highlight.SelectedRange = new NSRange(0, 0);
				LogPost.highlight = textView.Text;
			
			}
		}*/




		//Remove Constraints

		private void RemoveConstraints()
		{

			//No Photo

			//TODO: Remove this
			if (LogPost.action.Equals("add"))
			{
				Debug.WriteLine("REMOVING CONSTRAINTS");
				if (LogPost.image == null)
				{Debug.WriteLine("IMAGE IS NULL");
					NSLayoutConstraint[] constraints = new NSLayoutConstraint[1];
					/*foreach (NSLayoutConstraint constraint in highlight.Constraints) {

						Debug.WriteLine("CONSTRAINT: "+constraint.Identifier()+" VALUE: "+constraint.Constant);

					}*/

					this.UploadedImage.RemoveFromSuperview();

					NSLayoutConstraint alingY = NSLayoutConstraint.Create(highlight, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

					constraints[0] = alingY;

					NSLayoutConstraint.ActivateConstraints(constraints);


				}



				if (LogPost.goal != null)
				{
					if (LogPost.goal.MetricName == null || LogPost.goal.MetricName.Equals("") || LogPost.goal.MetricName.ToLower().Equals("none") || LogPost.goal.MetricName.ToLower().Equals("posts"))
					{
						NSLayoutConstraint[] constraints = new NSLayoutConstraint[2];

						metricLabel.RemoveFromSuperview();

						unit.RemoveFromSuperview();

						NSLayoutConstraint alingDateLabel = NSLayoutConstraint.Create(dateLabel, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

						NSLayoutConstraint alingDateText = NSLayoutConstraint.Create(DateSelection, NSLayoutAttribute.LeftMargin, NSLayoutRelation.Equal, tellusaboutLabel, NSLayoutAttribute.LeftMargin, 1, 1);

						constraints[0] = alingDateLabel;

						constraints[1] = alingDateText;

						NSLayoutConstraint.ActivateConstraints(constraints);

						this.contributionLabel.RemoveFromSuperview();

						UIView view = this.topHeader;

						topHeader.Frame = new CGRect(topHeader.Bounds.X, topHeader.Bounds.Y, topHeader.Bounds.Width, topHeader.Bounds.Height - 21);

						ViewModel.MetricRequired = false;
					}
				}


			}

		}



		private UIDatePicker BuildDatePicker()
		{
			NSDate maximunDate = new NSDate();


			var dp = new UIDatePicker();
			dp.MaximumDate = maximunDate;
			dp.Mode = UIDatePickerMode.Date;
			dp.TintColor = PorpoiseColors.Turquoise;
			dp.BackgroundColor = UIColor.White;
			dp.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			//if (ViewModel.IsEditing)
			//{
			//	dp.Date = Extensions.DateTimeToNSDate(ViewModel.Date);
			//}

			var toolbar = CreateToolBar();

			//create "done" button for toolbar and update textfield with selectedItem
			UIBarButtonItem doneButton = new UIBarButtonItem(Resource.Done, UIBarButtonItemStyle.Done, (sender, e) =>
			{
				DateSelection.ResignFirstResponder();
				var dateString = dp.Date.ToString();
				var formatted = DateTime.Parse(dateString);
				DateSelection.Text = formatted.ToString("dddd, MMMM, dd, yyyy");
				this.ViewModel.Date = formatted;
				_datepicker.Date = (Foundation.NSDate)this.ViewModel.Date;
			});
			doneButton.TintColor = PorpoiseColors.Turquoise;

			UIBarButtonItem cancelButton = new UIBarButtonItem(Resource.Cancel, UIBarButtonItemStyle.Plain, (sender, e) =>
			{
				DateSelection.ResignFirstResponder();

			});

			//add space between the 2 buttons so the Cancel button can be on the right
			var flexspace = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null, null);

			toolbar.SetItems(new UIBarButtonItem[] { cancelButton, flexspace, doneButton }, true);
			DateSelection.InputAccessoryView = toolbar;
			return dp;
		}
		
		void NavigationBarSetUp()
		{
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
			

			Bindings.Bind(postButton).To(vm => vm.LogHoursCommand).Apply();


			this.button = UIButton.FromType(UIButtonType.Custom);

			if (ViewModel.IsEditing)
			{

                if(scale >= 2){
                    next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Cancel%402x.png");

                }
                else{

					next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Cancel.png");

                }
				

			}
			else
			{

                if(scale >= 2){
                    next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Back%402x.png");


                }
                else{

                    next = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/back.png");
                }

				
				button.TouchDown += (sender, e) =>{

					this.ViewModel.Back();
};
			}


            button.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(next, (nfloat)(this.NavigationController.NavigationBar.Bounds.Height * .5)), this.NavigationController.NavigationBar.Bounds.Height * .5);

			button.SetBackgroundImage(next, UIControlState.Normal);

			if (!ViewModel.IsEditing)
			{
                if(scale >= 2){

					post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Post%402x.png");

					
				
                }else{

                    post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Post.png");

                }
				postButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(post, (nfloat)(button.Bounds.Height)), button.Bounds.Height);

                postButton.SetBackgroundImage(post, UIControlState.Normal);

			}
			else
			{

                if(scale >= 2){
                    
                    post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Update2.png");

                }
                else{

                    post = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Update.png");

                }


				//post.Scale(next.Size);
				//postButton.Frame = new CGRect(0, 15, post.Size.Width, next.Size.Height * 0.7);
				//postButton.ImageEdgeInsets = new UIEdgeInsets(0, postButton.TitleLabel.Frame.Size.Width, 0, -postButton.TitleLabel.Frame.Size.Width);
				//postButton.SizeToFit();
				//postButton.ContentEdgeInsets = new UIEdgeInsets(0, 0, 15, 0);


				//this.View.AddConstraint(constraint);
                postButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(post, (nfloat)(button.Bounds.Height * .7)), button.Bounds.Height*.8);

                postButton.SetImage(post, UIControlState.Normal);

                postButton.ImageEdgeInsets = new UIEdgeInsets((System.nfloat)2.5, 0, 0, 0);

               //postButton.ContentEdgeInsets = new UIEdgeInsets(0, 10, 0, 0);
				
			}


			
            UIBarButtonItem barButtonRightTwo = new UIBarButtonItem(postButton);
			UIBarButtonItem barButtonRightOne = new UIBarButtonItem(button);

            foreach(NSLayoutConstraint constraint in button.Constraints){

                Debug.WriteLine("BUTTON "+constraint.Description+" "+constraint.Constant);

            }

            rightButtons[0] = barButtonRightTwo;
			rightButtons[1] =barButtonRightOne;
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

			NavigationItem.SetRightBarButtonItems(rightButtons, true);



			//NavigationItem.RightBarButtonItem.Title = Resource.Logout;

			//NavigationItem.RightBarButtonItem.Image = new UIImage("logout.png");

			UIImage leftImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/por-logo.png");

			UIButton leftButton = UIButton.FromType(UIButtonType.Custom);

			leftButton.UserInteractionEnabled = false;

			leftButton.Bounds = new CGRect(0, 0, Services.PorpoiseImage.getAppropriateWidth(leftImage, (nfloat)(NavigationController.NavigationBar.Bounds.Height * 0.6)), NavigationController.NavigationBar.Bounds.Height * 0.6);

			leftButton.SetImage(leftImage, UIControlState.Normal);

			UIBarButtonItem leftButtonBar = new UIBarButtonItem(leftButton);
			//leftButton.TintColor = UIColor.Black;
			NavigationItem.SetLeftBarButtonItem(leftButtonBar, true);


		}

		void AddNewOrg(UITextField alertInput, UITextField selectedOrganisationTextfield, MvxPickerViewModel model)
		{

			if (!string.IsNullOrEmpty(alertInput.Text))
			{
				this.ViewModel.Organisation = new Organisation
				{
					Id = new Guid(),
					Name = alertInput.Text
				};
				selectedOrganisationTextfield.Text = alertInput.Text;
				model.SelectedItem = this.ViewModel.Organisation;
			}
			else
			{
				selectedOrganisationTextfield.Text = (model.SelectedItem as Organisation).Name;
			}


		}

		static UIToolbar CreateToolBar()
		{
			var toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Black;
			toolbar.Translucent = true;
			toolbar.TintColor = PorpoiseColors.Turquoise;
			toolbar.BarTintColor = PorpoiseColors.Grey;
			toolbar.SizeToFit();
			return toolbar;
		}

		private void SetUpPickerToolbar(UITextField txtField, UIPickerView pickerView, MvxPickerViewModel model)
		{
			UIToolbar toolbar = CreateToolBar();

			//create "done" button for toolbar and update textfield with selectedItem
			UIBarButtonItem doneButton = new UIBarButtonItem(Resource.Done, UIBarButtonItemStyle.Done, (sender, e) =>
			{
				Debug.WriteLine("Done Clicked");
				txtField.ResignFirstResponder();
				//if user opens the picker for the first time, the first item is selected by default but when hitting done, it doesn't register as selected so force it to be.
				if (model.SelectedItem == null)
				{
					model.Selected(pickerView, 0, 0);
				}
				if (model.SelectedItem != null)
				{
					switch (pickerView.Tag)
					{
						case (ORG_PICKER_TAG):
							//if user selects "Other", show dialog to enter organisation name
							if (string.Equals((model.SelectedItem as Organisation).Name, Resources.Other))
							{
								var alert = UIAlertController.Create(Resource.NewOrganization, Resource.NewOrganizationMessage, UIAlertControllerStyle.Alert);
								alert.AddTextField(input =>
								{
									AddNewOrg(input, txtField, model);
									pickerView.ReloadComponent(0);
								});
								alert.AddAction(UIAlertAction.Create(Resource.Save, UIAlertActionStyle.Default, x =>
								{
									if (string.IsNullOrEmpty(alert.TextFields[0].Text))
									{
										this.PresentViewController(alert, true, null);
									}
									else
									{
										AddNewOrg(alert.TextFields[0], txtField, model);
										pickerView.ReloadComponent(0);
									}

								}));
								alert.AddAction(UIAlertAction.Create(Resource.Cancel, UIAlertActionStyle.Cancel, x =>
								{
									ViewModel.RaisePropertyChanged(() => ViewModel.Organisations);
									pickerView.ReloadComponent(0);
								}));

								this.PresentViewController(alert, true, null);
							}
							else {

								ViewModel.Organisation = model.SelectedItem as Organisation;

								Debug.WriteLine("SELECTED ITEM "+ViewModel.Organisation.Name);

								//OrganisationSelection.Text = (model.SelectedItem as Organisation).Name;
							
							}
							break;
						

					}

					pickerView.ReloadComponent(0);
				}

			});
			doneButton.TintColor = PorpoiseColors.Turquoise;

			//cancel button to close toolbar and take no action
			UIBarButtonItem cancelButton = new UIBarButtonItem(Resource.Cancel, UIBarButtonItemStyle.Plain, (sender, e) =>
			{
				//if user opens picker and hasn't selected an item yet and hits cancel, leave the textfield blank
				if (string.IsNullOrEmpty(txtField.Text))
				{
					switch (pickerView.Tag)
					{
						case (ORG_PICKER_TAG):
							ViewModel.RaisePropertyChanged(() => ViewModel.Organisation);
							break;
						

					}

					model.SelectedItem = null;
					model.SelectedChangedCommand?.Execute(null);
				}

				txtField.ResignFirstResponder();
				pickerView.ReloadComponent(0);
			});

			//add space between the 2 buttons so the Cancel button can be on the right
			var flexspace = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null, null);

			toolbar.SetItems(new UIBarButtonItem[] { cancelButton, flexspace, doneButton }, true);
			txtField.InputAccessoryView = toolbar;

		}



		UIView currentPicker;
		public void ShowPicker(UIView picker)
		{

			if (currentPicker != null)
			{
				currentPicker.Hidden = true;
			}
			currentPicker.Hidden = false;
			currentPicker = picker;
		}

		static UIPickerView BuildOrganisationPicker()
		{
			var _orgPicker = new UIPickerView();
			_orgPicker.TintColor = PorpoiseColors.Turquoise;
			_orgPicker.BackgroundColor = UIColor.White;
			_orgPicker.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			return _orgPicker;
		}

		void SetupFieldValidation()

		{ 
		
			/*ViewModel.ForPropertyChange(x => x.Organisation, y =>
		{
			OrganisationSelection.RightViewMode = (_orgPicker.Model as MvxPickerViewModel).SelectedItem != null && !string.IsNullOrEmpty(OrganisationSelection.Text) && !string.Equals(OrganisationSelection.Text, Resources.Other) ? UITextFieldViewMode.Never : UITextFieldViewMode.Always;
			OrganisationSelection.ColoredBorder((_orgPicker.Model as MvxPickerViewModel).SelectedItem != null && OrganisationSelection.Text != string.Empty && !string.Equals(OrganisationSelection.Text, Resources.Other) ? UIColor.White.CGColor : PorpoiseColors.LightErrorRed.CGColor);
		});*/

		}



		 public async Task<MvxPickerViewModel> SetupOrganisationsPickerModel(UIPickerView pickerview)
		{

			await this.ViewModel.GetOrganisations();

			var orgsPickerModel = new MvxPickerViewModel(pickerview);
			if (ViewModel.Organisations != null)
			{
				//Debug.WriteLine("ORGANISATIONS LENGTH INSIDE MvxPickerViewModel: " + ViewModel.Organisations.Count);
			}
			else { 
			
				Debug.WriteLine("ORGANISATIONS LENGTH INSIDE MvxPickerViewModel: 0");


			}

			orgsPickerModel.ItemsSource = ViewModel.Organisations;

			orgsPickerModel.SelectedItem = ViewModel.Organisation;
			pickerview.Model = orgsPickerModel;
			pickerview.ShowSelectionIndicator = true;
			pickerview.TintColor = PorpoiseColors.Turquoise;
			return orgsPickerModel;
		}

		void  StyleElements()
		{

			//((PorpoiseEditText)DateSelection).Bordered = true;
			//DateSelection.BackgroundColor = UIColor.Clear;
			this.firstLine.BackgroundColor = PorpoiseColors.FromHex(0xF6BFBF);
			this.secondLine.BackgroundColor = PorpoiseColors.FromHex(0xAECCDC);
			this.thirdLine.BackgroundColor = PorpoiseColors.FromHex(0x89C972);
			//TODO: Suggested words
			//this.highlight.AutocorrectionType = UITextAutocorrectionType.No;
			DateSelection.TextColor = UIColor.Black;
			//DateSelection.Text = "";

			((PorpoiseEditText)OrganisationSelection).Bordered = true;
			OrganisationSelection.BackgroundColor = UIColor.Clear;
			OrganisationSelection.TextColor = UIColor.Black;

			this.unit.BackgroundColor = PorpoiseColors.LightGrey;

			this.DateSelection.BackgroundColor = PorpoiseColors.LightGrey;


			highlight.TextColor = UIColor.LightGray;

			//Max Date Date Picker
			_datepicker.MaximumDate = NSDate.Now;

			//Min date Date Picker
			NSDate minDate = NSDate.Now;

			NSCalendar calendar = new NSCalendar(NSCalendarType.Gregorian);

			NSDateComponents offsetComponents = new NSDateComponents();

			offsetComponents.Year = -1;

			NSDate minimumDate = calendar.DateByAddingComponents(offsetComponents, minDate, NSCalendarOptions.None);

			_datepicker.MinimumDate = minimumDate;

			//surveyLabel.Text = "Allow "+AccountInfo.CompanyName+" to share to their social accounts?";

			//surveyLabel.resizeLabel();
			if (ViewModel.IsEditing)
			{
				OrganisationSelection.Placeholder = "+ Select an organization";
				if (ViewModel.Organisation != null)
				{
					OrganisationSelection.Text = ViewModel.Organisation.Name;
				}
		


			}

			this.highlight.ShouldChangeText = (text, range, replacementString) =>
{
	if (replacementString.Equals("\n"))
	{
        this.highlight.EndEditing(true);
		return false;
	}
	else
	{
		return true;
	}
};
		}
    }



}