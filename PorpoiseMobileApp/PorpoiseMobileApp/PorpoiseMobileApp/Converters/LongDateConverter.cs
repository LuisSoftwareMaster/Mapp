using System;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
	public class LongDateConverter : IMvxValueConverter
	{
		public string Format
		{
			get;
			set;
		}

		public LongDateConverter(string format = "")
		{
			if (!string.IsNullOrEmpty(format))
			{
				this.Format = format;
			}
		}

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (!string.IsNullOrEmpty(Format))
			{
				return ((DateTime)value).ToString(Format, culture);
			}
			else
			{
				return ((DateTime)value).ToString("MMMM dd yyyy", culture);
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			
			throw new NotImplementedException();
		}

		//public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		//{
		//	if (!string.IsNullOrEmpty(Format))
		//	{
		//		return DateTime.ParseExact(value.ToString(), Format, culture);
		//	}
		//	else if (!string.IsNullOrEmpty(value.ToString()))
		//	{
		//		try
		//		{
		//			var dt = DateTime.Parse(value.ToString());
		//			return dt.ToString("MMMM dd, yyyy");
		//		}
		//		catch (Exception ex)
		//		{
		//			throw;
		//		}
		//	}
		//	else {
		//		return value;
		//	}
		//}
	}
}