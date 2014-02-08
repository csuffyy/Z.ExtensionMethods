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
    ///     A HttpResponse extension method that reloads the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <example>
    ///     <code>
    ///           using System.IO;
    ///           using System.Web;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Web_HttpResponse_Reload
    ///               {
    ///                   [TestMethod]
    ///                   public void Reload()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       try
    ///                       {
    ///                           @this.Reload();
    ///                       }
    ///                       catch
    ///                       {
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void Reload(this HttpResponse @this)
    {
        @this.Redirect(HttpContext.Current.Request.Url.ToString(), true);
    }
}