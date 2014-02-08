// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that gets value as.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>The value as.</returns>
    public static T GetValueAs<T>(this IDataReader @this, int index)
    {
        return (T) @this.GetValue(index);
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>The value as.</returns>
    public static T GetValueAs<T>(this IDataReader @this, string columnName)
    {
        return (T) @this.GetValue(@this.GetOrdinal(columnName));
    }
}