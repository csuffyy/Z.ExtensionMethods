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
    ///     Converts a string into a URL-encoded array of bytes.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this String str)
    {
        return HttpUtility.UrlEncodeToBytes(str);
    }

    /// <summary>
    ///     Converts a string into a URL-encoded array of bytes using the specified encoding object.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <param name="e">The  that specifies the encoding scheme.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this String str, Encoding e)
    {
        return HttpUtility.UrlEncodeToBytes(str, e);
    }
}