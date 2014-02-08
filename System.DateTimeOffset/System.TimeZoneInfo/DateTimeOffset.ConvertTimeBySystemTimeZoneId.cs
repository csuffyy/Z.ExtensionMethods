// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DateTimeOffsetExtension
{
    /// <summary>
    ///     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
    /// </summary>
    /// <param name="dateTimeOffset">The date and time to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset, String destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
    }
}