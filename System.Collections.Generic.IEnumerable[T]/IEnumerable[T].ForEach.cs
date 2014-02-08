// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

public static partial class IEnumerableExtension
{
    /// <summary>
    ///     Enumerates for each in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
    {
        foreach (T t in @this)
        {
            action(t);
        }
        return @this;
    }
}