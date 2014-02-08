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
    ///     Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static String HtmlDecode(this String s)
    {
        return HttpUtility.HtmlDecode(s);
    }

    /// <summary>
    ///     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
    ///     stream.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <param name="output">A  stream of output.</param>
    public static void HtmlDecode(this String s, TextWriter output)
    {
        HttpUtility.HtmlDecode(s, output);
    }
}