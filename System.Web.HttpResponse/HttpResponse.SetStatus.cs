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
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
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
    ///               public class System_Web_HttpResponse_SetStatus
    ///               {
    ///                   [TestMethod]
    ///                   public void SetStatus()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       @this.SetStatus(200, &quot;FizzBuzz&quot;, false);
    ///           
    ///                       // UnitTest
    ///                       Assert.AreEqual(200, @this.StatusCode);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, @this.StatusDescription);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SetStatus(this HttpResponse @this, int code)
    {
        @this.StatusCode = code;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="endResponse">true to end response.</param>
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
    ///               public class System_Web_HttpResponse_SetStatus
    ///               {
    ///                   [TestMethod]
    ///                   public void SetStatus()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       @this.SetStatus(200, &quot;FizzBuzz&quot;, false);
    ///           
    ///                       // UnitTest
    ///                       Assert.AreEqual(200, @this.StatusCode);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, @this.StatusDescription);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SetStatus(this HttpResponse @this, int code, bool endResponse)
    {
        @this.StatusCode = code;

        if (endResponse)
        {
            @this.End();
        }
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
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
    ///               public class System_Web_HttpResponse_SetStatus
    ///               {
    ///                   [TestMethod]
    ///                   public void SetStatus()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       @this.SetStatus(200, &quot;FizzBuzz&quot;, false);
    ///           
    ///                       // UnitTest
    ///                       Assert.AreEqual(200, @this.StatusCode);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, @this.StatusDescription);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SetStatus(this HttpResponse @this, int code, string description)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    /// <param name="endResponse">true to end response.</param>
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
    ///               public class System_Web_HttpResponse_SetStatus
    ///               {
    ///                   [TestMethod]
    ///                   public void SetStatus()
    ///                   {
    ///                       var writer = new StringWriter();
    ///           
    ///                       // Type
    ///                       var @this = new HttpResponse(writer);
    ///           
    ///                       // Examples
    ///                       @this.SetStatus(200, &quot;FizzBuzz&quot;, false);
    ///           
    ///                       // UnitTest
    ///                       Assert.AreEqual(200, @this.StatusCode);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, @this.StatusDescription);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SetStatus(this HttpResponse @this, int code, string description, bool endResponse)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;

        if (endResponse)
        {
            @this.End();
        }
    }
}