// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that get the string after the specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value to search.</param>
    /// <returns>The string after the specified value.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_GetAfter
    ///               {
    ///                   [TestMethod]
    ///                   public void GetAfter()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string result1 = @this.GetAfter(&quot;i&quot;); // return &quot;zz&quot;;
    ///                       string result2 = @this.GetAfter(&quot;a&quot;); // return &quot;&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;zz&quot;, result1);
    ///                       Assert.AreEqual(&quot;&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string GetAfter(this string @this, string value)
    {
        if (@this.IndexOf(value) == -1)
        {
            return "";
        }
        return @this.Substring(@this.IndexOf(value) + value.Length);
    }
}