// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Linq;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that extracts this object.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Extract
    ///               {
    ///                   [TestMethod]
    ///                   public void Extract()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz1Buzz2&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.Extract(c =&gt; c.IsNumber()); // return &quot;12&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;12&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Extract(this string @this, Func<char, bool> predicate)
    {
        return new string(@this.ToCharArray().Where(predicate).ToArray());
    }
}