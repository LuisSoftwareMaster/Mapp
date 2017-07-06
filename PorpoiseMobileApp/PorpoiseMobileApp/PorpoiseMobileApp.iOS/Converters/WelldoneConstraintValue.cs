using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class WelldoneConstraintValue : IMvxValueConverter
	{

		private string userID;

		public WelldoneConstraintValue(string userID) {

			this.userID = userID;
		}
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = (HourLog)value;

			if (hourLog.PosterId.Equals(this.userID))
			{
				if (hourLog != null && hourLog.WellDones.Length > 0)
				{

					return (nfloat)14;
				}
				else
				{

					Debug.WriteLine("HIDING COMPONENT");
					return (nfloat)0;
				}

			}
			else {
				return (nfloat)14;
			
			}



		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
