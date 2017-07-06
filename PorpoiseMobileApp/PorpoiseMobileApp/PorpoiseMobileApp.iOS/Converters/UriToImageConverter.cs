using System;
using Foundation;
using MvvmCross.Platform.Converters;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class UriToImageConverter : IMvxValueConverter
	{

		#region IMvxValueConverter implementation

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{Console.WriteLine("IMAGE URL "+value.ToString());

			if (!value.ToString().Equals("https://s3.amazonaws.com/porpoise-cdn/temp_profile_image.png"))
			{
				using (var url = new NSUrl(value.ToString()))
				using (var data = NSData.FromUrl(url))
					return UIImage.LoadFromData(data);
			}
			else{

                return Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/noImage.png");

			}

		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion


	}
}

