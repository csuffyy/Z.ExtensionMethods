// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Linq;
using System.Xml.Linq;

public static class XElementExtension
{
    /// <summary>
    ///     An XElement extension method that removes all namespaces described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    public static XElement RemoveAllNamespaces(this XElement @this)
    {
        return new XElement(@this.Name.LocalName,
                            (from n in @this.Nodes()
                             select ((n is XElement) ? RemoveAllNamespaces(n as XElement) : n)),
                            (@this.HasAttributes) ? (from a in @this.Attributes() select a) : null);
    }
}