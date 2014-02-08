// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Net;

public static partial class WebResponseExtension
{
    /// <summary>
    ///     A WebResponse extension method that reads the response stream to the end.
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
    ///               public class System_Net_WebResponse_ReadToEnd
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEnd()
    ///                   {
    ///                       WebRequest webRequest = WebRequest.Create(&quot;http://www.zzzportal.com/&quot;);
    ///           
    ///                       // Type
    ///                       WebResponse @this = webRequest.GetResponseSafe();
    ///           
    ///                       // Examples
    ///                       string value = null;
    ///                       using (@this)
    ///                       {
    ///                           value = @this.ReadToEnd();
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.IsNotNull(value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEnd(this WebResponse @this)
    {
        using (Stream stream = @this.GetResponseStream())
        {
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}