// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is a weekend day.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is a weekend day, false if not.</returns>
    public static bool IsWeekendDay(this DateTime @this)
    {
        return (@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
    }
}