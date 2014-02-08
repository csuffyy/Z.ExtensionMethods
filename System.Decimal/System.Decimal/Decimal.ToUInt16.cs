// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 16-bit unsigned integer.
    /// </summary>
    /// <param name="value">The decimal number to convert.</param>
    /// <returns>A 16-bit unsigned integer equivalent to the value of .</returns>
    public static UInt16 ToUInt16(this Decimal value)
    {
        return Decimal.ToUInt16(value);
    }
}