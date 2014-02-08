// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the remainder resulting from the division of a specified number by another specified number.
    /// </summary>
    /// <param name="x">A dividend.</param>
    /// <param name="y">A divisor.</param>
    /// <returns>
    ///     A number equal to  - ( Q), where Q is the quotient of  /  rounded to the nearest integer (if  /  falls
    ///     halfway between two integers, the even integer is returned).If  - ( Q) is zero, the value +0 is returned if
    ///     is positive, or -0 if  is negative.If  = 0,  is returned.
    /// </returns>
    public static Double IEEERemainder(this Double x, Double y)
    {
        return Math.IEEERemainder(x, y);
    }
}