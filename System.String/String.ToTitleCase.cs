// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Globalization;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToTitleCase
    ///               {
    ///                   [TestMethod]
    ///                   public void ToTitleCase()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;fizz buzz&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.ToTitleCase(); // return &quot;Fizz Buzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz Buzz&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToTitleCase(this string @this)
    {
        return new CultureInfo("en-US").TextInfo.ToTitleCase(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToTitleCase
    ///               {
    ///                   [TestMethod]
    ///                   public void ToTitleCase()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;fizz buzz&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.ToTitleCase(); // return &quot;Fizz Buzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz Buzz&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToTitleCase(this string @this, CultureInfo cultureInfo)
    {
        return cultureInfo.TextInfo.ToTitleCase(@this);
    }
}