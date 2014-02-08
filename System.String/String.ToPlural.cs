// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a plural.
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
    ///               public class System_String_ToPlural
    ///               {
    ///                   [TestMethod]
    ///                   public void ToPlural()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;mouse&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.ToPlural(); // return &quot;mice&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;mice&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToPlural(this string @this)
    {
        return PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a plural.
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
    ///               public class System_String_ToPlural
    ///               {
    ///                   [TestMethod]
    ///                   public void ToPlural()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;mouse&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.ToPlural(); // return &quot;mice&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;mice&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToPlural(this string @this, CultureInfo cultureInfo)
    {
        return PluralizationService.CreateService(cultureInfo).Pluralize(@this);
    }
}