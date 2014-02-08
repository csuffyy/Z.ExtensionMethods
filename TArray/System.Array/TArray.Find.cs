// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class TArrayExtension
{
    /// <summary>
    ///     A T[] extension method that searches for the first match.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>.</returns>
    public static T Find<T>(this T[] array, Predicate<T> match)
    {
        return Array.Find(array, match);
    }
}