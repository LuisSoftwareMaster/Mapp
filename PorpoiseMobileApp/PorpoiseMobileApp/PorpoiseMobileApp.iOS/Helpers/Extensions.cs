using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Drawing;
using CoreGraphics;
using System.Globalization;
using System.Linq;
using System.Diagnostics.Contracts;

namespace PorpoiseMobileApp.iOS
{
	public static class Extensions
	{
		public static void Alert(this UIViewController ctrl, string title, string message, Action handler = null, UIView button = null)
		{
			Alert(ctrl, UIAlertActionStyle.Default, title, message, handler, button);
		}

		public static void Alert(this UIViewController ctrl, UIAlertActionStyle type, string title, string message, Action handler = null, UIView button = null)
		{
			UIAlertController alert = UIAlertController.Create(title, message, button != null ? UIAlertControllerStyle.ActionSheet : UIAlertControllerStyle.Alert);
			var is8 = UIDevice.CurrentDevice.CheckSystemVersion(8, 0);
			var is9 = UIDevice.CurrentDevice.CheckSystemVersion(9, 0);
			if (!is8 && !is9)
			{
				//show compatible alert/modal for ios < 9.0
				UIAlertView alertView = new UIAlertView(title, message, new AlertDelegate(handler), Resource.Ok, null);
				alertView.Show();

			}
			else {
				if (alert.PopoverPresentationController != null)
				{
					if (button != null)
					{
						alert.PopoverPresentationController.SourceView = button;
						alert.PopoverPresentationController.SourceRect = button.Bounds;
					}
					else {
						alert.PopoverPresentationController.SourceView = ctrl.View;
					}

					alert.PopoverPresentationController.BackgroundColor = UIColor.White;
					alert.PopoverPresentationController.PopoverLayoutMargins = new UIEdgeInsets(10, 5, 5, 5);

				}

				var action = UIAlertAction.Create(Resource.Ok, UIAlertActionStyle.Default, x =>
				{
					if (handler != null)
						handler();
				});

				if (!UserInterfaceIdiomIsPhone && button != null)
				{
					alert.AddAction(UIAlertAction.Create(Resource.Cancel, UIAlertActionStyle.Cancel, x =>
					{
						if (handler != null)
							handler();
					}));
				}


				alert.AddAction(action);
				ctrl.PresentViewController(alert, true, null);
			}

		}

		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public class AlertDelegate : UIAlertViewDelegate
		{
			Action action;

			internal AlertDelegate(Action action)
			{
				this.action = action;
			}

			public override void Canceled(UIAlertView alertView)
			{
				PerformAction();
			}

			public override void Clicked(UIAlertView alertview, nint buttonIndex)
			{
				PerformAction();
			}

			public override void Dismissed(UIAlertView alertView, nint buttonIndex)
			{
				PerformAction();
			}

			void PerformAction()
			{
				if (action != null)
				{
					action();
				}
			}
		}

		public static void Confirm(this UIViewController ctrl, string title, string message, UIView target = null, Action<bool> handler = null)
		{
			var is8 = UIDevice.CurrentDevice.CheckSystemVersion(8, 0);
			if (!is8)
			{
				//show compatible alert/modal for ios < 8
				UIAlertView alertView = new UIAlertView(title, message, new ConfirmDelegate(handler), Resource.Cancel, new string[] { Resource.Ok });
				alertView.Show();

			}
			else {
				UIAlertController alert = UIAlertController.Create(title, message, target != null ? UIAlertControllerStyle.ActionSheet : UIAlertControllerStyle.Alert);

				if (alert.PopoverPresentationController != null)
				{
					if (target != null)
					{
						alert.PopoverPresentationController.SourceView = target;
						alert.PopoverPresentationController.SourceRect = target.Bounds;
					}
					else {
						alert.PopoverPresentationController.SourceView = ctrl.View;
					}
				}

				var ok = UIAlertAction.Create(Resource.Yes, UIAlertActionStyle.Destructive, x =>
				{
					if (handler != null)
						handler(true);
				});

				var cancel = UIAlertAction.Create(Resource.No, UIAlertActionStyle.Default, x =>
				{
					if (handler != null)
						handler(false);
				});

				alert.Title = title;
				alert.Message = message;
				alert.AddAction(cancel);
				alert.AddAction(ok);
				ctrl.PresentViewController(alert, true, () =>
				{
				});
			}

		}

