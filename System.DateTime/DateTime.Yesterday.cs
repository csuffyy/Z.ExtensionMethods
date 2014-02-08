// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that yesterdays the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>Yesterday date at same time.</returns>
    public static DateTime Yesterday(this DateTime @this)
    {
        return @this.AddDays(-1);
    }
}