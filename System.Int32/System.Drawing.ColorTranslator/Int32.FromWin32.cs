// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Drawing;

public static partial class Int32Extension
{
    /// <summary>
    ///     Translates a Windows color value to a GDI+  structure.
    /// </summary>
    /// <param name="win32Color">The Windows color to translate.</param>
    /// <returns>The  structure that represents the translated Windows color.</returns>
    public static Color FromWin32(this Int32 win32Color)
    {
        return ColorTranslator.FromWin32(win32Color);
    }
}