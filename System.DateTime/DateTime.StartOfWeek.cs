// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that starts of week.
    /// </summary>
    /// <param name="dt">The dt to act on.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>.</returns>
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        var start = new DateTime(dt.Year, dt.Month, dt.Day);

        if (start.DayOfWeek != startDayOfWeek)
        {
            int d = startDayOfWeek - start.DayOfWeek;
            if (startDayOfWeek <= start.DayOfWeek)
            {
                return start.AddDays(d);
            }
            else
            {
                return start.AddDays(-7 + d);
            }
        }

        return start;
    }
}