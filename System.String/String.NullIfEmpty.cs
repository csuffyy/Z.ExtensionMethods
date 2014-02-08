// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that return null if the value is empty else the value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>null if the value is empty, otherwise the value.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_NullIfEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void NullIfEmpty()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.NullIfEmpty(); // return null;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsNull(value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string NullIfEmpty(this string @this)
    {
        return @this == "" ? null : @this;
    }
}