// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class SingleExtension
{
    /// <summary>
    ///     Returns a value indicating the sign of a single-precision floating-point number.
    /// </summary>
    /// <param name="value">A signed number.</param>
    /// <returns>
    ///     A number that indicates the sign of , as shown in the following table.Return value Meaning -1  is less than
    ///     zero. 0  is equal to zero. 1  is greater than zero.
    /// </returns>
    public static Int32 Sign(this Single value)
    {
        return Math.Sign(value);
    }
}