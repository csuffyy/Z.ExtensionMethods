// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns the sine of the specified angle.
    /// </summary>
    /// <param name="a">An angle, measured in radians.</param>
    /// <returns>The sine of . If  is equal to , , or , this method returns .</returns>
    public static Double Sin(this Double a)
    {
        return Math.Sin(a);
    }
}