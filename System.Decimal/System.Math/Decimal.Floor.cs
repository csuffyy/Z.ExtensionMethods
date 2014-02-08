// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Returns the largest integer less than or equal to the specified decimal number.
    /// </summary>
    /// <param name="d">A decimal number.</param>
    /// <returns>
    ///     The largest integer less than or equal to .  Note that the method returns an integral value of type .
    /// </returns>
    public static Decimal Floor(this Decimal d)
    {
        return Math.Floor(d);
    }
}