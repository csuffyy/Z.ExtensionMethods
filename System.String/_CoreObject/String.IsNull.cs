// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A T extension method that query if '@this' is null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if null, false if not.</returns>
    public static bool IsNull(this String @this)
    {
        return @this == null;
    }
}