using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class CompanyNameLocationConverter: IMvxValueConverter 
	{
		public CompanyNameLocationConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			HourLog post = (HourLog)value;

			if (post.Location != null)
			{

				return post.Location;

			}
			else
			{
				return post.CompanyName;
			}

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
