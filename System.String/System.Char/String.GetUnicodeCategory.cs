// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Globalization;

public static partial class StringExtension
{
    /// <summary>
    ///     Categorizes the character at the specified position in a specified string into a group identified by one of
    ///     the  values.
    /// </summary>
    /// <param name="s">A .</param>
    /// <param name="index">The character position in .</param>
    /// <returns>A  enumerated constant that identifies the group that contains the character at position  in .</returns>
    public static UnicodeCategory GetUnicodeCategory(this String s, Int32 index)
    {
        return Char.GetUnicodeCategory(s, index);
    }
}