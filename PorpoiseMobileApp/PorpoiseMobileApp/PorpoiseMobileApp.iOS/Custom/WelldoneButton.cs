using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;
using PorpoiseMobileApp.Models;
using System.Diagnostics;
using System.ComponentModel;
using System.Text.RegularExpressions;
using PorpoiseMobileApp.Client;
using System.Threading.Tasks;
using System.Collections.Generic;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.iOS
{

	[Register("WelldoneButton")]
	partial class WelldoneButton : UIButton
	{
		private static UIImage porpTransparentBackground;
		private static UIImage porpTurquoiseBackground;
		private static UIImage porpWhiteBackground;
		private static UIImage porpGreyBackground;

		private  IPorpoiseWebApiClient client;


		private string imageSrc;

		private UIImage _backgroundImage;

		private Welldones[] _welldones;

		private ActivityViewModel profileViewModel;

        public string ImageSrc{

            get{

                return imageSrc;

            }
            set{

                imageSrc = value;

            }

        }

public ActivityViewModel ViewModel { 
		
			get {
				return this.profileViewModel;
			}
			set {

				this.profileViewModel = value;
			}
		
		}



		public override void PressesBegan(NSSet<UIPress> presses, UIPressesEvent evt)
		{
			base.PressesBegan(presses, evt);
			Debug.WriteLine("PRESS WELLDONE BUTTON BEGAN");
		UIView superView = this.Superview;

		UIView secondSuperView = superView.Superview;

		ActivityViewController controller = null;

		

			while (superView != null)
			{

				if (superView.NextResponder is ActivityViewController) {

					controller = (ActivityViewController)superView.NextResponder;

					break;

				}

				superView = superView.Superview;

			}
            Debug.WriteLine("BUTTON IMAGE: "+this.imageSrc);
			if (controller != null) {

				//Debug.WriteLine("CONTROLLER FOUND AND CHANGING TABLE SOURCE "+controller.PostsSource.Count);

				//var result = await controller.reloadCompanyTable();



				//controller.reloadTable();




				/*var posts = await client.GetPosts(false);

				controller.PostsSource =  posts.Payload;*/



			

				//controller.reloadCompanyTable();



				//var posts = await this.GetPosts(false);

			

				/*if (posts != null)
				{

					Debug.WriteLine("POSTS IS NOT NULL");

					if (this.imageSrc.Equals(image))
					{

						if (this.imageSrc.Equals("wellDoneGray.png"))
						{

							this.BackgroundImage = new UIImage("wellDoneOrange.png");

						}

						else
						{

							this.BackgroundImage = new UIImage("wellDoneGray.png");

						}

					}

					controller.PostsSource = posts;

					controller.reloadCompanyTable();

				}
				else {

					Debug.WriteLine("POSTS IS NULL");
				
				}
				*/

				//controller.ViewDidLoad();

				//controller.View.SetNeedsDisplay();



			}


		}


		public override void PressesEnded(NSSet<UIPress> presses, UIPressesEvent evt)
		{

			Debug.WriteLine("PRESS BUTTON ENDED");

		}

		private async Task<List<HourLog>> GetPosts(bool onlyForUser)
		{
			try
			{
				//InFlight = true;
				if (client != null)
				{
					var result = await client.GetPosts(onlyForUser);
					if (result != null && result.Successful)
					{
						//InFlight = false;
						foreach (var post in result.Posts)
						{
							if (post.PostType == "user")
							{
								post.OnEdit += (id) =>
								{
									if (post.CanEdit)
									{
										//ShowViewModel<LogHoursViewModel>(new EditParameters() { PostId = id });
									}
									else if (!post.CanEdit)
									{
										throw new PorpoiseException(Resource.InactiveGoalError);
									}
								};

							


							}
						}
						return result.Posts;
					}
				
				}

				//controller.InFlight = false;
				return new List<HourLog>();

			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				//InFlight = false;
				return new List<HourLog>();
			}

		}

		private void reloadTable(PostItemCellController cell, string image) {

			Debug.WriteLine("TRYING TO RELOAD TABLE ");

			UIView superView = cell.Superview;

			UIView secondSuperView = superView.Superview;

			ActivityViewController controller = null;

			while (superView != null)
			{

				if (superView.NextResponder is ActivityViewController) {

					controller = (ActivityViewController)superView.NextResponder;

					break;

				}

				superView = superView.Superview;

			}

			if (controller != null) {

				//Debug.WriteLine("CONTROLLER FOUND AND CHANGING TABLE SOURCE "+controller.PostsSource.Count);

				//var result = await controller.reloadCompanyTable();



				//controller.reloadTable();




				/*var posts = await client.GetPosts(false);

				controller.PostsSource =  posts.Payload;*/




				//controller.reloadCompanyTable();



				//var posts = await this.GetPosts(false);

			

				/*if (posts != null)
				{

					Debug.WriteLine("POSTS IS NOT NULL");

					if (this.imageSrc.Equals(image))
					{

						if (this.imageSrc.Equals("wellDoneGray.png"))
						{

							this.BackgroundImage = new UIImage("wellDoneOrange.png");

						}

						else
						{

							this.BackgroundImage = new UIImage("wellDoneGray.png");

						}

					}

					controller.PostsSource = posts;

					controller.reloadCompanyTable();

				}
				else {

					Debug.WriteLine("POSTS IS NULL");
				
				}
				*/

				//controller.ViewDidLoad();

				//controller.View.SetNeedsDisplay();

                //controller.ViewModel.InFlight = false;

            }

		
		}

        private void reloadTableNoPhoto(NoPhotoPost cell, string image)
		{

			Debug.WriteLine("TRYING TO RELOAD TABLE ");

			UIView superView = cell.Superview;

			UIView secondSuperView = superView.Superview;

			ActivityViewController controller = null;

			while (superView != null)
			{

				if (superView.NextResponder is ActivityViewController)
				{
                    
					controller = (ActivityViewController)superView.NextResponder;

					break;

				}

				superView = superView.Superview;

			}

			if (controller != null)
			{

				//Debug.WriteLine("CONTROLLER FOUND AND CHANGING TABLE SOURCE "+controller.PostsSource.Count);

				//var result = await controller.reloadCompanyTable();



				//controller.reloadTable();




				/*var posts = await client.GetPosts(false);

				controller.PostsSource =  posts.Payload;*/




				//controller.reloadCompanyTable();



				//var posts = await this.GetPosts(false);



				/*if (posts != null)
				{

					Debug.WriteLine("POSTS IS NOT NULL");

					if (this.imageSrc.Equals(image))
					{

						if (this.imageSrc.Equals("wellDoneGray.png"))
						{

							this.BackgroundImage = new UIImage("wellDoneOrange.png");

						}

						else
						{

							this.BackgroundImage = new UIImage("wellDoneGray.png");

						}

					}

					controller.PostsSource = posts;

					controller.reloadCompanyTable();

				}
				else {

					Debug.WriteLine("POSTS IS NULL");
				
				}
				*/

				//controller.ViewDidLoad();

				//controller.View.SetNeedsDisplay();

				//controller.ViewModel.InFlight = false;

			}


		}




		public override void TouchesEnded(NSSet touches, UIEvent evt)
		{
			base.TouchesEnded(touches, evt);

			Debug.WriteLine("TOUCHES BEGAN");

            Debug.WriteLine("VALUE OF IMAGE "+this.BackgroundImage);
           // this.changeimage();
			var view = new UIView();

			int resultString = 0;

			if (this.Superview != null)
			{

				Debug.WriteLine("INSIDE CASTING");
				if (this.Superview.NextResponder != null && (this.Superview.NextResponder is PostItemCellController))
				{
					view = (PostItemCellController)this.Superview.NextResponder;
					if (!Regex.Match(((PostItemCellController)view).WelldonesText.Text, @"\d+").Value.Equals(""))
					{

						resultString = Convert.ToInt32(Regex.Match(((PostItemCellController)view).WelldonesText.Text, @"\d+").Value);

					}
				}
				else if (this.Superview.NextResponder != null && (this.Superview.NextResponder is NoPhotoPost)) { 
					view = (NoPhotoPost)this.Superview.NextResponder;
					if (!Regex.Match(((NoPhotoPost)view).WelldonesText.Text, @"\d+").Value.Equals(""))
					{

						resultString = Convert.ToInt32(Regex.Match(((NoPhotoPost)view).WelldonesText.Text, @"\d+").Value);

					}
				
				}


			}

			string imageBeforeChange = this.imageSrc;

			Debug.WriteLine("IMAGE BEFORE CHANGE "+imageBeforeChange);

			/*if (!resultString.Equals(""))
			{

				((PostItemCellController)view).WelldonesText.Hidden = false;


			}
			else { 
			
			((PostItemCellController)view).WelldonesText.Hidden = true;

			
			}*/


			Debug.WriteLine("IMAGE SOURCE "+this.imageSrc);

			/* (this.imageSrc)
			{

				case "wellDoneGray.png":

					//this.BackgroundImage = new UIImage("wellDoneOrange.png");

					this.imageSrc = "wellDoneOrange.png";

					resultString += 1;

					((PostItemCellController)view).WelldonesText.Text = resultString.ToString() + " " + "People gave a Well Done!";

					//((PostItemCellController)view).WelldonesText.Hidden = false;

					((PostItemCellController)view).GivenWelldone.Hidden = false;



					//((PostItemCellController)view).WellDoneButton.Superview.Frame = new CGRect(0, 0, ((PostItemCellController)view).WellDoneButton.Superview.Frame.Size.Width, 520f);

					/*PostItemCellController subView = ((PostItemCellController)view);

					foreach (NSLayoutConstraint aux in ((PostItemCellController)view).WellDoneButton.Superview.Constraints)

					{
						Debug.WriteLine("CONSTANT INSIDE BUTTON " + aux.Constant);

						if (aux.Constant == 55)
						{

							UIView superView = subView.Superview;

							while (superView != null && !(superView is UITableView))
							{

								superView = superView.Superview;

							}

							UITableView a = (UITableView)superView;

							a.ReloadData();

							subView.Frame = new CGRect(0, 0, subView.Frame.Size.Width, 520f);

							Debug.WriteLine("ROW HEIGTH " + a.RowHeight + " CELL HEIGHT " + subView.Frame.Size.Height);


							a.RowHeight = 520f;

							a.EstimatedRowHeight = 520f;

							a.ReloadData();

							//ActivityViewController controller = a.Respon

							//Debug.WriteLine();

							/*Debug.WriteLine("RELOADING DATA TABLE"+subView.Superview);

								UITableView table = (UITableView)subView.Superview;

								table.ReloadData();



						}

						if (aux.Constant == 2)
						{
							//Debug.WriteLine(subView.Superview);
							aux.Constant = 6;

							UIView superView = subView.Superview;

							while (superView!=null && !(superView is UITableView)) {

								superView = superView.Superview;
							
							}

							UITableView a = (UITableView)superView;

							subView.Frame = new CGRect(0, 0, subView.Frame.Size.Width, 520f);

							Debug.WriteLine("ROW HEIGTH " + a.RowHeight+" CELL HEIGHT "+subView.Frame.Size.Height);

							a.RowHeight = 520f;

							a.EstimatedRowHeight = 520f;

							a.ReloadData();
								/*Debug.WriteLine("RELOADING DATA TABLE "+subView.Superview);

								UITableView table = (UITableView)subView.T;

								table.ReloadData();



						}

					}


					break;

				case "wellDoneOrange.png":

					//this.BackgroundImage = new UIImage("wellDoneGray.png");


					this.imageSrc = "wellDoneGray.png";

					if (resultString > 0)
					{
						if (resultString - 1 == 0)
						{

							((PostItemCellController)view).WelldonesText.Text = "Be the first to give a Well Done!";

							((PostItemCellController)view).GivenWelldone.Hidden = true;

						}
						else
						{

							resultString = resultString - 1;

							((PostItemCellController)view).WelldonesText.Text = resultString.ToString() + " " + "People gave a Well Done!";

							((PostItemCellController)view).WelldonesText.Hidden = false;

							((PostItemCellController)view).GivenWelldone.Hidden = false;


						}

					}
					else { 
					
						((PostItemCellController)view).WelldonesText.Text = resultString.ToString() + " " + "People gave a Well Done!";

						((PostItemCellController)view).WelldonesText.Hidden = false;

						((PostItemCellController)view).GivenWelldone.Hidden = false;
					
					}

					break;

					default:

					break;

			
			}*/
			if (view is PostItemCellController)
			{

				this.reloadTable(((PostItemCellController)view), imageBeforeChange);
			}
				         else if (view is NoPhotoPost) { 
					//this.reloadTableNoPhoto((NoPhotoPost)view, imageBeforeChange);
				}

		}

		private void modifyWelldones(UILabel label) { 
		
		
		
		}

		public Welldones[] Welldones
		{

			get
			{
				
				//Debug.WriteLine("GETTING WELLDONES IN BUTTON");

				return _welldones;
			}

			set
			{

				_welldones = value;

				//Debug.WriteLine("WELLDONES CHANGED INSIDE PORPOISE BUTTON");

				this.changeBackgroundImage();

				//NotifyPropertyChanged("Welldones");

			}

		}

        private void changeimage(){

            if(this.imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png")){

				nfloat scale = UIScreen.MainScreen.Scale;

				if (scale >= 2)
				{

					this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png");
					this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png";

				}
				else
				{

					this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png");
					this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png";

				}
            }
            else if (this.imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png")){
                this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png";
                this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png");

            }
            else if (this.imageSrc.Equals("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png")){
                this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png";
                this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png");
            }

        }

		private async void changeBackgroundImage()
		{

			var hourLog = Welldones;
			client = new PorpoiseWebApiClient();
			Boolean found = false;
			var employee = await client.GetEmployee();
			if(employee != null && employee.Successful)
			{
			string userID = employee.Payload.UserId.ToString();
			Debug.WriteLine("USER ID: " + userID);

			if (hourLog != null && hourLog.Length > 0)
			{

				foreach (Welldones aux in hourLog)
				{

					if (aux.UserId.Equals(userID))
					{

						Debug.WriteLine("Returning Orange Image");

						
                           
                                this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png");

                            this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneOrange.png"; 

						found = true;

						break;

					}

				}


			}

		}

			if (!found)
			{

				Debug.WriteLine("Returning Gray Image");

				
                nfloat scale = UIScreen.MainScreen.Scale;

                if(scale >= 2)
                    {

                    this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png");
                    this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray%402x.png";

                    }
                    else
                    {

					this.BackgroundImage = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png");
                    this.imageSrc = "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/wellDoneGray.png";

                    }


               

			}



		}

		public UIImage BackgroundImage
		{

			set
			{

				_backgroundImage = value;

				this.SetBackgroundImage(_backgroundImage, UIControlState.Normal);

				//this.SetImage(_backgroundImage, UIControlState.Normal); 

				Debug.WriteLine("UPDATING BACKGROUND IMAGE");

				//NotifyPropertyChanged("BackgroundImage");

			}
			get
			{

				return _backgroundImage;

			}

		}

		public WelldoneButton(IntPtr handle) : base(handle)
		{
		}
		public WelldoneButton() : base()
		{

		}

		static WelldoneButton()
		{
			//normal button
			porpTransparentBackground = CreateButtonImage(UIColor.Clear.CGColor);
			//turquoise button
			porpTurquoiseBackground = CreateButtonImage(PorpoiseColors.Turquoise.CGColor);
			//inverse button
			porpWhiteBackground = CreateButtonImage(UIColor.White.CGColor);
			//disabled or highlighted button
			porpGreyBackground = CreateButtonImage(PorpoiseColors.Grey.CGColor);
		}

		static UIImage CreateButtonImage(CGColor color)
		{
			CGRect rect = new CGRect(0, 0, 1, 1);
			UIGraphics.BeginImageContext(rect.Size);
			CGContext context = UIGraphics.GetCurrentContext();
			context.SetFillColor(color);
			context.FillRect(rect);
			var image = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();
			return image;
		}
		//TODO: Figure out why the PorpoiseButton goes transparent/disapears when clicked and waiting for task to finish.
		private void Configure()
		{
			if (!_inverse)
			{
				this.Bordered(_bordered ? 1f : 0f, GetBorderColor(Enabled));
			}
			else
			{
				this.Bordered(0f, UIColor.Clear.CGColor);
			}
			//normal state:
			//if button is inverse, the text colour is Turquoise, if not inverse, the text is white
			this.SetTitleColor(_inverse ? UIColor.FromRGBA(65, 193, 201, 1) : UIColor.White, UIControlState.Normal);

			//highlighted state: text is grey
			this.SetTitleColor(PorpoiseColors.Grey, UIControlState.Highlighted);

			this.SetTitleColor(PorpoiseColors.Grey, UIControlState.Focused);

			//disabled state:
			//if inverse, text is white
			//else text is grey
			this.SetTitleColor(_inverse ? UIColor.White : PorpoiseColors.Grey, UIControlState.Disabled);

			//if inverse, background is transparent for Normal state
			//if not inverse, background is transparent for normal state
			this.SetBackgroundImage(porpTransparentBackground, UIControlState.Normal);

			if (_inverse)
			{
				this.SetTitleColor(PorpoiseColors.Turquoise, UIControlState.Normal);
				this.SetBackgroundImage(porpWhiteBackground, UIControlState.Normal);
				this.SetBackgroundImage(porpGreyBackground, UIControlState.Disabled);
				this.SetBackgroundImage(porpWhiteBackground, UIControlState.Highlighted);
			}

		}

		CGColor GetBorderColor(bool enabled)
		{
			return enabled ? UIColor.White.CGColor : PorpoiseColors.Grey.CGColor;
		}

		public override bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				base.Enabled = value;
				Configure();
			}
		}

		private bool _inverse;

		[Export("Inverse")]
		public bool Inverse
		{
			get
			{
				return _inverse;
			}
			set
			{
				_inverse = value;
				Configure();
			}
		}
		private bool _bordered = true;



		[Export("Bordered")]
		public bool Bordered
		{
			get
			{
				return _bordered;
			}
			set
			{
				_bordered = value;
				Configure();
			}
		}
	}
}