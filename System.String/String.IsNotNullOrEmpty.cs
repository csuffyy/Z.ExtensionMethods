// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that queries if '@this' is not (null or empty).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is not (null or empty), false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsNotNullOrEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void IsNotNullOrEmpty()
    ///                   {
    ///                       // Type
    ///                       string @thisValue = &quot;Fizz&quot;;
    ///                       string @thisNull = null;
    ///           
    ///                       // Examples
    ///                       bool value1 = @thisValue.IsNotNullOrEmpty(); // return true;
    ///                       bool value2 = @thisNull.IsNotNullOrEmpty(); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsNotNullOrEmpty(this string @this)
    {
        return !string.IsNullOrEmpty(@this);
    }
}