// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class TimeSpanExtension
{
    /// <summary>
    ///     A TimeSpan extension method that substract the specified TimeSpan to the current UTC (Coordinated Universal
    ///     Time)
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan substracted from it.</returns>
    public static DateTime UtcAgo(this TimeSpan @this)
    {
        return DateTime.UtcNow.Subtract(@this);
    }
}