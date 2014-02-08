// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class CharExtension
{
    /// <summary>
    ///     Converts the specified Unicode character to its equivalent string representation.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The string representation of the value of .</returns>
    public static String ToString(this Char c)
    {
        return Char.ToString(c);
    }
}