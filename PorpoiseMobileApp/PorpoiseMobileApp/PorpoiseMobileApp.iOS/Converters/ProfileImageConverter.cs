using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class ProfileImageConverter:IMvxValueConverter
	{
		public ProfileImageConverter()
		{
		}


		object IMvxValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			var hourLog = (HourLog)value;


			if (hourLog != null)
			{

				if (hourLog.ProfileImage != null && !hourLog.ProfileImage.Trim().Equals(""))
				{

					Debug.WriteLine("Poster "+hourLog.EmployeeName+ " imagename "+hourLog.ProfileImage);

					return hourLog.ProfileImage;

				}
				else
				{

					return "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/noImage.png";

				}

			}

			return "https://s3.amazonaws.com/porpoise-cdn/mobile-assets/noImage.png";
		}

		object IMvxValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
