namespace Vdias.ExpenseTracker.Extensions
{
    using System;

    /// <summary>
    /// Extension methods for the DateTimeOffset object.
    /// </summary>
    public static class DateTimeOffsetExtension
    {
        /// <summary>
        /// Returns a new <see chref="DateTimeOffset"/> with the same day, month and year but with
        /// the hours, minutes, seconds and milliseconds equal to zero.
        /// </summary>
        /// <param name="date">The date to be converted</param>
        /// <returns>A new date with values of the given date but at the start of the day</returns>
        public static DateTimeOffset StartOfDay(this DateTimeOffset date)
        {
            return new DateTimeOffset(date.Year, date.Month, date.Day, 0, 0, 0, 0, date.Offset);
        }

        /// <summary>
        /// Returns a new <see chref="DateTimeOffset"/> with the same day, month and year but with
        /// the hours, minutes, seconds and milliseconds equal their maximum allowed value.
        /// </summary>
        /// <param name="date">The date to be converted</param>
        /// <returns>A new date with values of the given date but at the end of the day</returns>
        public static DateTimeOffset EndOfDay(this DateTimeOffset date)
        {
            return new DateTimeOffset(date.Year, date.Month, date.Day, 23, 59, 59, 999, date.Offset);
        }
    }
}