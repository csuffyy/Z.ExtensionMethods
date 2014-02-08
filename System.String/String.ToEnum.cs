// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to an enum.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a T.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToEnum
    ///               {
    ///                   [TestMethod]
    ///                   public void ToEnum()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Ordinal&quot;;
    ///           
    ///                       // Examples
    ///                       var value = @this.ToEnum&lt;StringComparison&gt;(); // return StringComparison.Ordinal;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(StringComparison.Ordinal, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ToEnum<T>(this string @this)
    {
        Type enumType = typeof (T);
        return (T) Enum.Parse(enumType, @this);
    }
}