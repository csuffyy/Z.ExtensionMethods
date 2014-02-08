// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Indicates whether the specified  object is a low surrogate.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static Boolean IsLowSurrogate(this Char c)
    {
        return Char.IsLowSurrogate(c);
    }
}