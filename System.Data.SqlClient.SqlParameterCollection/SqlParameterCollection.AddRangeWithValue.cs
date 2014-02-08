// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data.SqlClient;

public static class SqlParameterCollectionExtension
{
    /// <summary>
    ///     A SqlParameterCollection extension method that adds a range with value to 'values'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">The values.</param>
    public static void AddRangeWithValue(this SqlParameterCollection @this, Dictionary<string, object> values)
    {
        foreach (var keyValuePair in values)
        {
            @this.AddWithValue(keyValuePair.Key, keyValuePair.Value);
        }
    }
}