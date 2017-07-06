using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class NoPhotoPostBackgroundColorConverter : IMvxValueConverter
	{




		object IMvxValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var post = (Models.HourLog)value;

			if (post.MediaType.Equals("none"))
			{
				//view.Hidden=true;

				string color = post.BackgroundColor.Replace("#", "");

				int intColor = Convert.ToInt32(color, 16);

				return PorpoiseColors.FromHex(intColor);

			}


			return PorpoiseColors.FromHex(0x000000);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
