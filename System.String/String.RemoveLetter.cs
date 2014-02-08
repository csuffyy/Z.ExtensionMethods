// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Linq;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that removes the letter described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_RemoveLetter
    ///               {
    ///                   [TestMethod]
    ///                   public void RemoveLetter()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz1Buzz2&quot;;
    ///           
    ///                       // Exemples
    ///                       string result = @this.RemoveLetter(); // return &quot;12&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;12&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string RemoveLetter(this string @this)
    {
        return new string(@this.ToCharArray().Where(x => !Char.IsLetter(x)).ToArray());
    }
}