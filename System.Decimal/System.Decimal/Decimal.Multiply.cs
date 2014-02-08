// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Multiplies two specified  values.
    /// </summary>
    /// <param name="d1">The multiplicand.</param>
    /// <param name="d2">The multiplier.</param>
    /// <returns>The result of multiplying  and .</returns>
    public static Decimal Multiply(this Decimal d1, Decimal d2)
    {
        return Decimal.Multiply(d1, d2);
    }
}