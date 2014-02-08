// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Drawing;

public static partial class Int32Extension
{
    /// <summary>
    ///     Translates an OLE color value to a GDI+  structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The  structure that represents the translated OLE color.</returns>
    public static Color FromOle(this Int32 oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
}