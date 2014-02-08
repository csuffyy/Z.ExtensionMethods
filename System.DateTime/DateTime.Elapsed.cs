// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that elapsed the given datetime.
    /// </summary>
    /// <param name="datetime">The datetime to act on.</param>
    /// <returns>.</returns>
    public static TimeSpan Elapsed(this DateTime datetime)
    {
        return DateTime.Now - datetime;
    }
}