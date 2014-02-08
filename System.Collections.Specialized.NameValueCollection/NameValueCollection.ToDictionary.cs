// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Collections.Specialized;

public static class NameValueCollectionExtension
{
    /// <summary>
    ///     A NameValueCollection extension method that converts the @this to a dictionary.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IDictionary&lt;string,object&gt;</returns>
    public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
    {
        var dict = new Dictionary<string, object>();

        if (@this != null)
        {
            foreach (string key in @this.AllKeys)
            {
                dict.Add(key, @this[key]);
            }
        }

        return dict;
    }
}