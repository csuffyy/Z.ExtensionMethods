// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that decode a Base64 String.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The Base64 String decoded.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_DecodeBase64
    ///               {
    ///                   [TestMethod]
    ///                   public void DecodeBase64()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Rml6eg==&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.DecodeBase64(); // return &quot;Fizz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string DecodeBase64(this string @this)
    {
        return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
    }
}