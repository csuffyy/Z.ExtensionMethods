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
    ///     A HttpResponse extension method that redirects.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="urlFormat">The URL format.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
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
    ///               public class System_Web_HttpResponse_Redirect
    ///               {
    ///                   [TestMethod]
    ///                   public void Redirect()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       try
    ///                       {
    ///                           @this.Redirect(&quot;http://zzzportal.{0}&quot;, &quot;com&quot;);
    ///                       }
    ///                       catch
    ///                       {
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void Redirect(this HttpResponse @this, string urlFormat, params object[] values)
    {
        string url = string.Format(urlFormat, values);
        @this.Redirect(url, true);
    }
}