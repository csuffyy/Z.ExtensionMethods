// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the absolute value of a double-precision floating-point number.
    /// </summary>
    /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A double-precision floating-point number, x, such that 0 ? x ?.</returns>
    public static Double Abs(this Double value)
    {
        return Math.Abs(value);
    }
}