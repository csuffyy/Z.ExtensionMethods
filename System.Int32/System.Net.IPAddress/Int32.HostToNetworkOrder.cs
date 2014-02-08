// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Net;

public static partial class Int32Extension
{
    /// <summary>
    ///     Converts an integer value from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The number to convert, expressed in host byte order.</param>
    /// <returns>An integer value, expressed in network byte order.</returns>
    public static Int32 HostToNetworkOrder(this Int32 host)
    {
        return IPAddress.HostToNetworkOrder(host);
    }
}