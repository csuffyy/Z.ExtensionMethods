// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Drawing;
using System.IO;

/// ###
/// <summary>Byte array extension.</summary>
public static partial class ByteArrayExtension
{
    /// <summary>
    ///     A byte[] extension method that converts the @this to an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an Image.</returns>
    public static Image ToImage(this byte[] @this)
    {
        using (var ms = new MemoryStream(@this))
        {
            return Image.FromStream(ms);
        }
    }
}