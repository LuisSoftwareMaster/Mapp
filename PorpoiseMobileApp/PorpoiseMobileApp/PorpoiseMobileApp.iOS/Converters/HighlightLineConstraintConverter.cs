using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class HighlightLineConstraintConverter: IMvxValueConverter
	{
		private string userID;
		public HighlightLineConstraintConverter(string userID)
		{
			this.userID = userID;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = (HourLog)value;

			if (hourLog.PosterId.Equals(userID))
			{
				if (hourLog != null && hourLog.WellDones.Length > 0)
				{
					return (nfloat)31;
				}
				else
				{

					Debug.WriteLine("HIDING COMPONENT");

					return (nfloat)8;
				}

			}
			else
			{

				return (nfloat)31;

			}

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
