// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

public static partial class StringExtension
{
    /// <summary>
    ///     Parses a query string into a  using  encoding.
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this String query)
    {
        return HttpUtility.ParseQueryString(query);
    }

    /// <summary>
    ///     Parses a query string into a  using the specified .
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <param name="encoding">The  to use.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this String query, Encoding encoding)
    {
        return HttpUtility.ParseQueryString(query, encoding);
    }
}