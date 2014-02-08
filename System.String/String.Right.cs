// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that return the right part of the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>The right part.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Right
    ///               {
    ///                   [TestMethod]
    ///                   public void Right()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.Right(2); // return &quot;zz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;zz&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Right(this string @this, int length)
    {
        return @this.Substring(@this.Length - length);
    }
}