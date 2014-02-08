// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DecimalExtension
{
    /// <summary>
    ///     Subtracts one specified  value from another.
    /// </summary>
    /// <param name="d1">The minuend.</param>
    /// <param name="d2">The subtrahend.</param>
    /// <returns>The result of subtracting  from .</returns>
    public static Decimal Subtract(this Decimal d1, Decimal d2)
    {
        return Decimal.Subtract(d1, d2);
    }
}