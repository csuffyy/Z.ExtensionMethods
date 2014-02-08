// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is morning.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if morning, false if not.</returns>
    public static bool IsMorning(this DateTime @this)
    {
        return @this.TimeOfDay < new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
    }
}