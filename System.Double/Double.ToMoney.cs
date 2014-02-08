// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DoubleExtension
{
    /// <summary>
    ///     A Double extension method that converts the @this to a money.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Double.</returns>
    public static Double ToMoney(this Double @this)
    {
        return Math.Round(@this, 2);
    }
}