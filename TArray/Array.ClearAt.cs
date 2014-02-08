// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class ArrayExtension
{
    /// <summary>
    ///     A T[] extension method that clears at.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="@this">The arrayToClear to act on.</param>
    /// <param name="at">at.</param>
    public static void ClearAt<T>(this T[] @this, int at)
    {
        Array.Clear(@this, at, 1);
    }
}