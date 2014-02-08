// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class ArrayExtension
{
    /// <summary>
    ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
    ///     starting at a particular offset.
    /// </summary>
    /// <param name="src">The source buffer.</param>
    /// <param name="srcOffset">The zero-based byte offset into .</param>
    /// <param name="dst">The destination buffer.</param>
    /// <param name="dstOffset">The zero-based byte offset into .</param>
    /// <param name="count">The number of bytes to copy.</param>
    public static void BlockCopy(this Array src, Int32 srcOffset, Array dst, Int32 dstOffset, Int32 count)
    {
        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}