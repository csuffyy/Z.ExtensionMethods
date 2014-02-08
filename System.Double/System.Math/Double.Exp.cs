// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     Returns e raised to the specified power.
    /// </summary>
    /// <param name="d">A number specifying a power.</param>
    /// <returns>
    ///     The number e raised to the power . If  equals  or , that value is returned. If  equals , 0 is returned.
    /// </returns>
    public static Double Exp(this Double d)
    {
        return Math.Exp(d);
    }
}