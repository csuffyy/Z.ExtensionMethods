// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that truncates.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Truncate
    ///               {
    ///                   [TestMethod]
    ///                   public void Truncate()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;123456789&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.Truncate(6); // return &quot;123...&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;123...&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Truncate(this string @this, int maxLength)
    {
        const string suffix = "...";

        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }

    /// <summary>
    ///     A string extension method that truncates.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <param name="suffix">The suffix.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Truncate
    ///               {
    ///                   [TestMethod]
    ///                   public void Truncate()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;123456789&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.Truncate(6); // return &quot;123...&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;123...&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Truncate(this string @this, int maxLength, string suffix)
    {
        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }
}