// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

/// ###
/// <summary>Byte array extension.</summary>
public static partial class ByteArrayExtension
{
    /// <summary>
    ///     A byte[] extension method that converts the @this to a memory stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a MemoryStream.</returns>
    public static MemoryStream ToMemoryStream(this byte[] @this)
    {
        return new MemoryStream(@this);
    }
}