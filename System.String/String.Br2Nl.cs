// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that line break 2 newline.
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
    ///               public class System_String_Br2Nl
    ///               {
    ///                   [TestMethod]
    ///                   public void Br2Nl()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&lt;br /&gt;Buzz&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.Br2Nl(); // return &quot;Fizz/r/nBuzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot; + Environment.NewLine + &quot;Buzz&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Br2Nl(this string @this)
    {
        return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
    }
}