// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

/// ###
/// <summary>Byte array extension.</summary>
public static partial class ByteArrayExtension
{
    /// <summary>
    ///     A byte[] extension method that resizes the byte[].
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newSize">Size of the new.</param>
    public static byte[] Resize(this byte[] @this, int newSize)
    {
        Array.Resize(ref @this, newSize);
        return @this;
    }
}