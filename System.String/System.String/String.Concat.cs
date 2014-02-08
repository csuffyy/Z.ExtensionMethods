// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Concatenates two specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <returns>The concatenation of  and .</returns>
    public static String Concat(this String str0, String str1)
    {
        return String.Concat(str0, str1);
    }

    /// <summary>
    ///     Concatenates three specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <returns>The concatenation of , , and .</returns>
    public static String Concat(this String str0, String str1, String str2)
    {
        return String.Concat(str0, str1, str2);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <param name="str3">The fourth string to concatenate.</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static String Concat(this String str0, String str1, String str2, String str3)
    {
        return String.Concat(str0, str1, str2, str3);
    }
}