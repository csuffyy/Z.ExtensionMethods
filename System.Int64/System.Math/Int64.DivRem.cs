// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int64Extension
{
    /// <summary>
    ///     An Int64 extension method that div rem.
    /// </summary>
    /// <param name="a">a to act on.</param>
    /// <param name="b">The Int64 to process.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>.</returns>
    public static Int64 DivRem(this Int64 a, Int64 b, out Int64 result)
    {
        return Math.DivRem(a, b, out result);
    }
}