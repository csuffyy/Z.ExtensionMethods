// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class SByteExtension
{
    /// <summary>
    ///     Returns the absolute value of an 8-bit signed integer.
    /// </summary>
    /// <param name="value">A number that is greater than , but less than or equal to .</param>
    /// <returns>An 8-bit signed integer, x, such that 0 ? x ?.</returns>
    public static SByte Abs(this SByte value)
    {
        return Math.Abs(value);
    }
}