// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class SingleExtension
{
    /// <summary>
    ///     Returns a value that indicates whether the specified value is not a number ().
    /// </summary>
    /// <param name="f">A single-precision floating-point number.</param>
    /// <returns>true if  evaluates to not a number (); otherwise, false.</returns>
    public static Boolean IsNaN(this Single f)
    {
        return Single.IsNaN(f);
    }
}