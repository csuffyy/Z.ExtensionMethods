// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class UInt32Extension
{
    /// <summary>
    ///     Returns the larger of two 32-bit unsigned integers.
    /// </summary>
    /// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
    /// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static UInt32 Max(this UInt32 val1, UInt32 val2)
    {
        return Math.Max(val1, val2);
    }
}