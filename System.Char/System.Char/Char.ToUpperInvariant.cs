// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant
    ///     culture.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The uppercase equivalent of the  parameter, or the unchanged value of , if  is already uppercase or not
    ///     alphabetic.
    /// </returns>
    public static Char ToUpperInvariant(this Char c)
    {
        return Char.ToUpperInvariant(c);
    }
}