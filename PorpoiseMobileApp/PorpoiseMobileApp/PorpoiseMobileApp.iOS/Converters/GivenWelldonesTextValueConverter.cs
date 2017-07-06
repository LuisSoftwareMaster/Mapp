using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.iOS
{
	public class GivenWelldonesTextValueConverter: IMvxValueConverter
	{
		public GivenWelldonesTextValueConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			
			var hourLog = value as Models.Welldones[];

			if (hourLog != null && hourLog.Length > 1)
			{

				String attributed = (hourLog.Length.ToString()) + " People gave a Well Done!";

				attributed = attributed.Trim();

				Debug.WriteLine("CONVERTER: " + removeSpaces(attributed));

				return attributed;

			}
			else if(hourLog != null && hourLog.Length == 1){ 
			
				String attributed = (hourLog.Length.ToString()) + " Person gave a Well Done!";

				attributed = attributed.Trim();

				Debug.WriteLine("CONVERTER: " + removeSpaces(attributed));

				return attributed;
			
			}



			return "Be the first to give a Well Done!";

		
		}

		private String removeSpaces(String input) {

			String previous = "";

			String result = "";

			for (int i = 0; i < input.Length; i++) {

				if (!input[i].Equals(" ") && !previous.Equals(" "))
				{

					result = result + input[i].ToString();

				}

				previous = input[i].ToString();
			
			}

			return result;
		
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
