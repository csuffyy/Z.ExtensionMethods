// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class TArrayExtension
{
    /// <summary>
    ///     A T[] extension method that applies an operation to all items in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="action">The action.</param>
    public static void ForEach<T>(this T[] array, Action<T> action)
    {
        Array.ForEach(array, action);
    }
}