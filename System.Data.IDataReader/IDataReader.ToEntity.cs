// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data;
using System.Reflection;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that converts the @this to an entity.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a T.</returns>
    public static T ToEntity<T>(this IDataReader @this) where T : new()
    {
        Type type = typeof (T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var entity = new T();

        foreach (PropertyInfo property in properties)
        {
            if (@this[property.Name] != null)
            {
                Type valueType = property.PropertyType;
                property.SetValue(entity, @this[property.Name].To(valueType), null);
            }
        }

        foreach (FieldInfo field in fields)
        {
            if (@this[field.Name] != null)
            {
                Type valueType = field.FieldType;
                field.SetValue(entity, @this[field.Name].To(valueType));
            }
        }

        return entity;
    }
}