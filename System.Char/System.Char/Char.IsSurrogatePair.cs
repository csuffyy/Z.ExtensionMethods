// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Indicates whether the two specified  objects form a surrogate pair.
    /// </summary>
    /// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
    /// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF, and the numeric value of the
    ///     parameter ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static Boolean IsSurrogatePair(this Char highSurrogate, Char lowSurrogate)
    {
        return Char.IsSurrogatePair(highSurrogate, lowSurrogate);
    }
}