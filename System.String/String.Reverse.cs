// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that reverses the given string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string reversed.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Reverse
    ///               {
    ///                   [TestMethod]
    ///                   public void Reverse()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.Reverse(); // return &quot;zzuBzziF&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;zzuBzziF&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Reverse(this string @this)
    {
        if (@this.Length <= 1)
        {
            return @this;
        }

        char[] chars = @this.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}