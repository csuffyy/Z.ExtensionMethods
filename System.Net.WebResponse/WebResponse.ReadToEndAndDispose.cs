// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Net;
using System.Text;

public static partial class WebResponseExtension
{
    /// <summary>
    ///     A WebRequest extension method that gets the WebRequest response and read the response stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    /// <example>
    ///     <code>
    ///           using System.Net;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Net_WebResponse_ReadToEndAndDispose
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEndAndDispose()
    ///                   {
    ///                       WebRequest webRequest = WebRequest.Create(&quot;http://www.zzzportal.com/&quot;);
    ///           
    ///                       // Type
    ///                       WebResponse @this = webRequest.GetResponseSafe();
    ///           
    ///                       // Examples
    ///                       string value = @this.ReadToEndAndDispose();
    ///           
    ///                       // Unit Test
    ///                       Assert.IsNotNull(value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEndAndDispose(this WebResponse @this)
    {
        using (WebResponse response = @this)
        {
            using (Stream stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}