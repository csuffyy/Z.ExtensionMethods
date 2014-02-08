// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a control
    ///     character.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a control character; otherwise, false.</returns>
    public static Boolean IsControl(this String s, Int32 index)
    {
        return Char.IsControl(s, index);
    }
}