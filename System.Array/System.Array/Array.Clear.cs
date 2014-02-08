// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class ArrayExtension
{
    /// <summary>
    ///     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
    /// </summary>
    /// <param name="array">The  whose elements need to be cleared.</param>
    /// <param name="index">The starting index of the range of elements to clear.</param>
    /// <param name="length">The number of elements to clear.</param>
    public static void Clear(this Array array, Int32 index, Int32 length)
    {
        Array.Clear(array, index, length);
    }
}