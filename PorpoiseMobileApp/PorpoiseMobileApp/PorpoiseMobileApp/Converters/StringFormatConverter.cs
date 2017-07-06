using System;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
	public class StringFormatConverter : IMvxValueConverter
	{
		public string Format {
			get;
			set;
		}
		public StringFormatConverter(string format){
			this.Format = format;
		}

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return string.Format(culture, Format, value);
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

	
	}
}

