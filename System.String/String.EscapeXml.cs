// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that escape XML.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_EscapeXml
    ///               {
    ///                   [TestMethod]
    ///                   public void EscapeXml()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&lt;node&gt;it&apos;s my \&quot;node\&quot; &amp; i like it&lt;node&gt;&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.EscapeXml(); // return &quot;&amp;lt;node&amp;gt;it&amp;apos;s my &amp;quot;node&amp;quot; &amp;amp; i like it&amp;lt;node&amp;gt;&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;&amp;lt;node&amp;gt;it&amp;apos;s my &amp;quot;node&amp;quot; &amp;amp; i like it&amp;lt;node&amp;gt;&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string EscapeXml(this string @this)
    {
        return @this.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
    }
}