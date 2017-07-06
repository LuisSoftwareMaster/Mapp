using System;
using System.Globalization;
using CoreGraphics;
using MvvmCross.Platform.Converters;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class NoPostViewSizeCconverter : IMvxValueConverter
	{
		UIView view;
		public NoPostViewSizeCconverter(UIView view)
		{
			this.view = view;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			

			return new CGRect(view.Bounds.X, view.Bounds.Y, view.Bounds.Width, 80);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
