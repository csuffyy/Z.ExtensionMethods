// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the hyperbolic tangent of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>
    ///     The hyperbolic tangent of . If  is equal to , this method returns -1. If value is equal to , this method
    ///     returns 1. If  is equal to , this method returns .
    /// </returns>
    public static Double Tanh(this Double value)
    {
        return Math.Tanh(value);
    }
}