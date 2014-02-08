// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int32Extension
{
    /// <summary>
    ///     An Int32 extension method that div rem.
    /// </summary>
    /// <param name="a">a to act on.</param>
    /// <param name="b">The Int32 to process.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>.</returns>
    public static Int32 DivRem(this Int32 a, Int32 b, out Int32 result)
    {
        return Math.DivRem(a, b, out result);
    }
}