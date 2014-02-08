// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that queries if a not is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a not is empty, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsNotEmpty
    ///               {
    ///                   [TestMethod]
    ///                   public void IsNotEmpty()
    ///                   {
    ///                       // Type
    ///                       string @thisEmpty = &quot;&quot;;
    ///                       string @thisNotEmpty = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Exemples
    ///                       bool result1 = @thisEmpty.IsNotEmpty(); // return false;
    ///                       bool result2 = @thisNotEmpty.IsNotEmpty(); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsFalse(result1);
    ///                       Assert.IsTrue(result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsNotEmpty(this string @this)
    {
        return @this != "";
    }
}