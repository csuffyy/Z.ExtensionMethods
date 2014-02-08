// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Web;

/// ###
/// <summary>HTTP response extension.</summary>
public static partial class HttpResponseExtension
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 304 (Not modified.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNotModified(this HttpResponse @this)
    {
        @this.StatusCode = 304;
        @this.StatusDescription = "Not modified.";
    }
}