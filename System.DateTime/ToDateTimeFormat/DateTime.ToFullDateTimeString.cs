// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Globalization;

/// ###
/// <summary>Date time extension.</summary>
public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that converts this object to a full date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToFullDateTimeString(this DateTime @this)
    {
        return @this.ToString("F", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a full date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToFullDateTimeString(this DateTime @this, string culture)
    {
        return @this.ToString("F", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a full date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToFullDateTimeString(this DateTime @this, CultureInfo culture)
    {
        return @this.ToString("F", culture);
    }
}