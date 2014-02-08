// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Returns the result of multiplying the specified  value by negative one.
    /// </summary>
    /// <param name="d">The value to negate.</param>
    /// <returns>A decimal number with the value of , but the opposite sign.-or- Zero, if  is zero.</returns>
    public static Decimal Negate(this Decimal d)
    {
        return Decimal.Negate(d);
    }
}