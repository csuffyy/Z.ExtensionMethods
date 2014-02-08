// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Net;

public static class WebRequestExtension
{
    /// <summary>
    ///     A WebRequest extension method that gets the WebRequest response or the WebException response.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The WebRequest response or WebException response.</returns>
    /// <example>
    ///     <code>
    ///           using System.Net;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Net_WebRequest_GetResponseSafe
    ///               {
    ///                   [TestMethod]
    ///                   public void GetResponseSafe()
    ///                   {
    ///                       // Type
    ///                       WebRequest @this = WebRequest.Create(&quot;http://www.zzzportal.com/&quot;);
    ///           
    ///                       // Examples
    ///                       WebResponse value = @this.GetResponseSafe(); // return a response;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsNotNull(value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static WebResponse GetResponseSafe(this WebRequest @this)
    {
        try
        {
            return @this.GetResponse();
        }
        catch (WebException e)
        {
            return e.Response;
        }
    }
}