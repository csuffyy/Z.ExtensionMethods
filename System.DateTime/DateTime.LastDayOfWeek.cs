// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that last day of week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static DateTime LastDayOfWeek(this DateTime @this)
    {
        return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(6 - (int) @this.DayOfWeek);
    }
}