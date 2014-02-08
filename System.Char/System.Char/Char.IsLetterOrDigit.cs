// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>true if  is a letter or a decimal digit; otherwise, false.</returns>
    public static Boolean IsLetterOrDigit(this Char c)
    {
        return Char.IsLetterOrDigit(c);
    }
}