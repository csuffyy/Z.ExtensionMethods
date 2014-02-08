// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns a value indicating whether the specified number evaluates to positive infinity.
    /// </summary>
    /// <param name="d">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to ; otherwise, false.</returns>
    public static Boolean IsPositiveInfinity(this Double d)
    {
        return Double.IsPositiveInfinity(d);
    }
}