// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;
using System.Web;

public static partial class ByteArrayExtension
{
    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified decoding object.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="e">The  that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this Byte[] bytes, Encoding e)
    {
        return HttpUtility.UrlDecode(bytes, e);
    }

    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the
    ///     specified position in the array, and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="offset">The position in the byte to begin decoding.</param>
    /// <param name="count">The number of bytes to decode.</param>
    /// <param name="e">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static String UrlDecode(this Byte[] bytes, Int32 offset, Int32 count, Encoding e)
    {
        return HttpUtility.UrlDecode(bytes, offset, count, e);
    }
}