using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp
{
	public class OrganisationConverter : IMvxValueConverter
	{
		public OrganisationConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Models.Organisation) {

				return (Models.Organisation)value;
			
			}
			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
