// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that return the left part of the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>The left part.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Left
    ///               {
    ///                   [TestMethod]
    ///                   public void Left()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.Left(2); // return &quot;Fi&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fi&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Left(this string @this, int length)
    {
        return @this.Substring(0, length);
    }
}