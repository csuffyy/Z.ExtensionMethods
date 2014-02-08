// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Xml;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to an XmlDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XmlDocument.</returns>
    /// <example>
    ///     <code>
    ///           using System.Xml;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToXmlDocument
    ///               {
    ///                   [TestMethod]
    ///                   public void ToXmlDocument()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&lt;Fizz&gt;Buzz&lt;/Fizz&gt;&quot;;
    ///           
    ///                       // Examples
    ///                       XmlDocument value = @this.ToXmlDocument(); // return a XmlDocument from the specified string.
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;&lt;Fizz&gt;Buzz&lt;/Fizz&gt;&quot;, value.OuterXml);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static XmlDocument ToXmlDocument(this string @this)
    {
        var doc = new XmlDocument();
        doc.LoadXml(@this);
        return doc;
    }
}