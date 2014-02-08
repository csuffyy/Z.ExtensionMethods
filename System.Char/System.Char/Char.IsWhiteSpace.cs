// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Indicates whether the specified Unicode character is categorized as white space.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>true if  is white space; otherwise, false.</returns>
    public static Boolean IsWhiteSpace(this Char c)
    {
        return Char.IsWhiteSpace(c);
    }
}