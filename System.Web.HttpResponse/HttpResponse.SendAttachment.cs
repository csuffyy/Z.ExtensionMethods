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
    ///     A HttpResponse extension method that sends an attachment.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullPathToFile">The full path to file.</param>
    /// <param name="outputFileName">Filename of the output file.</param>
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
    ///               public class System_Web_HttpResponse_SendAttachment
    ///               {
    ///                   [TestMethod]
    ///                   public void SendAttachment()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       try
    ///                       {
    ///                           @this.SendAttachment(&quot;myfilepath&quot;, &quot;outputFileName&quot;);
    ///                       }
    ///                       catch
    ///                       {
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SendAttachment(this HttpResponse @this, string fullPathToFile, string outputFileName)
    {
        @this.Clear();
        @this.AddHeader("content-disposition", "attachment; filename=" + outputFileName);
        @this.WriteFile(fullPathToFile);
        @this.ContentType = "";
        @this.End();
    }
}