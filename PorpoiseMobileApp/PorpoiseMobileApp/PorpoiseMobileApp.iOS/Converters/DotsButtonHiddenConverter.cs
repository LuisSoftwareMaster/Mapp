using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.iOS.Converters
{
    public class DotsButtonHiddenConverter: IMvxValueConverter
    {
		private string userID;

		public DotsButtonHiddenConverter(string userID)
		{

			this.userID = userID;


		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string posterId = value.ToString();

			//if posterId equals logged in user; hidden = false
			if (posterId.Equals(userID))
			{
				return true;
			}
			else
			{
                //hidden = true;
                return false;
			}


		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
    }
}
