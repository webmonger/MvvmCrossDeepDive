using System;
using Foundation;

namespace MvvmCrossMenu.Touch
{
	public static class DateExtensions
	{
		public static DateTime NSDateToDateTime(this NSDate date)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime( 
				new DateTime(2001, 1, 1, 0, 0, 0) );
			return reference.AddSeconds(date.SecondsSinceReferenceDate);
		}

		public static NSDate DateTimeToNSDate(this DateTime date)
		{
			DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
				new DateTime(2001, 1, 1, 0, 0, 0) );
			return NSDate.FromTimeIntervalSinceReferenceDate(
				(date - reference).TotalSeconds);
		}
	}
}

