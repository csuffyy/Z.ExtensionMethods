// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Web;

public static partial class ByteArrayExtension
{
    /// <summary>
    ///     Converts an array of bytes into a URL-encoded array of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this Byte[] bytes)
    {
        return HttpUtility.UrlEncodeToBytes(bytes);
    }

    /// <summary>
    ///     Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array
    ///     and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <param name="offset">The position in the byte array at which to begin encoding.</param>
    /// <param name="count">The number of bytes to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static Byte[] UrlEncodeToBytes(this Byte[] bytes, Int32 offset, Int32 count)
    {
        return HttpUtility.UrlEncodeToBytes(bytes, offset, count);
    }
}