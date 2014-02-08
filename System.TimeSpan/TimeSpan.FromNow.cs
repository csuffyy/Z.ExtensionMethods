// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class TimeSpanExtension
{
    /// <summary>
    ///     A TimeSpan extension method that add the specified TimeSpan to the current DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current DateTime with the specified TimeSpan added to it.</returns>
    public static DateTime FromNow(this TimeSpan @this)
    {
        return DateTime.Now.Add(@this);
    }
}