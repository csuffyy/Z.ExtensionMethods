// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

public static partial class ICollectionExtension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes range item that satisfy the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void RemoveRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
    {
        foreach (T value in values)
        {
            if (predicate(value))
            {
                @this.Remove(value);
            }
        }
    }
}