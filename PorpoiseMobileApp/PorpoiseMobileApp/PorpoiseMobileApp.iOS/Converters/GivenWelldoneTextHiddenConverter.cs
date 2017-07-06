using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.iOS
{
	public class GivenWelldoneTextHiddenConverter : IMvxValueConverter
	{
		private string userId;
		public GivenWelldoneTextHiddenConverter(String id)
		{
			this.userId = id;

		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var post = (Models.HourLog)value;

			if (post != null) {

				if (post.PosterId.Equals(this.userId))
				{

					if (post.WellDones.Length > 0) {

						return false;
					
					}


				}
				else {

					return false;
				
				}
			
			}

			return true;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
