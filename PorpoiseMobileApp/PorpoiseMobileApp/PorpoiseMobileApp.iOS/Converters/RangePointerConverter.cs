using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.iOS
{
	public class RangePointerConverter: IMvxValueConverter
	{
		private Models.Goal goal;
		public RangePointerConverter(Models.Goal goal)
		{
			this.goal = goal;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (nfloat)goal.HoursAgainstGoal;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
