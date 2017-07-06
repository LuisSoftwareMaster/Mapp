using System;
using MvvmCross.Platform.Converters;
using System.Globalization;
using System;
using MvvmCross.Platform.Converters;
using System.Globalization;
using Foundation;

namespace PorpoiseMobileApp.iOS
{
	public class DateToNSDateConverter : MvxValueConverter<NSDate, DateTime>
	{
		public DateToNSDateConverter()
		{

		}
		protected override DateTime Convert(NSDate date, Type targetType, object parameter, CultureInfo culture)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(2001, 1, 1, 0, 0, 0));
			return reference.AddSeconds(date.SecondsSinceReferenceDate);
		}
		protected override NSDate ConvertBack(DateTime date, Type targetType, object parameter, CultureInfo culture)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(2001, 1, 1, 0, 0, 0));
			return NSDate.FromTimeIntervalSinceReferenceDate((date - reference).TotalSeconds);
		}

		//public static DateTime NSDateToDateTime(NSDate date)
		//{
		//    DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
		//        new DateTime(2001, 1, 1, 0, 0, 0));
		//    return reference.AddSeconds(date.SecondsSinceReferenceDate);
		//}
		//public static NSDate DateTimeToNSDate(DateTime date)
		//{
		//    DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
		//        new DateTime(2001, 1, 1, 0, 0, 0));
		//    return NSDate.FromTimeIntervalSinceReferenceDate(
		//        (date - reference).TotalSeconds);
		//}
	}
}

