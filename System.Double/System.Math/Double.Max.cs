// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the larger of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
    /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
    /// <returns>Parameter  or , whichever is larger. If , , or both  and  are equal to ,  is returned.</returns>
    public static Double Max(this Double val1, Double val2)
    {
        return Math.Max(val1, val2);
    }
}