// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class Int64Extension
{
    /// <summary>
    ///     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
    ///     equivalent  value.
    /// </summary>
    /// <param name="cy">An OLE Automation Currency value.</param>
    /// <returns>A  that contains the equivalent of .</returns>
    public static Decimal FromOACurrency(this Int64 cy)
    {
        return Decimal.FromOACurrency(cy);
    }
}