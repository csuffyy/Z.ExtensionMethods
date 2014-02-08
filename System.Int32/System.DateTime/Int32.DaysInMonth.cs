// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int32Extension
{
    /// <summary>
    ///     Returns the number of days in the specified month and year.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="month">The month (a number ranging from 1 to 12).</param>
    /// <returns>
    ///     The number of days in  for the specified .For example, if  equals 2 for February, the return value is 28 or
    ///     29 depending upon whether  is a leap year.
    /// </returns>
    public static Int32 DaysInMonth(this Int32 year, Int32 month)
    {
        return DateTime.DaysInMonth(year, month);
    }
}