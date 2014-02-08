// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index)
    {
        try
        {
            return (T) @this.GetValue(index);
        }
        catch
        {
            return default(T);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, T defaultValue)
    {
        try
        {
            return (T) @this.GetValue(index);
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
    {
        try
        {
            return (T) @this.GetValue(index);
        }
        catch
        {
            return defaultValueFactory(@this, index);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName)
    {
        try
        {
            return (T) @this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return default(T);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
    {
        try
        {
            return (T) @this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value as or default.</returns>
    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
    {
        try
        {
            return (T) @this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return defaultValueFactory(@this, columnName);
        }
    }
}