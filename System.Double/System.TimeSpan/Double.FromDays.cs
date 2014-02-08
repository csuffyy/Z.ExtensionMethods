// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns a  that represents a specified number of days, where the specification is accurate to the nearest
    ///     millisecond.
    /// </summary>
    /// <param name="value">A number of days, accurate to the nearest millisecond.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromDays(this Double value)
    {
        return TimeSpan.FromDays(value);
    }
}