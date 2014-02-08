// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Indicates whether the  object at the specified position in a string is a low surrogate.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>
    ///     true if the numeric value of the specified character in the  parameter ranges from U+DC00 through U+DFFF;
    ///     otherwise, false.
    /// </returns>
    public static Boolean IsLowSurrogate(this String s, Int32 index)
    {
        return Char.IsLowSurrogate(s, index);
    }
}