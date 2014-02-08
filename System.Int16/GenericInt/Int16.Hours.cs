// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

/// ###
/// <summary>Int 16 extension.</summary>
public static partial class Int16Extension
{
    /// <summary>
    ///     An Int16 extension method that hours the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static TimeSpan Hours(this Int16 @this)
    {
        return TimeSpan.FromHours(@this);
    }
}