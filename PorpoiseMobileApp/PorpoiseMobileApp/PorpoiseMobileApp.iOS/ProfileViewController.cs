using System;
using Foundation;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Converters;
using Syncfusion.SfGauge.iOS;
using CoreGraphics;
using System.Linq;
using System.Diagnostics;
using PorpoiseMobileApp.Client;
using System.Globalization;
using System.Collections.Generic;

namespace PorpoiseMobileApp.iOS
{

	public partial class ProfileViewController : MvvmViewController<ProfileViewModel>
	{

		UIGestureRecognizer goalTap;
		public ProfileViewController(IntPtr handle) : base(handle)
		{

		}
		private UIView ChartView = null;

        private UIView addPostView;

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
			gaugeCount = 0;
			goalTap = null;
			currentFrame = null;

			foreach (var sv in GoalsScrollView.Subviews)
			{
				sv.RemoveFromSuperview();
			}
		}

		private IList<nint> tags;

		public override  void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
            foreach (NSLayoutConstraint constraint in this.lblHourAmount.Constraints)
			{

				Debug.WriteLine("CLOCK ICON CONSTRAINT: " + constraint.Description + "-" + constraint.Constant);

			}
            this.lblHourAmount.Frame = new CGRect(this.lblHourAmount.Bounds.X, this.ProfilePicture.Bounds.Y + this.ProfilePicture.Bounds.Height,this.lblHourAmount.Bounds.Width, this.lblHourAmount.Bounds.Height);
            this.lblHourAmount.TextAlignment = UITextAlignment.Center;
            UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

			this.NavigationBarSetUp();
			InvokeOnMainThread(() =>
			{
				ViewModel.LoadDetails();
			});

			LatestPostTableView.Hidden = true;
			RightArrow.Hidden = true;
			LeftArrow.Hidden = true;

		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			UIApplication.SharedApplication.StatusBarHidden = false;
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
			LatestPostTableView.Hidden = false;
			GoalsScrollViewSize = new CGSize(GoalsScrollView.Frame.Width, this.GoalsScrollView.Frame.Height);

			if (this.TabBarController.SelectedIndex == 4)
			{

				ViewModel.InFlight = true;

				Debug.WriteLine("Presenting Intercom");

				this.TabBarController.SelectedIndex = 0;

				var dict = new NSDictionary("email", AccountInfo.Email, "name", AccountInfo.Email);


				Intercom.UpdateUserWithAttributes(dict);



				Intercom.PresentMessenger();

				ViewModel.InFlight = false;

			}


