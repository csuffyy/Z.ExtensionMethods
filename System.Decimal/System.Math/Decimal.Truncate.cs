// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Calculates the integral part of a specified decimal number.
    /// </summary>
    /// <param name="d">A number to truncate.</param>
    /// <returns>
    ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded.
    /// </returns>
    public static Decimal Truncate(this Decimal d)
    {
        return Math.Truncate(d);
    }
}