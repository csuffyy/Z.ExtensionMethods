// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class UInt64Extension
{
    /// <summary>
    ///     A T extension method to determines whether the object is not equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The value list to compare with the object.</param>
    /// <returns>true if the values list doesn't contains the object, else false.</returns>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static bool NotIn(this UInt64 @this, params UInt64[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}