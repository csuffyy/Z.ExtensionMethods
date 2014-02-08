// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a
    ///     Unicode code point.
    /// </summary>
    /// <param name="s">A string that contains a character or surrogate pair.</param>
    /// <param name="index">The index position of the character or surrogate pair in .</param>
    /// <returns>
    ///     The 21-bit Unicode code point represented by the character or surrogate pair at the position in the
    ///     parameter specified by the  parameter.
    /// </returns>
    public static Int32 ConvertToUtf32(this String s, Int32 index)
    {
        return Char.ConvertToUtf32(s, index);
    }
}