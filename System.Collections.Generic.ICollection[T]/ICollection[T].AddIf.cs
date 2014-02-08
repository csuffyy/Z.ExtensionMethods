// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

public static partial class ICollectionExtension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that adds only if the value satisfies the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    /// <param name="value">The value.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
    {
        if (predicate(value))
        {
            @this.Add(value);
            return true;
        }

        return false;
    }
}