using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
	public class DoubleToStringConverter : IMvxValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
            if(value != null && (double) value>= 0){

                return value.ToString();
            
            }
			return String.Empty;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {

                return null;
            
            }
			return (double)Double.Parse(value.ToString());
		}
	}

	public class DoubleCantBe0ToStringConverter : IMvxValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{

			return value != null && (double)value > 0 ? value.ToString() : String.Empty;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value == null || string.IsNullOrEmpty(value.ToString()) ? (double?)null : (double?)Double.Parse(value.ToString());
		}
	}
}
