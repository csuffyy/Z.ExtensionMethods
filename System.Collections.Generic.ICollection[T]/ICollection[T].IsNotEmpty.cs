// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

public static partial class ICollectionExtension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that query if the collection is not empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if not empty&lt; t&gt;, false if not.</returns>
    public static bool IsNotEmpty<T>(this ICollection<T> @this)
    {
        return @this.Count != 0;
    }
}