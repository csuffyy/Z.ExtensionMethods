// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that newline 2 line break.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Nl2Br
    ///               {
    ///                   [TestMethod]
    ///                   public void Nl2Br()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot; + Environment.NewLine + &quot;Buzz&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.Nl2Br(); // return &quot;Fizz&lt;br /&gt;Buzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&lt;br /&gt;Buzz&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Nl2Br(this string @this)
    {
        return @this.Replace("\r\n", "<br />").Replace("\n", "<br />");
    }
}