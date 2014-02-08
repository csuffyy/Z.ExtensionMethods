// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Creates a new instance of  with the same value as a specified .
    /// </summary>
    /// <param name="str">The string to copy.</param>
    /// <returns>A new string with the same value as .</returns>
    public static String Copy(this String str)
    {
        return String.Copy(str);
    }
}