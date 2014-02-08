// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int64Extension
{
    /// <summary>
    ///     Deserializes a 64-bit binary value and recreates an original serialized  object.
    /// </summary>
    /// <param name="dateData">
    ///     A 64-bit signed integer that encodes the  property in a 2-bit field and the  property in
    ///     a 62-bit field.
    /// </param>
    /// <returns>An object that is equivalent to the  object that was serialized by the  method.</returns>
    public static DateTime FromBinary(this Int64 dateData)
    {
        return DateTime.FromBinary(dateData);
    }
}