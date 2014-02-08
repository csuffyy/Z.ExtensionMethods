// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that replace all values specified by an empty string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>A string with all specified values replaced by an empty string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ReplaceByEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void ReplaceByEmpty()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.ReplaceByEmpty(&quot;z&quot;); // return &quot;FiBu&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FiBu&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReplaceByEmpty(this string @this, params string[] values)
    {
        foreach (string value in values)
        {
            @this = @this.Replace(value, "");
        }

        return @this;
    }
}