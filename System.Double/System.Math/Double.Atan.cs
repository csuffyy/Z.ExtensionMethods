// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the angle whose tangent is the specified number.
    /// </summary>
    /// <param name="d">A number representing a tangent.</param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?/2 ????/2.-or-  if  equals , -?/2 rounded to double precision (-
    ///     1.5707963267949) if  equals , or ?/2 rounded to double precision (1.5707963267949) if  equals .
    /// </returns>
    public static Double Atan(this Double d)
    {
        return Math.Atan(d);
    }
}