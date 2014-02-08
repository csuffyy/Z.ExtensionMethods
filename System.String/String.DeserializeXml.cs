// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Xml.Serialization;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that deserialize an Xml as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desieralize Xml as &lt;T&gt;</returns>
    /// <example>
    ///     <code>
    ///           using System.Collections.Generic;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_DeserializeXml
    ///               {
    ///                   [TestMethod]
    ///                   public void DeserializeXml()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&lt;?xml version=\&quot;1.0\&quot; encoding=\&quot;utf-16\&quot;?&gt;\r\n&lt;ArrayOfString xmlns:xsi=\&quot;http://www.w3.org/2001/XMLSchema-instance\&quot; xmlns:xsd=\&quot;http://www.w3.org/2001/XMLSchema\&quot;&gt;\r\n  &lt;string&gt;Fizz&lt;/string&gt;\r\n  &lt;string&gt;Buzz&lt;/string&gt;\r\n&lt;/ArrayOfString&gt;&quot;;
    ///           
    ///                       // Examples
    ///                       var value = @this.DeserializeXml&lt;List&lt;string&gt;&gt;(); // new List&lt;string&gt; {&quot;Fizz&quot;, &quot;Buzz&quot;};
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot;, value[0]);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T DeserializeXml<T>(this string @this)
    {
        var x = new XmlSerializer(typeof (T));
        var r = new StringReader(@this);

        return (T) x.Deserialize(r);
    }
}