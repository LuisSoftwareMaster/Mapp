using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class GivenWelldoneTextHidden: IMvxValueConverter
	{

		private string userID;
		public GivenWelldoneTextHidden(string userID)
		{
			this.userID = userID;	
		}

		public object Convert(object value,Type targetType, object parameter, CultureInfo culture) { 
		
			var posterId = (HourLog)value;

			Debug.WriteLine("POSTER ID IN CONVERTER: "+posterId+", USERID: "+AccountInfo.UserId.ToString());

		
			if (posterId.PosterId.Equals(userID) && posterId.WellDones.Length == 0)
			{

				return true;

			}
			else {

				return false;
			
			}

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) { 
		
		throw new NotImplementedException();

		}

	}
}
