// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that ages the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static int Age(this DateTime @this)
    {
        if (DateTime.Today.Month < @this.Month ||
            DateTime.Today.Month == @this.Month &&
            DateTime.Today.Day < @this.Day)
        {
            return DateTime.Today.Year - @this.Year - 1;
        }
        return DateTime.Today.Year - @this.Year;
    }
}