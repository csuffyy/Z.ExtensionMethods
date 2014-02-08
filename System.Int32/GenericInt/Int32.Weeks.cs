// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

/// ###
/// <summary>Int 32 extension.</summary>
public static partial class Int32Extension
{
    /// <summary>
    ///     An Int32 extension method that weeks the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static TimeSpan Weeks(this Int32 @this)
    {
        return TimeSpan.FromDays(@this*7);
    }
}