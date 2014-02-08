// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class UIntPtrExtension
{
    /// <summary>
    ///     Adds an offset to the value of an unsigned pointer.
    /// </summary>
    /// <param name="pointer">The unsigned pointer to add the offset to.</param>
    /// <param name="offset">The offset to add.</param>
    /// <returns>A new unsigned pointer that reflects the addition of  to .</returns>
    public static UIntPtr Add(this UIntPtr pointer, Int32 offset)
    {
        return UIntPtr.Add(pointer, offset);
    }
}