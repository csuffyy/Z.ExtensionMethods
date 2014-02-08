// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if '@this' is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void IsEmpty()
    ///                   {
    ///                       // Type
    ///                       string @thisEmpty = &quot;&quot;;
    ///                       string @thisNotEmpty = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Exemples
    ///                       bool result1 = @thisEmpty.IsEmpty(); // return true;
    ///                       bool result2 = @thisNotEmpty.IsEmpty(); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(result1);
    ///                       Assert.IsFalse(result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsEmpty(this string @this)
    {
        return @this == "";
    }
}