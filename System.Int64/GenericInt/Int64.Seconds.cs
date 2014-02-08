// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

/// ###
/// <summary>Int 64 extension.</summary>
public static partial class Int64Extension
{
    /// <summary>
    ///     An Int64 extension method that seconds the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static TimeSpan Seconds(this Int64 @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}