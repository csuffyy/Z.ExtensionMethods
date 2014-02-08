// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant
    ///     culture.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of the  parameter, or the unchanged value of , if  is already lowercase or not
    ///     alphabetic.
    /// </returns>
    public static Char ToLowerInvariant(this Char c)
    {
        return Char.ToLowerInvariant(c);
    }
}