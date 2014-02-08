// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

public static class IDbConnectionExtension
{
    /// <summary>
    ///     An IDbConnection extension method that ensures that open.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void EnsureOpen(this IDbConnection @this)
    {
        if (@this.State == ConnectionState.Closed)
        {
            @this.Open();
        }
    }
}