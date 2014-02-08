// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A System.DateTime extension method that ends of week.
    /// </summary>
    /// <param name="dt">Date/Time of the dt.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>.</returns>
    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        DateTime end = dt;
        DayOfWeek endDayOfWeek = startDayOfWeek - 1;
        if (endDayOfWeek < 0)
        {
            endDayOfWeek = DayOfWeek.Saturday;
        }

        if (end.DayOfWeek != endDayOfWeek)
        {
            if (endDayOfWeek < end.DayOfWeek)
            {
                end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
            }
            else
            {
                end = end.AddDays(endDayOfWeek - end.DayOfWeek);
            }
        }

        return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
    }
}