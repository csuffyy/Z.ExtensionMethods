// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 64-bit signed integer.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A 64-bit signed integer equivalent to the value of .</returns>
    public static Int64 ToInt64(this Decimal d)
    {
        return Decimal.ToInt64(d);
    }
}