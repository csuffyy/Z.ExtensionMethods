// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Globalization;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     Returns a value indicating whether the specified date and time is within the specified daylight saving time
    ///     period.
    /// </summary>
    /// <param name="time">A date and time.</param>
    /// <param name="daylightTimes">A daylight saving time period.</param>
    /// <returns>true if  is in ; otherwise, false.</returns>
    public static Boolean IsDaylightSavingTime(this DateTime time, DaylightTime daylightTimes)
    {
        return TimeZone.IsDaylightSavingTime(time, daylightTimes);
    }
}