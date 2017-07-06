using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class GivenWelldoneImageConverter: IMvxValueConverter
	{
		public GivenWelldoneImageConverter()
		{
		}

		public object Convert(object value,Type targetType, object parameter, CultureInfo culture) { 
		
			if (!string.IsNullOrEmpty(value.ToString()))
			{
				
				var hourLog = value as HourLog;
				//var wellDones = values as []Welldones
				//if posterId equals logged in user; hidden = false
				if (hourLog!= null && hourLog.WellDones.Length>0)
				{
					Debug.WriteLine("WELL DONES NOT HIDDEN GIVENWELLDONE IMAGE");

					return false;
				}
				else {
					//hidden = true;
					return true;
				}

			}
			return true;
		
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) { 
		
		throw new NotImplementedException();

		}

	}
}
