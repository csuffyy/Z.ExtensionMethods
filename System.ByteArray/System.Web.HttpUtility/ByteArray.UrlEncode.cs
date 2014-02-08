// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Web;

public static partial class ByteArrayExtension
{
    /// <summary>
    ///     Converts a byte array into an encoded URL string.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String UrlEncode(this Byte[] bytes)
    {
        return HttpUtility.UrlEncode(bytes);
    }

    /// <summary>
    ///     Converts a byte array into a URL-encoded string, starting at the specified position in the array and
    ///     continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <param name="offset">The position in the byte array at which to begin encoding.</param>
    /// <param name="count">The number of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String UrlEncode(this Byte[] bytes, Int32 offset, Int32 count)
    {
        return HttpUtility.UrlEncode(bytes, offset, count);
    }
}