using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.iOS
{
	public class GiveWelldoneHiddenConverter: IMvxValueConverter
	{
		private string userID;
		public GiveWelldoneHiddenConverter(String userID)
		{

			this.userID = userID;

		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) { 
		
			string posterId = value.ToString();
			//TODO: Remove this

				//if posterId equals logged in user; hidden = false
			if (userID.Equals(posterId))
				{
					return true;
				}
				else {
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
