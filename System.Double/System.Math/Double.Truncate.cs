// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Calculates the integral part of a specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A number to truncate.</param>
    /// <returns>
    ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded, or
    ///     one of the values listed in the following table. Return value.
    /// </returns>
    public static Double Truncate(this Double d)
    {
        return Math.Truncate(d);
    }
}