// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the angle whose sine is the specified number.
    /// </summary>
    /// <param name="d">
    ///     A number representing a sine, where  must be greater than or equal to -1, but less than or equal
    ///     to 1.
    /// </param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?/2 ????/2 -or-  if  &lt; -1 or  &gt; 1 or  equals .
    /// </returns>
    public static Double Asin(this Double d)
    {
        return Math.Asin(d);
    }
}