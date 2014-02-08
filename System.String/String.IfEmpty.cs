// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that if empty.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IfEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void IfEmpty()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.IfEmpty(&quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string IfEmpty(this string value, string defaultValue)
    {
        return (value.IsNotEmpty() ? value : defaultValue);
    }
}