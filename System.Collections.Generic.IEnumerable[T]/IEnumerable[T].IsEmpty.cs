// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Linq;

public static partial class IEnumerableExtension
{
    /// <summary>
    ///     An IEnumerable&lt;T&gt; extension method that query if 'collection' is empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    public static bool IsEmpty<T>(this IEnumerable<T> collection)
    {
        return !collection.Any();
    }
}