// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int32Extension
{
    /// <summary>
    ///     Returns an indication whether the specified year is a leap year.
    /// </summary>
    /// <param name="year">A 4-digit year.</param>
    /// <returns>true if  is a leap year; otherwise, false.</returns>
    public static Boolean IsLeapYear(this Int32 year)
    {
        return DateTime.IsLeapYear(year);
    }
}