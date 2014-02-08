// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Linq;

public static partial class IEnumerableExtension
{
    /// <summary>
    ///     An IEnumerable&lt;T&gt; extension method that query if '@this' contains any.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
    {
// ReSharper disable LoopCanBeConvertedToQuery
        foreach (T value in values)
// ReSharper restore LoopCanBeConvertedToQuery
        {
            if (@this.Contains(value))
            {
                return true;
            }
        }

        return false;
    }
}