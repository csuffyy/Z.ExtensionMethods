// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Computes the remainder after dividing two  values.
    /// </summary>
    /// <param name="d1">The dividend.</param>
    /// <param name="d2">The divisor.</param>
    /// <returns>The remainder after dividing  by .</returns>
    public static Decimal Remainder(this Decimal d1, Decimal d2)
    {
        return Decimal.Remainder(d1, d2);
    }
}