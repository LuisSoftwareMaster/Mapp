using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
    public class OneWayConverter<T> : IMvxValueConverter
    {
        private Func<T, object> conversion;

        public OneWayConverter(Func<T, object> conversion)
        {
            this.conversion = conversion;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return conversion((T)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
