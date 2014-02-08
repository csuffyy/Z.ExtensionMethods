// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Indicates whether the specified character has a surrogate code unit.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>true if  is either a high surrogate or a low surrogate; otherwise, false.</returns>
    public static Boolean IsSurrogate(this Char c)
    {
        return Char.IsSurrogate(c);
    }
}