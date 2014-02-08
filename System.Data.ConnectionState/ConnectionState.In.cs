// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

public static partial class ConnectionStateExtension
{
    /// <summary>
    ///     A ConnectionState extension method that insert.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool In(this ConnectionState @this, params ConnectionState[] values)
    {
        return values.IndexOf(@this) != -1;
    }
}