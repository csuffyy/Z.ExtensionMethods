// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns a value that indicates whether the specified value is not a number ().
    /// </summary>
    /// <param name="d">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to ; otherwise, false.</returns>
    public static Boolean IsNaN(this Double d)
    {
        return Double.IsNaN(d);
    }
}