// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that queries if '@this' is null or is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is null or is empty, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsNullOrEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void IsNullOrEmpty()
    ///                   {
    ///                       // Type
    ///                       string @thisValue = &quot;Fizz&quot;;
    ///                       string @thisNull = null;
    ///           
    ///                       // Examples
    ///                       bool value1 = @thisValue.IsNullOrEmpty(); // return false;
    ///                       bool value2 = @thisNull.IsNullOrEmpty(); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsFalse(value1);
    ///                       Assert.IsTrue(value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsNullOrEmpty(this string @this)
    {
        return string.IsNullOrEmpty(@this);
    }
}