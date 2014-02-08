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
    ///     Converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static String HtmlEncode(this String s)
    {
        return HttpUtility.HtmlEncode(s);
    }

    /// <summary>
    ///     Converts a string into an HTML-encoded string, and returns the output as a  stream of output.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlEncode(this String s, TextWriter output)
    {
        HttpUtility.HtmlEncode(s, output);
    }
}