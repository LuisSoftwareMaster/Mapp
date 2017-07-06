using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;
using PorpoiseMobileApp.Models;
using System.Diagnostics;
using System.ComponentModel;

namespace PorpoiseMobileApp.iOS
{

	//[Register("PorpoiseButton")]
	partial class PorpoiseButton : UIButton, INotifyPropertyChanged
	{
		private static UIImage porpTransparentBackground;
		private static UIImage porpTurquoiseBackground;
		private static UIImage porpWhiteBackground;
		private static UIImage porpGreyBackground;

		private UIImage _backgroundImage;

		private Welldones[] _welldones;


		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				Debug.WriteLine("PropertyChanged");

				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}

		}

		public Welldones[] Welldones {

			get {

				Debug.WriteLine("GETTING WELLDONES IN BUTTON");

				return _welldones;
			}

			set {

				_welldones = value;

				Debug.WriteLine("WELLDONES CHANGED INSIDE PORPOISE BUTTON");

				this.changeBackgroundImage();

				//NotifyPropertyChanged("Welldones");
			
			}
		
		}

		private void changeBackgroundImage() {

			var hourLog = Welldones;

			Boolean found = false;

			if (hourLog != null && hourLog.Length > 0)
			{

				foreach (Welldones aux in hourLog)
				{

					if (aux.UserId.Equals(AccountInfo.UserId.ToString()))
					{

						Debug.WriteLine("Returning Orange Image");

						this.BackgroundImage = new UIImage("wellDoneOrange.png");

						found = true;

						break;

					}

				}


			}

			if (!found)
			{

				Debug.WriteLine("Returning Gray Image");

				this.BackgroundImage = new UIImage("wellDoneGray.png");

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

				NotifyPropertyChanged("BackgroundImage");

			}
			get
			{
	
				return _backgroundImage;

			}

		}

		public PorpoiseButton(IntPtr handle) : base(handle)
		{
		}
		public PorpoiseButton() : base()
		{

		}

		static PorpoiseButton()
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

		public event PropertyChangedEventHandler PropertyChanged;

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