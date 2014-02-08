// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the smallest integral value that is greater than or equal to the specified double-precision floating-
    ///     point number.
    /// </summary>
    /// <param name="a">A double-precision floating-point number.</param>
    /// <returns>
    ///     The smallest integral value that is greater than or equal to . If  is equal to , , or , that value is
    ///     returned. Note that this method returns a  instead of an integral type.
    /// </returns>
    public static Double Ceiling(this Double a)
    {
        return Math.Ceiling(a);
    }
}