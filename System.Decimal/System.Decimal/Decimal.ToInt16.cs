// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 16-bit signed integer.
    /// </summary>
    /// <param name="value">The decimal number to convert.</param>
    /// <returns>A 16-bit signed integer equivalent to .</returns>
    public static Int16 ToInt16(this Decimal value)
    {
        return Decimal.ToInt16(value);
    }
}