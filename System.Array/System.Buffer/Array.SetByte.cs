// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class ArrayExtension
{
    /// <summary>
    ///     Assigns a specified value to a byte at a particular location in a specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <param name="index">A location in the array.</param>
    /// <param name="value">A value to assign.</param>
    public static void SetByte(this Array array, Int32 index, Byte value)
    {
        Buffer.SetByte(array, index, value);
    }
}