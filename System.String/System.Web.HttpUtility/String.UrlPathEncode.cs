// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Web;

public static partial class StringExtension
{
    /// <summary>
    ///     Encodes the path portion of a URL string for reliable HTTP transmission from the Web server to a client.
    /// </summary>
    /// <param name="str">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static String UrlPathEncode(this String str)
    {
        return HttpUtility.UrlPathEncode(str);
    }
}