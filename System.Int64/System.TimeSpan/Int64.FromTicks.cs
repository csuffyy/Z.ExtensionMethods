// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int64Extension
{
    /// <summary>
    ///     Returns a  that represents a specified time, where the specification is in units of ticks.
    /// </summary>
    /// <param name="value">A number of ticks that represent a time.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromTicks(this Int64 value)
    {
        return TimeSpan.FromTicks(value);
    }
}