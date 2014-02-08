// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that get the string between the two specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="before">The string before to search.</param>
    /// <param name="after">The string after to search.</param>
    /// <returns>The string between the two specified string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_GetBetween
    ///               {
    ///                   [TestMethod]
    ///                   public void GetBetween()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string result1 = @this.GetBetween(&quot;F&quot;, &quot;z&quot;); // return &quot;i&quot;;
    ///                       string result2 = @this.GetBetween(&quot;a&quot;, &quot;b&quot;); // return &quot;&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;i&quot;, result1);
    ///                       Assert.AreEqual(&quot;&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string GetBetween(this string @this, string before, string after)
    {
        int beforeStartIndex = @this.IndexOf(before);
        int startIndex = beforeStartIndex + before.Length;
        int afterStartIndex = @this.IndexOf(after, startIndex);

        if (beforeStartIndex == -1 || afterStartIndex == -1)
        {
            return "";
        }

        return @this.Substring(startIndex, afterStartIndex - startIndex);
    }
}