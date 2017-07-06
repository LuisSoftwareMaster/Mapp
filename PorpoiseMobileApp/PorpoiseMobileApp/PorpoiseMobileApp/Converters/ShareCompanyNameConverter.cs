using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp
{
	public class ShareCompanyNameConverter : IMvxValueConverter
	{
		

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Models.Organisation) {
				var company = value;
				return "Allow @"+((Models.Organisation)value).Name+" to share to their social accounts?";
			
			}

			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
