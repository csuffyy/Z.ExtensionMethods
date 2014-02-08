// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class ArrayExtension
{
    /// <summary>
    ///     An Array extension method that clears the array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void ClearAll(this Array @this)
    {
        Array.Clear(@this, 0, @this.Length);
    }
}