			if (this.LatestPostTableView != null)
			{

				Debug.WriteLine("SUBVIEWS " + this.LatestPostTableView.Subviews.Length);

				foreach (UIView view in LatestPostTableView.Subviews)
				{

					Debug.WriteLine(view.ToString());

				}

				Debug.WriteLine("LATEST POST IS NOT NULL");

			}


		}

		/*public override void ViewWillLayoutSubviews() {

			if (float.Parse(UIDevice.CurrentDevice.SystemVersion) > 7) {

				this.View.ClipsToBounds = true;

				CGRect screenRect = UIScreen.MainScreen.Bounds;

				nfloat screenHeight = 0.0f;

				if (UIDeviceOrientation.Portrait.IsPortrait())
				{

					screenHeight = screenRect.Size.Height;

				}
				else { 

					screenHeight = screenRect.Size.Width;
				
				}

				CGRect screenFrame = new CGRect(0, 20, this.View.Frame.Size.Width, screenHeight - 20);

				CGRect viewFr = this.View.ConvertRectToView(this.View.Frame, null);

				if (!CGRect.Equals(screenFrame,viewFr)) {

					this.View.Frame = screenFrame;

					this.View.Bounds = new CGRect(0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height);
				
				}

			}

		}*/

		partial void ChartViewRecognizer(Foundation.NSObject sender)
		{
			UIView view = sender as UIView;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			this.View.BackgroundColor = PorpoiseColors.Turquoise;

			this.EdgesForExtendedLayout = UIRectEdge.None;
			//UNCOMMENT
			NavigationBarSetUp();
			StyleElements();
			View.BringSubviewToFront(Overlay);
			Bindings.Bind(Overlay).For(x => x.Hidden).To(x => x.InFlight).WithConversion(new InverseConverter());
			Bindings.Bind(EmployeeName).For(x => x.Text).To(x => x.Name);
			Bindings.Bind(Location).For(x => x.Text).
			To(x => x.Location);
			Bindings.Bind(ProfilePicture).For(x => x.Image).To(x => x.ProfilePicture).WithConversion(new UriToImageConverter());
            Bindings.Bind(lblHourAmount).For(x => x.Text).To(x => x.TotalHoursGiven).WithConversion(new DoubleToStringConverter());
			//lblHourAmount.TextAlignment = UITextAlignment.Left;
			Bindings.Apply();


			ProfilePicture.Layer.MasksToBounds = false;

			//Layer.BorderColor = UIColor.White.CGColor;

			ProfilePicture.Layer.CornerRadius = ProfilePicture.Frame.Height / 2;

			ProfilePicture.ClipsToBounds = true;

			ViewModel.ForPropertyChange(x => x.IsDeleting, y =>
			{
				Debug.WriteLine("Is Deleting has changed");

				if (y == true)
				{

					this.showDeletePostAlert();

				}

			});

			ViewModel.GoEditLogEvent += (sender, e) =>
			{

				Debug.WriteLine("Is Deleting has changed");
				/*if (!Equals(e.PostId, Guid.Empty))
				{
					ViewModel.LatestPost.Id = e.PostId;
				}*/
			};




			ViewModel.GetEmployeeDetailsEvent += (s, e) =>
				{


					SetUpGoalCharts(e);


				};
			ViewModel.ForPropertyChange(x => x.LatestLogPostList, y =>
				{
				setupLatestPostSource();

					/*var secondViewController = this.Storyboard.InstantiateViewController("ProfileViewController");
					this.PresentViewController(secondViewController, true, null);*/
					if (tags != null)
					{


						for (int i = 0; i < this.ViewModel.CompanyGoals.Count(); i++)
						{

							var goal = this.ViewModel.CompanyGoals.ElementAt(i);

							double percentage = (goal.HoursAgainstGoal / goal.GoalAmount);

							//Check Percentage
							var header = this.View.ViewWithTag(Int32.Parse(((i + 1).ToString()) + "01"));

							//Check if view percentage is not null

							if (header != null)
							{
							
								UILabel headerLabel = (UILabel)header;

								headerLabel.Text = (NSString)percentage.ToString("P0");

							}

						//check individual label

						var individual = this.View.ViewWithTag(Int32.Parse(((i + 1).ToString()) + "03"));

						if (individual != null)
							{

								UILabel individualLabel = (UILabel)individual;

								individualLabel.Text = goal.HoursAgainstGoal.ToString();

							}

							//RangePointer

							var range = this.View.ViewWithTag(Int32.Parse(((i + 1).ToString()) + "02"));

							if (range != null) {

							SFCircularGauge gauge = (SFCircularGauge)range;
								foreach (UIGestureRecognizer gs in gauge.GestureRecognizers) {

									gauge.RemoveGestureRecognizer(gs);
							
							}
										var goalTap = new UITapGestureRecognizer();
										goalTap.CancelsTouchesInView = false;

										var goalDetailsAlert = BuildGoalDetailsAlert(goal);
										goalTap.Delegate = new GoalTapDelegate(() => this.PresentViewController(goalDetailsAlert, true, null));

										
										gauge.ExclusiveTouch = true;
										gauge.UserInteractionEnabled = true;
										gauge.AddGestureRecognizer(goalTap);

							SFCircularScale scale = null;

							foreach (var number in NSArray.FromArray<SFCircularScale>(gauge.Scales))
							{

									scale = number;
							
							}


								if (scale != null) {

									SFRangePointer pointer = null;

								foreach (var number in NSArray.FromArray<SFRangePointer>(scale.Pointers))
							{

									pointer = number;
							
							}

								pointer.Value = (nfloat)goal.HoursAgainstGoal;
				
				if (percentage* 100 >= 100 || percentage* 100 >= 1000)
				{
					pointer.Value = 100;
                    pointer.Color = PorpoiseColors.FromHex(0xF6BD00);
					
				}
				else
				{

                    pointer.Color = PorpoiseColors.FromHex(0x0BB3B9);

				}


							
							}

								
						
							}


						//Check Group Hours

					var group = this.View.ViewWithTag(Int32.Parse(((i + 1).ToString()) + "04"));

							if (group != null) {

								UILabel groupLabel = (UILabel)group;

							groupLabel.Text = goal.GoalAcumulativeTotal.ToString();


						
						}



						}

					}


					
								
				});


		}
		//UIView ChartView;

		void SetUpGoalCharts(SdkEventArgs e)
		{
			if (e.Successful)
			{
				

				InvokeOnMainThread(() =>
						{


							if (this.ViewModel.CompanyGoals != null && this.ViewModel.CompanyGoals.Count > 0)
							{
						if(this.ChartView != null){



									//this.ChartView.RemoveFromSuperview();
				
							}
								tags = new List<nint>();

								var selectedGoals = this.ViewModel.CompanyGoals.Distinct().Where(x => x.Id != null).ToList();
								var chartWidth = 311 / 2;
								var chartHeight = 180;
								this.ChartView = new UIView(new CGRect(0, 0, 311 / 2 * selectedGoals.Count, 180));
								//var yConstraint = NSLayoutConstraint.Create(ChartView, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal);
								//yConstraint.Active = true;
								//ChartView.TranslatesAutoresizingMaskIntoConstraints = false;
								//ChartView.AddConstraint(yConstraint);
								int index = 1;
								foreach (var g in this.ViewModel.CompanyGoals)
								{
									
										Debug.WriteLine("CREATING GESTURE RECOGNIZER");
										goalTap = new UITapGestureRecognizer();
										goalTap.CancelsTouchesInView = false;

										var goalDetailsAlert = BuildGoalDetailsAlert(g);
										goalTap.Delegate = new GoalTapDelegate(() => this.PresentViewController(goalDetailsAlert, true, null));

										var gauge = BuildGaugeChart(ChartView, g, chartWidth, chartHeight, index);
										tags.Add(index);
										index+=1;
										gauge.ExclusiveTouch = true;
										gauge.UserInteractionEnabled = true;
										gauge.AddGestureRecognizer(goalTap);
										//this.LatestPostTableView.AddGestureRecognizer(goalTap);
									

								}

								ChartView.SetNeedsLayout();
								ChartView.LayoutIfNeeded();
								GoalsScrollView.AddSubview(ChartView);
								GoalsScrollView.ContentSize = new CGSize(ChartView.Frame.Width, GoalsScrollViewSize.Height);
								GoalsScrollView.SetNeedsLayout();
								GoalsScrollView.LayoutIfNeeded();
								GoalsScrollView.BringSubviewToFront(ChartView);

							}
						});

				//64f because that is what the trailing (32) and leading (32) space between the Goals ScrollView and the SuperView
				var minWidth = this.View.Frame.Width - 64f;
				var maxWdith = this.View.Frame.Width;
				if (GoalsScrollView.ContentSize.Width >= minWidth && GoalsScrollView.ContentSize.Width <= maxWdith)
				{
					RightArrow.Hidden = true;
					LeftArrow.Hidden = true;
				}
				else
				{
					RightArrow.Hidden = false;
					LeftArrow.Hidden = false;
				}


			}
			else
			{
				this.Alert(UIAlertActionStyle.Default, Resource.Error, e.Message, null, null);
			}
		}



		void logout()
		{

			ViewModel.Logout();

		}
		void NavigationBarSetUp()
		{
			if (this.NavigationController != null)
			{
				//TODO: figure out how to make the status bar opaque.


				this.NavigationController.NavigationBar.BarStyle = UIBarStyle.BlackOpaque;
				this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
				this.NavigationController.NavigationBar.ShadowImage = new UIImage();
				this.NavigationController.NavigationBar.BackgroundColor = PorpoiseColors.Turquoise;
			}



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

			UIButton rigthButton = UIButton.FromType(UIButtonType.Custom);

			rigthButton.Center = this.View.Center;

            //Image

            UIImage logout = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/logout%402x.png");

			rigthButton.Frame = new CGRect(0, 15, buttonWidth, buttonHeight + 10);

			rigthButton.SetImage(logout, UIControlState.Normal);

			rigthButton.ImageEdgeInsets = new UIEdgeInsets(0, 15, 0, 10);

			rigthButton.ContentEdgeInsets = new UIEdgeInsets(0, 0, 15, 0);

			rigthButton.SetTitle(Resource.Logout, UIControlState.Normal);

			rigthButton.TitleEdgeInsets = new UIEdgeInsets(textTop, -logout.Size.Width, textBottom, 0.0f);

			rigthButton.TitleLabel.Font = UIFont.FromName("Ubuntu-Light", 15f);

			rigthButton.TouchUpInside += delegate
			{
				var user = NSUserDefaults.StandardUserDefaults;

				user.SetBool(true, "logged");

				ViewModel.Logout();

			};

			NavigationItem.RightBarButtonItem = new UIBarButtonItem(rigthButton);


			//NavigationItem.RightBarButtonItem.Title = Resource.Logout;

			//NavigationItem.RightBarButtonItem.Image = new UIImage("logout.png");

			UIImage post = new UIImage("logo.png");


			UIButton leftButton = UIButton.FromType(UIButtonType.Custom);

			leftButton.UserInteractionEnabled = false;

			leftButton.Bounds = new CGRect(0, 0, post.Size.Width, post.Size.Height);

			//leftButton.Frame = new CGRect(0, 0, 30, 30);

			leftButton.SetImage(post, UIControlState.Normal);

			leftButton.SetImage(post, UIControlState.Disabled);

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem(leftButton);

			UILabel label = new UILabel();

			NavigationItem.LeftBarButtonItem.CustomView.Subviews.Append(label);


			NavigationItem.Title = "Porpoise";

		}


		void setupLatestPostSource()
		{

			var postSource = new ActivityTableSource(ViewModel.LatestLogPostList, LatestPostTableView, null, this);

			//Debug.WriteLine("Latest Post List Size "+ViewModel.LatestLogPostList.Count);

			LatestPostTableView.Source = postSource;
			LatestPostTableView.SeparatorInset = UIEdgeInsets.Zero;
			LatestPostTableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			if (ViewModel.LatestLogPostList.Count > 0)
			{
				Bindings.Bind(postSource).For(x => x.ItemsSource).To(x => x.LatestLogPostList);
				Bindings.Apply();
			}
			LatestPostTableView.EstimatedRowHeight = 120f;
			LatestPostTableView.RowHeight = UITableView.AutomaticDimension;
			LatestPostTableView.SetNeedsLayout();
			LatestPostTableView.LayoutIfNeeded();

		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		CGRect? currentFrame;
		CGSize GoalsScrollViewSize;
		int gaugeCount = 0;

		SFCircularGauge BuildGaugeChart(UIView ChartView, Goal goal, nfloat chartWidth, nfloat chartHeight, nint tag)
		{
			
			var gauge = new SFCircularGauge();
			gauge.Tag = tag;
			var scale = new SFCircularScale();
			NSMutableArray scales = new NSMutableArray();
			scale = new SFCircularScale();
			//scale.StartValue = 0.5f;

			scale.Interval = 1;
			scale.StartAngle = 180;

			scale.SweepAngle = 360+180;
			scale.RimWidth = 5;
			//scale.ShowTicks = true;
			scale.ShowLabels = false;
            //scale.RimColor = PorpoiseColors.Orange;
           
            //scale.LabelColor = PorpoiseColors.Orange;
			scale.LabelOffset = 0.2f;
			NSMutableArray pointers = new NSMutableArray();


		
			if (!currentFrame.HasValue)
			{
				gauge.Frame = new CGRect(0f, 0f, chartWidth, chartHeight - 92);
			}
			else
			{
				gauge.Frame = new CGRect(currentFrame.Value.GetMaxX(), 0f, chartWidth, chartHeight - 92);
			}

			if (!currentFrame.HasValue)
			{
				gauge.Frame = new CGRect(0f, 12, chartWidth, chartHeight - 92);
			}
			else
			{
				gauge.Frame = new CGRect(currentFrame.Value.GetMaxX(), 12, chartWidth, chartHeight - 92);
			}
			//Goal Metric
			var goalMetric = new UILabel(new CGRect(gauge.Frame.X, gauge.Frame.Height + 15, chartWidth, 10));
			goalMetric.TextColor = PorpoiseColors.FromHex(0x363535);
			var goalName = new UILabel(new CGRect(gauge.Frame.X, gauge.Frame.Height+22, chartWidth, 20));
			var goalHours = new UILabel(new CGRect(gauge.Frame.X, 0, chartWidth, 20));
			if (goal.GoalAmount > 0)
            {   

                scale.RimColor = PorpoiseColors.Grey;
                scale.EndValue = (nfloat)goal.GoalAmount;
				var rangePointer = new SFRangePointer();
				gauge.Tag = Int32.Parse(tag.ToString()+"02");
				
				//Bindings.Bind(rangePointer).For(x => x.Value).To(((nfloat)goal.HoursAgainstGoal).ToString()).WithConversion(new RangePointerConverter(goal)).Apply();
				rangePointer.Width = 5;

				

                double percentage = 0;

                if(goal.GoalType.ToLower().Equals("individual")){

                 percentage = (goal.HoursAgainstGoal / goal.GoalAmount);

                    rangePointer.Value = (nfloat)goal.HoursAgainstGoal;

                }
                else{

                    percentage = (goal.GoalAcumulativeTotal / goal.GoalAmount);

                    rangePointer.Value = (nfloat)goal.GoalAcumulativeTotal;
                }

                pointers.Add(rangePointer);
				
				if (percentage * 100 >= 100 || percentage * 100 >= 1000)
				{
					rangePointer.Value = 100;
                    rangePointer.Color = PorpoiseColors.FromHex(0xF6BD00);
					
				}
				else
				{

                    rangePointer.Color = PorpoiseColors.FromHex(0x0BB3B9);

				}

                var headerText = new UILabel(new CGRect(gauge.Frame.X, 0, chartWidth, 10));

				headerText.Tag = Int32.Parse(tag.ToString()+"01");
				headerText.Text = (NSString)percentage.ToString("P0");
				//Bindings.Bind(headerText).For(x => x.Text).To((NSString)percentage.ToString("P0")).Apply();
                //headerText.Text = (NSString)percentage.ToString("P0");
                headerText.Font = UIFont.FromName("Helvetica-Bold", 10f);

                headerText.TextAlignment = UITextAlignment.Center;

                ChartView.AddSubview(headerText);

                GaugeViewController gaugeViewController = new GaugeViewController();

                gaugeViewController.View.Frame = new CGRect((gauge.Frame.Width/2)-(gauge.Bounds.Height * .8 /2), gauge.Bounds.Y+(gauge.Bounds.Height*.3), gauge.Bounds.Height*.8, gauge.Bounds.Height*.45);

                //gaugeViewController.View.BackgroundColor = PorpoiseColors.Turquoise;

                gauge.AddSubview(gaugeViewController.View);

				nfloat scaleValue = UIScreen.MainScreen.Scale;

				UIImageView individual = new UIImageView();

                UIImageView groupImage = new UIImageView();

                UIImage groupPreview = null;

				if (scaleValue >= 2)
				{

					groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team%402x.png");

					individual.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19%402x.png");
					 groupPreview = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team%402x.png");

					nfloat expectedWidth = Services.PorpoiseImage.getAppropriateWidth(groupPreview, (System.nfloat)(individual.Frame.Height * 2));

					//groupImage.Frame = new CGRect(gaugeViewController.View.Bounds.GetMaxX() / 2 - (expectedWidth / 2), individualUnits.Frame.Y + individualUnits.Frame.Height, Services.PorpoiseImage.getAppropriateWidth(groupPreview, (System.nfloat)(individual.Frame.Height * 2)), individual.Frame.Height * 2);



					//groupImage.SizeToFit();
				}
				else
				{

					groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team.png");

					individual.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19.png");
					 groupPreview = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team.png");

				}

				UILabel individualHours = new UILabel();

				individualHours.Tag = Int32.Parse(tag.ToString()+"03");

				individualHours.Text = goal.HoursAgainstGoal.ToString();

				individualHours.Font = UIFont.FromName("Helvetica", 17f);

                individualHours.TextAlignment = UITextAlignment.Left;

                individualHours.ClipsToBounds = true;

                //individual image
                individual.Frame = new CGRect(gaugeViewController.View.Bounds.X, 0 + ((individualHours.IntrinsicContentSize.Height)/2) - ((gaugeViewController.View.Frame.Width * .085)/2), gaugeViewController.View.Frame.Width * .085, gaugeViewController.View.Frame.Width * .085);


                //individual hours

                individualHours.ClipsToBounds = true;

				//individualHours.Bordered(1f, UIColor.Black.CGColor);

                if (individualHours.IntrinsicContentSize.Width <= (gaugeViewController.View.Bounds.Width)-((individual.Bounds.Width * 2) * .7))
                {

                    individualHours.Frame = new CGRect(individual.Bounds.X + ((individual.Bounds.Width * 2) * .7), 0, individualHours.IntrinsicContentSize.Width, individualHours.IntrinsicContentSize.Height);
                }
                else{

					individualHours.Frame = new CGRect(individual.Bounds.X + ((individual.Bounds.Width * 2) * .7), 0,(gaugeViewController.View.Bounds.Width) + ((individual.Bounds.Width * 2) * .7), individualHours.IntrinsicContentSize.Height);

				}
				individualHours.Lines = 1;
                individualHours.MinimumFontSize = 8;
                individualHours.AdjustsFontSizeToFitWidth = true;
                UIView topView = new UIView();

                //topView.BackgroundColor = UIColor.White;

                /*if (!individualHours.Text.Contains("."))
                {
                    topView.Frame = new CGRect(gaugeViewController.View.Bounds.Width / 2 - ((individual.Bounds.Width + (individualHours.Bounds.Width * .5) + ((individual.Bounds.Width * 2) * .7)) / 2), gaugeViewController.View.Bounds.Y, individual.Bounds.Width + (individualHours.Bounds.Width * .7) + ((individual.Bounds.Width * 2) * .7), individualHours.Bounds.Height);
                }
                else if(individualHours.Text.Contains(".")){
					topView.Frame = new CGRect(gaugeViewController.View.Frame.Width / 2 - ((individual.Frame.Width + (individualHours.Frame.Width * .5) + ((individual.Frame.Width * 2) * .7)) / 2), gaugeViewController.View.Bounds.Y, individual.Bounds.Width + (individualHours.Bounds.Width * .8) + ((individual.Bounds.Width * 2) * .7), individualHours.Bounds.Height);

				}*/
				topView.Frame = new CGRect((gaugeViewController.View.Bounds.Width / 2) - ((individual.Bounds.Width + (individualHours.Bounds.Width) + ((individual.Bounds.Width) * .7)) / 2), gaugeViewController.View.Bounds.Y, individual.Bounds.Width + (individualHours.Bounds.Width) + ((individual.Bounds.Width) * .7), individualHours.Bounds.Height);
               
				//topView.Bordered(1f, UIColor.Black.CGColor);

                topView.AddSubview(individual);

                topView.AddSubview(individualHours);

				//topView.SizeToFit();

				gaugeViewController.View.ContentMode = UIViewContentMode.Center;

                gaugeViewController.View.AddSubview(topView);



                //Add Line

                UIView line = new UIView();

                line.Frame = new CGRect(gaugeViewController.View.Bounds.X,(gaugeViewController.View.Bounds.Height/2) -1, gaugeViewController.View.Bounds.Width, 1);

                line.BackgroundColor = UIColor.Black;

                //gaugeViewController.View.AddSubview(line);

                //Group

                UIView bottomView = new UIView();

                //bottomView.BackgroundColor = UIColor.White;

				UILabel groupHours = new UILabel();

				groupHours.Tag = Int32.Parse(tag.ToString()+"04");

				groupHours.Text = goal.GoalAcumulativeTotal.ToString();


				groupHours.Font = UIFont.FromName("Helvetica", 17f);

				groupHours.TextAlignment = UITextAlignment.Center;

                nfloat width = (System.nfloat)(gaugeViewController.View.Frame.Width * .17);

                groupImage.Frame = new CGRect(0, 0 + ((groupHours.IntrinsicContentSize.Height) / 2) - ((gaugeViewController.View.Frame.Width * .17) / 2), Services.PorpoiseImage.getAppropriateWidth(groupPreview, width), (gaugeViewController.View.Frame.Width * .17));

				if (groupHours.IntrinsicContentSize.Width <= ((gaugeViewController.View.Bounds.Width - (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .7))*.85))
                {

                    groupHours.Frame = new CGRect(0 + (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .7), 0, groupHours.IntrinsicContentSize.Width, groupHours.IntrinsicContentSize.Height);
                }
                else{

					groupHours.Frame = new CGRect(0 + (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .7), 0, ((gaugeViewController.View.Bounds.Width - (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .7))*.85), groupHours.IntrinsicContentSize.Height);

				}
				groupHours.Lines = 1;
				groupHours.MinimumFontSize = 8;
				groupHours.AdjustsFontSizeToFitWidth = true;
                bottomView.Frame = new CGRect(gaugeViewController.View.Bounds.Width / 2 - ((groupImage.Bounds.Width + groupHours.Bounds.Width + ((groupImage.Bounds.Width * 2) * .17)) / 2), gaugeViewController.View.Bounds.Y+(topView.Bounds.Height), groupImage.Bounds.Width + (groupHours.Bounds.Width) + ((groupImage.Bounds.Width * 2) * .17), groupHours.Bounds.Height);

                bottomView.AddSubview(groupImage);

				bottomView.AddSubview(groupHours);

                gaugeViewController.View.AddSubview(bottomView);

				if (!goal.MetricName.ToLower().Equals("other"))
				{

					goalMetric.Text = goal.MetricName;

				}
				else { 
				
					goalMetric.Text = goal.otherGoalMetricLabel;
				
				}


			}
            else{
				Debug.WriteLine("CHALLENGE HAS NO GOAL "+goal.Name);
                scale.EndValue = 50;
                scale.RimColor = PorpoiseColors.FromHex(0x50CE00);
                if (string.IsNullOrEmpty(goal.MetricName) || goal.MetricName.ToLower().Equals("none"))
                {
                    

                    //amount
                    SFGaugeHeader header = new SFGaugeHeader();
                    header.TextStyle = UIFont.FromName("Helvetica-Bold", 25f);

                    header.Text = (NSString)goal.GoalAmount.ToString();
                    //header.TextColor = PorpoiseColors.FromHex(0x363535);

                    header.Position = new CGPoint(0.5f, 0.5f);
                    gauge.Headers.Add(header);

					goalMetric.Text = "Posts";
                    //units
                  

                }
                else{

					//Metric is not null but there is no goal


					GaugeViewController gaugeViewController = new GaugeViewController();

					gaugeViewController.View.Frame = new CGRect((gauge.Frame.Width / 2) - (gauge.Bounds.Height * .8 / 2), gauge.Bounds.Y + (gauge.Bounds.Height * .3), gauge.Bounds.Height * .8, gauge.Bounds.Height * .45);

					//gaugeViewController.View.BackgroundColor = PorpoiseColors.Turquoise;



					nfloat scaleValue = UIScreen.MainScreen.Scale;

					UIImageView individual = new UIImageView();

					UIImageView groupImage = new UIImageView();

					UIImage groupPreview = null;

					if (scaleValue >= 2)
					{

						groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team%402x.png");

						individual.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19%402x.png");
						groupPreview = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team%402x.png");

						nfloat expectedWidth = Services.PorpoiseImage.getAppropriateWidth(groupPreview, (System.nfloat)(individual.Frame.Height * 2));

						//groupImage.Frame = new CGRect(gaugeViewController.View.Bounds.GetMaxX() / 2 - (expectedWidth / 2), individualUnits.Frame.Y + individualUnits.Frame.Height, Services.PorpoiseImage.getAppropriateWidth(groupPreview, (System.nfloat)(individual.Frame.Height * 2)), individual.Frame.Height * 2);



						//groupImage.SizeToFit();
					}
					else
					{

						groupImage.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team.png");

						individual.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/Image+19.png");

						groupPreview = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/work-team.png");

					}

					UILabel individualHours = new UILabel();

					individualHours.Tag = Int32.Parse(tag.ToString()+"03");

					individualHours.Text = goal.HoursAgainstGoal.ToString();

					individualHours.Font = UIFont.FromName("Helvetica", 17f);

					individualHours.TextAlignment = UITextAlignment.Left;

					individualHours.ClipsToBounds = true;

					//individual image
					individual.Frame = new CGRect(gaugeViewController.View.Bounds.X, 0 + ((individualHours.IntrinsicContentSize.Height) / 2) - ((gaugeViewController.View.Frame.Width * .085) / 2), gaugeViewController.View.Frame.Width * .085, gaugeViewController.View.Frame.Width * .085);


					//individual hours

					individualHours.ClipsToBounds = true;

					if (individualHours.IntrinsicContentSize.Width <= (gaugeViewController.View.Bounds.Width) + ((individual.Bounds.Width * 2) * .7))
					{

						individualHours.Frame = new CGRect(individual.Bounds.X + ((individual.Bounds.Width * 2) * .7), 0, individualHours.IntrinsicContentSize.Width, individualHours.IntrinsicContentSize.Height);
					}
					else
					{

						individualHours.Frame = new CGRect(individual.Bounds.X + ((individual.Bounds.Width * 2) * .7), 0, (gaugeViewController.View.Bounds.Width) + ((individual.Bounds.Width * 2) * .7), individualHours.IntrinsicContentSize.Height);

					}
					individualHours.Lines = 1;
					individualHours.MinimumFontSize = 8;
					individualHours.AdjustsFontSizeToFitWidth = true;
					UIView topView = new UIView();

					topView.Frame = new CGRect((gaugeViewController.View.Bounds.Width / 2) - ((individual.Bounds.Width + (individualHours.Bounds.Width) + ((individual.Bounds.Width) * .7)) / 2), gaugeViewController.View.Bounds.Y, individual.Bounds.Width + (individualHours.Bounds.Width) + ((individual.Bounds.Width) * .7), individualHours.Bounds.Height);
				
					topView.AddSubview(individual);

					topView.AddSubview(individualHours);


					gaugeViewController.View.AddSubview(topView);


					//Add Line

					UIView line = new UIView();

					line.Frame = new CGRect(gaugeViewController.View.Bounds.X, (gaugeViewController.View.Bounds.Height / 2) - 1, gaugeViewController.View.Bounds.Width, 1);

					line.BackgroundColor = UIColor.Black;

					//gaugeViewController.View.AddSubview(line);

					//Group

					UIView bottomView = new UIView();

					//bottomView.BackgroundColor = UIColor.White;

					UILabel groupHours = new UILabel();

					groupHours.Tag=Int32.Parse(tag.ToString()+"03");

					groupHours.Text = goal.GoalAcumulativeTotal.ToString();


					groupHours.Font = UIFont.FromName("Helvetica", 17f);

					groupHours.TextAlignment = UITextAlignment.Center;

					nfloat width = (System.nfloat)(gaugeViewController.View.Frame.Width * .17);

					groupImage.Frame = new CGRect(0, 0 + ((groupHours.IntrinsicContentSize.Height) / 2) - ((gaugeViewController.View.Frame.Width * .17) / 2), Services.PorpoiseImage.getAppropriateWidth(groupPreview, width), (gaugeViewController.View.Frame.Width * .17));

					if (groupHours.IntrinsicContentSize.Width <= ((gaugeViewController.View.Bounds.Width - (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .2))*.85))
					{

						groupHours.Frame = new CGRect(0 + (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .2), 0, groupHours.IntrinsicContentSize.Width, groupHours.IntrinsicContentSize.Height);
					}
					else
					{

						groupHours.Frame = new CGRect(0 + (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .2), 0, ((gaugeViewController.View.Bounds.Width - (groupImage.Bounds.Width) + ((individual.Bounds.Width * 1) * .2))*.85), groupHours.IntrinsicContentSize.Height);

					}
					groupHours.Lines = 1;
					groupHours.MinimumFontSize = 8;
					groupHours.AdjustsFontSizeToFitWidth = true;
					bottomView.Frame = new CGRect(gaugeViewController.View.Bounds.Width / 2 - ((groupImage.Bounds.Width + groupHours.Bounds.Width + ((groupImage.Bounds.Width * 2) * .17)) / 2), gaugeViewController.View.Bounds.Y + (topView.Bounds.Height), groupImage.Bounds.Width + (groupHours.Bounds.Width) + ((groupImage.Bounds.Width * 2) * .17), groupHours.Bounds.Height);

					bottomView.AddSubview(groupImage);

					bottomView.AddSubview(groupHours);


                    gaugeViewController.View.AddSubview(bottomView);

					gauge.AddSubview(gaugeViewController.View);

                    scale.RimWidth = 5;

					if (!goal.MetricName.ToLower().Equals("other"))
				{

						Bindings.Bind(goalMetric).For(x => x.Text).To(goal.MetricName).Apply();

				}
				else { 

						Bindings.Bind(goalMetric).For(x => x.Text).To(goal.otherGoalMetricLabel).Apply();
				
				
				}

                }


			}
            scale.Pointers = pointers;
			scales.Add(scale);
           
           
			goalMetric.Font = UIFont.FromName("Helvetica-Bold", 8f);
			goalMetric.TextAlignment = UITextAlignment.Center;
			gauge.Scales = scales;
            goalName.TextColor = UIColor.Black;
			goalName.Text =  goal.Name;
			goalName.Font = UIFont.FromName("Helvetica-Bold", 8f);
			goalName.TextAlignment = UITextAlignment.Center;
           
			goalHours.TextColor = PorpoiseColors.Pink;
			goalHours.Text = "" + goal.Hours.ToString() + " HOURS";
			goalHours.Font = UIFont.FromName("Helvetica", 16f);
			goalHours.TextAlignment = UITextAlignment.Center;

			ChartView.AddSubview(gauge);
            ChartView.AddSubview(goalMetric);
			ChartView.AddSubview(goalName);
			//ChartView.AddSubview(goalHours);
			ChartView.UserInteractionEnabled = true;
			gauge.UserInteractionEnabled = true;
			currentFrame = gauge.Frame;
			gaugeCount += 1;

			//only add enough width to fit the goals (before the if statement was written, it would always add extra space even though there wasn't a goal to show)
			if (ViewModel.CompanyGoals.Count != gaugeCount)
			{
				GoalsScrollViewSize = new CGSize(GoalsScrollViewSize.Width + gauge.Frame.Width, this.GoalsScrollView.Frame.Height);
			}
			else
			{
				GoalsScrollViewSize = new CGSize(GoalsScrollViewSize.Width + 16f, this.GoalsScrollView.Frame.Height);
			}

			return gauge;
		}


		UIAlertController BuildGoalDetailsAlert(Goal goal)
		{
			string goalDescription = "\n";

			if (!string.IsNullOrEmpty(goal.Description))
			{
				goalDescription = "" + goal.Description + " \n\n";
			}

			string metricName = "";

			if (!goal.MetricName.ToLower().Equals("other"))
				{

					metricName = goal.MetricName;

				}
				else { 
				
					metricName = goal.otherGoalMetricLabel;
				
				}

			if (goal.MetricName.ToLower().Equals("none"))
				{

					metricName = "Posts";

				}

			var stylesForValues = new UIStringAttributes();
			var stylesForTitles = new UIStringAttributes();

            stylesForTitles.ForegroundColor = PorpoiseColors.DarkGrey;
			stylesForTitles.Font = UIFont.FromName("Helvetica-Bold", 14f);
			stylesForValues.ForegroundColor = PorpoiseColors.Turquoise;
			stylesForValues.Font = UIFont.FromName("Helvetica", 12f);

            var ATGoalName = new NSAttributedString(goal.Name, stylesForTitles);
			var ATDescription = new NSAttributedString(goalDescription, stylesForValues);
            var ATType = new NSAttributedString(Resource.Type, stylesForTitles);
            NSAttributedString ATTypeValues   = new NSAttributedString(string.Format(Resource.TypeSentence,goal.GoalType.ElementAt(0).ToString().ToUpper()+goal.GoalType.Substring(1), goal.ChallengeType, " \n\n"), stylesForValues); 
           
            //var ATHours = new NSAttributedString(Resource.Progress, stylesForTitles);
			//var ATHoursValues = new NSAttributedString(string.Format(Resource.GoalProgressSentence, goal.HoursAgainstGoal, goal.Hours, " \n\n"), stylesForValues);
            NSAttributedString ATReward = null;
            NSAttributedString ATRewardValue = null;

            if (!string.IsNullOrEmpty(goal.GiftName))
            {
                 ATReward = new NSAttributedString(Resource.Reward, stylesForTitles);
                 ATRewardValue = new NSAttributedString("" + goal.GiftName + ""+"\n\n", stylesForValues);
            }
            var ATPosted = new NSAttributedString(Resource.Posted, stylesForTitles);

            NSAttributedString ATPostedDescription = null;

			if(goal.GoalType.ToLower().Equals("individual")){
                
                ATPostedDescription = new NSAttributedString(string.Format(Resource.PostedIndividualSentence, goal.HoursAgainstGoal, goal.GoalAmount, metricName, " \n\n"), stylesForValues);

				if (goal.GoalAmount == 0) { 
				
					ATPostedDescription = new NSAttributedString("0 "+goal.MetricName+"\n\n", stylesForValues);

				
				}
				if (goal.MetricName.ToLower().Equals("none")) { 
				
					ATPostedDescription = new NSAttributedString("0 Posts"+"\n\n", stylesForValues);
				
				}
			}
            else{

                ATPostedDescription = new NSAttributedString(string.Format(Resource.PostedGroupSentence, goal.HoursAgainstGoal, metricName, " \n\n"), stylesForValues);

				if (goal.GoalAmount == 0) { 
				
					ATPostedDescription = new NSAttributedString("0 "+goal.MetricName+"\n\n", stylesForValues);

				
				}

				if (goal.MetricName.ToLower().Equals("none")) { 
				
					ATPostedDescription = new NSAttributedString("0 Posts"+"\n\n", stylesForValues);
				
				}

			}

            var ATCompanyWide = new NSAttributedString(Resource.CompanyWide, stylesForTitles);

            NSAttributedString ATCompanyWideDescription = null;

			if (goal.GoalType.ToLower().Equals("individual"))
			{

                ATCompanyWideDescription = new NSAttributedString(string.Format(Resource.CompanyWideIndividualSentence, goal.GoalAcumulativeTotal, metricName, " \n\n"), stylesForValues);


			}
			else
			{

                ATCompanyWideDescription = new NSAttributedString(string.Format(Resource.CompanyWideGroupSentence, goal.GoalAcumulativeTotal,goal.GoalAmount, metricName, " \n\n"), stylesForValues);

				if (goal.GoalAmount == 0)
				{

					ATCompanyWideDescription = new NSAttributedString("0 " + goal.MetricName + "\n\n", stylesForValues);


				}

				if (goal.MetricName.ToLower().Equals("none"))
				{

					ATCompanyWideDescription = new NSAttributedString("0 Posts" + "\n\n", stylesForValues);

				}
			}

                NSMutableAttributedString attributedGoalDetails = new NSMutableAttributedString();
			attributedGoalDetails.Append(ATDescription);
            attributedGoalDetails.Append(ATType);
            attributedGoalDetails.Append(ATTypeValues);
			//attributedGoalDetails.Append(ATHours);
			//attributedGoalDetails.Append(ATHoursValues);
            if (!string.IsNullOrEmpty(goal.GiftName))
            {
                attributedGoalDetails.Append(ATReward);
                attributedGoalDetails.Append(ATRewardValue);
            }

            attributedGoalDetails.Append(ATPosted);
            attributedGoalDetails.Append(ATPostedDescription);
            attributedGoalDetails.Append(ATCompanyWide);
            attributedGoalDetails.Append(ATCompanyWideDescription);

            if(!string.IsNullOrEmpty(goal.EndDate))
            {

                var ATEndDate = new NSAttributedString(Resource.EndDateSentence, stylesForTitles);

				string[] formats = {"dd/MM/yyyy", "dd-MMM-yyyy", "yyyy-MM-dd",
				   "dd-MM-yyyy", "M/d/yyyy", "dd MMM yyyy", "MMM dd, yyyy"};
                string converted = DateTime.ParseExact(goal.EndDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None).ToString("MMM dd, yyyy");

                var ATEndDateValue = new NSAttributedString(converted, stylesForValues);
                attributedGoalDetails.Append(ATEndDate);
                attributedGoalDetails.Append(ATEndDateValue);

            }
            //Todo: here goes the aler message
            var dialog = UIAlertController.Create(null, null, UIAlertControllerStyle.Alert);
			dialog.SetValueForKey(attributedGoalDetails, (NSString)"AttributedMessage");
			dialog.SetValueForKey(ATGoalName, (NSString)"AttributedTitle");

			var action = UIAlertAction.Create("Ok", UIAlertActionStyle.Default, x => { });
			dialog.AddAction(action);

            var createPost = UIAlertAction.Create("Create Post", UIAlertActionStyle.Default, x => {

                ViewModel.GoalName = goal.Id.Value.ToString();

                HomeViewController hvc = (HomeViewController)TabBarController;

                //hvc.showChallenges();

                this.ViewModel.CreatePostCommand.Execute();

                //hvc.TabBar.Items[2].

                //ViewModel.CreatePostCommand.Execute();
            
            });

            dialog.AddAction(createPost);

			return dialog;
		}



		void StyleElements()
		{
			HeaderBackground.BackgroundColor = PorpoiseColors.Turquoise;
			lblHoursGiven.TextColor = PorpoiseColors.DarkGrey;
			lblHourAmount.Font = UIFont.FromName("Helvetica-Bold", 28f);
			lblGoals.TextColor = PorpoiseColors.DarkGrey;
			lblLatest.TextColor = PorpoiseColors.DarkGrey;
			GoalsScrollView.ShowsVerticalScrollIndicator = false;
			GoalsScrollView.ShowsHorizontalScrollIndicator = true;
			View.BringSubviewToFront(HeaderDetailsContainer);
			View.BringSubviewToFront(Overlay);
			ProfilePicture.Layer.CornerRadius = ProfilePicture.Frame.Size.Height / 2.6f;
			ProfilePicture.Layer.MasksToBounds = true;
			ProfilePicture.Layer.BorderColor = UIColor.White.CGColor;
			ProfilePicture.Layer.BorderWidth = 1.5f;

            nfloat scale = UIScreen.MainScreen.Scale;

			

            UIImage clockIcon = null;

            if(scale >= 2){

                clockIcon = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/clock_icon%402x.png");

                LeftArrow.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/left_arrow%402x.png");

                RightArrow.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/right_arrow%402x.png");


            }
            else{
                
				clockIcon = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/clock_icon.png");

                LeftArrow.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/left_arrow.png");

                RightArrow.Image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/right_arrow.png");

			}
            //ClockIcon.Image = clockIcon;

            //ClockIcon Constrants


		}

        private void drawWindow(){

            CGRect screenSize = UIScreen.MainScreen.Bounds;

            Debug.WriteLine("SCREEN HEIGHT: "+screenSize.Height);

            float windowHeight = (float)(this.View.Bounds.Height*.1);

            this.addPostView = new UIView();

            addPostView.Frame = new CGRect(0, LatestPostTableView.Frame.Height-windowHeight, screenSize.Width, windowHeight);

            addPostView.BackgroundColor = PorpoiseColors.LightErrorRed;

            this.LatestPostTableView.Add(addPostView);

            this.LatestPostTableView.BringSubviewToFront(addPostView);

            this.LatestPostTableView.UserInteractionEnabled = false;


        }

		public void showDeletePostAlert()
		{

			/*var alert = UIAlertController.Create("DeletePost", "Are you sure you want to delete this post", UIAlertControllerStyle.Alert);

			alert.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, x =>
			{

				this.deletePost(id);



			}));

			alert.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, null));*/


			// Create a new Alert Controller
			UIAlertController actionSheetAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

			// Add Actions


			actionSheetAlert.AddAction(UIAlertAction.Create("Edit Post", UIAlertActionStyle.Default, async (action) =>
			{

				await ViewModel.EditPost();

			}));

			actionSheetAlert.AddAction(UIAlertAction.Create("Delete Post", UIAlertActionStyle.Default, async (action) =>
			{

				ShowDeleteAlert();

			}));

			/*actionSheetAlert.AddAction(UIKit.UIAlertAction.Create("Well Done!", UIKit.UIAlertActionStyle.Default, (action) =>
			{

				Debug.WriteLine("Well Done!");

			}));*/


			actionSheetAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Cancel button pressed.")));

			// Required for iPad - You must specify a source for the Action Sheet since it is
			// displayed as a popover
			UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
			if (presentationPopover != null)
			{
				presentationPopover.SourceView = this.View;
				presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
			}

			// Display the alert
			this.PresentViewController(actionSheetAlert, true, null);

		}

		public void ShowDeleteAlert()
		{

			UIAlertController actionSheetAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

			// Add Actions


			actionSheetAlert.AddAction(UIAlertAction.Create("Are you sure you want to delete this post?", UIAlertActionStyle.Default, async (action) =>
			{

				await ViewModel.EditPost();

			}));

			actionSheetAlert.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, async (action) =>
			{

				await ViewModel.DeletePost();

			}));

			/*actionSheetAlert.AddAction(UIKit.UIAlertAction.Create("Well Done!", UIKit.UIAlertActionStyle.Default, (action) =>
			{

				Debug.WriteLine("Well Done!");

			}));*/


			actionSheetAlert.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Cancel button pressed.")));

			this.PresentViewController(actionSheetAlert, true, null);

		}

		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
			View.BringSubviewToFront(HeaderDetailsContainer);
			View.BringSubviewToFront(Overlay);

		}


	}

}