// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent double-precision floating-point number.
    /// </summary>
    /// <param name="d">The decimal number to convert.</param>
    /// <returns>A double-precision floating-point number equivalent to .</returns>
    public static Double ToDouble(this Decimal d)
    {
        return Decimal.ToDouble(d);
    }
}