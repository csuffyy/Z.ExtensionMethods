// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int32Extension
{
    /// <summary>
    ///     Returns the absolute value of a 32-bit signed integer.
    /// </summary>
    /// <param name="value">A number that is greater than , but less than or equal to .</param>
    /// <returns>A 32-bit signed integer, x, such that 0 ? x ?.</returns>
    public static Int32 Abs(this Int32 value)
    {
        return Math.Abs(value);
    }
}