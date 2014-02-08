// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class TArrayExtension
{
    /// <summary>
    ///     A T[] extension method that searches for the first last.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="array">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found last.</returns>
    public static T FindLast<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindLast(array, match);
    }
}