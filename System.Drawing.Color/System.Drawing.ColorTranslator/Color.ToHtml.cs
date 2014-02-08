// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Drawing;

public static partial class ColorExtension
{
    /// <summary>
    ///     Translates the specified  structure to an HTML string color representation.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The string that represents the HTML color.</returns>
    public static String ToHtml(this Color c)
    {
        return ColorTranslator.ToHtml(c);
    }
}