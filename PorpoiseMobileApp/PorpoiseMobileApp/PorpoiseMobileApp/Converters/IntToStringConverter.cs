using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
    public class IntToStringConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value != null ? value.ToString() : String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value == null || string.IsNullOrEmpty(value.ToString()) ? (int?)null : (int?)Int32.Parse(value.ToString());
        }
    }
}
