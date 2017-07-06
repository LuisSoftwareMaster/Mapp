using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class EmployeeIdConverter: IMvxValueConverter
	{
		public EmployeeIdConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			var hourLog = (HourLog)value;

			Debug.WriteLine("RETURNING ID: "+hourLog.EmployeeName);

			return hourLog.EmployeeName;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
