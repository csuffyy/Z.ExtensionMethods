// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that right safe.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_RightSafe
    ///               {
    ///                   [TestMethod]
    ///                   public void RightSafe()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string result1 = @this.RightSafe(2); // return &quot;zz&quot;;
    ///                       string result2 = @this.RightSafe(int.MaxValue); // return &quot;Fizz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;zz&quot;, result1);
    ///                       Assert.AreEqual(&quot;Fizz&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string RightSafe(this string @this, int length)
    {
        return @this.Substring(Math.Max(0, @this.Length - length));
    }
}