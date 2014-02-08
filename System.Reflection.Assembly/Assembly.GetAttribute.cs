// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

public static partial class AssemblyExtension
{
    /// <summary>
    ///     An Assembly extension method that gets an attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The attribute.</returns>
    public static T GetAttribute<T>(this Assembly @this) where T : Attribute
    {
        object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof (T), false);

        if (configAttributes != null && configAttributes.Length > 0)
        {
            return (T) configAttributes[0];
        }

        return null;
    }
}