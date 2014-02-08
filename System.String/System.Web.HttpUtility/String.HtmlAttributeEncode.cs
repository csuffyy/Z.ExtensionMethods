// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Web;

public static partial class StringExtension
{
    /// <summary>
    ///     Minimally converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String HtmlAttributeEncode(this String s)
    {
        return HttpUtility.HtmlAttributeEncode(s);
    }

    /// <summary>
    ///     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlAttributeEncode(this String s, TextWriter output)
    {
        HttpUtility.HtmlAttributeEncode(s, output);
    }
}