		class ConfirmDelegate : UIAlertViewDelegate
		{
			Action<bool> proceed;

			public ConfirmDelegate(Action<bool> proceed)
			{
				this.proceed = proceed;
			}

			public override void Canceled(UIAlertView alertView)
			{
				if (proceed != null)
				{
					proceed(false);
				}
			}

			void Proceed(UIAlertView alertview)
			{
				if (proceed != null)
				{
					proceed(true);
				}
			}

			public override void Clicked(UIAlertView alertview, nint buttonIndex)
			{
				switch (buttonIndex)
				{
					case 0:
						Canceled(alertview);
						break;
					case 1:
						Proceed(alertview);
						break;
				}
			}
		}

		public static T Bordered<T>(this T view, float width, CGColor color) where T : UIView
		{
			view.Layer.BorderWidth = width;
			view.Layer.BorderColor = color;
			return view;
		}

		public static UIButton PorpoiseButton(this UIButton button)
		{
			bool active = button.Enabled;

			button.Bordered(1f, active ? PorpoiseColors.WhiteTransparency.CGColor : PorpoiseColors.Grey.CGColor);
			button.SetTitleColor(PorpoiseColors.WhiteTransparency, UIControlState.Normal);
			button.SetTitleColor(PorpoiseColors.Grey, UIControlState.Highlighted);
			button.SetTitleColor(UIColor.Gray.ColorWithAlpha(0.5f), UIControlState.Disabled);

			return button;
		}
		
		static Extensions()
		{
			
		}

		public static DateTime NSDateToDateTime(NSDate date)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
				new DateTime(2001, 1, 1, 0, 0, 0));
			return reference.AddSeconds(date.SecondsSinceReferenceDate);
		}
		public static NSDate DateTimeToNSDate(DateTime date)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
				new DateTime(2001, 1, 1, 0, 0, 0));
			return NSDate.FromTimeIntervalSinceReferenceDate(
				(date - reference).TotalSeconds);
		}

		public static NSDate StringToNSDate(string dateString)
		{
			DateTime date = DateTime.Parse(dateString);
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
				new DateTime(2001, 1, 1, 0, 0, 0));

			return NSDate.FromTimeIntervalSinceReferenceDate(
				(date - reference).TotalSeconds);
		}


		public static UITextField ColoredBorder(this UITextField textField, CGColor color)
		{
			textField.Layer.CornerRadius = 0.0f;
			textField.Layer.MasksToBounds = true;
			textField.Layer.BorderColor = color;
			textField.Layer.BorderWidth = 1.0f;
			return textField;
		}

		public static UIImage FromUriToImage(this string uri)
		{
			using (var url = new NSUrl(uri))
			using (var data = NSData.FromUrl(url))
				return UIImage.LoadFromData(data);
		}

		public static void SetDidChangeNotification(this UITextView textView, Action<UITextView> callback)
		{
			if (callback == null)
				throw new ArgumentNullException("callback");

			NSNotificationCenter.DefaultCenter.AddObserver(UITextView.TextDidChangeNotification, _ => callback(textView), textView);
		}

		public static string FormatCurrency(this decimal amount, string currencyCode)
		{

			NSNumberFormatter formatter = new NSNumberFormatter();
			formatter.NumberStyle = NSNumberFormatterStyle.Currency;
			formatter.CurrencyCode = currencyCode;

			return formatter.StringFromNumber((NSNumber)(double)amount);
		}
	}
}

