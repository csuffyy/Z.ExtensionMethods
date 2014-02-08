// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a XDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XDocument.</returns>
    /// <example>
    ///     <code>
    ///           using System.Xml.Linq;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToXDocument
    ///               {
    ///                   [TestMethod]
    ///                   public void ToXDocument()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&lt;Fizz&gt;Buzz&lt;/Fizz&gt;&quot;;
    ///           
    ///                       // Examples
    ///                       XDocument value = @this.ToXDocument(); // return a XDocument from the specified string.
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;&lt;Fizz&gt;Buzz&lt;/Fizz&gt;&quot;, value.ToString());
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static XDocument ToXDocument(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        using (var ms = new MemoryStream(encoding.GetBytes(@this)))
        {
            return XDocument.Load(ms);
        }
    }
}