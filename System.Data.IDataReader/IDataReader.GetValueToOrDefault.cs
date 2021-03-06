// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, int index)
    {
        try
        {
            return @this.GetValue(index).To<T>();
        }
        catch
        {
            return default(T);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, int index, T defaultValue)
    {
        try
        {
            return @this.GetValue(index).To<T>();
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
    {
        try
        {
            return @this.GetValue(index).To<T>();
        }
        catch
        {
            return defaultValueFactory(@this, index);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName)
    {
        try
        {
            return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
        }
        catch
        {
            return default(T);
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
    {
        try
        {
            return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value to or default.</returns>
    public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
    {
        try
        {
            return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
        }
        catch
        {
            return defaultValueFactory(@this, columnName);
        }
    }
}