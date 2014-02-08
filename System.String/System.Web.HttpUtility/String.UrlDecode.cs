// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;
using System.Web;

public static partial class StringExtension
{
    /// <summary>
    ///     Converts a string that has been encoded for transmission in a URL into a decoded string.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this String str)
    {
        return HttpUtility.UrlDecode(str);
    }

    /// <summary>
    ///     Converts a URL-encoded string into a decoded string, using the specified encoding object.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <param name="e">The  that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this String str, Encoding e)
    {
        return HttpUtility.UrlDecode(str, e);
    }
}