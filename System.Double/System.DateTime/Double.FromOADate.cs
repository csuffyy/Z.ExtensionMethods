// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns a  equivalent to the specified OLE Automation Date.
    /// </summary>
    /// <param name="d">An OLE Automation Date value.</param>
    /// <returns>An object that represents the same date and time as .</returns>
    public static DateTime FromOADate(this Double d)
    {
        return DateTime.FromOADate(d);
    }
}