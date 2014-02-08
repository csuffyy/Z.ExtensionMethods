// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if '@this' satisfy the specified pattern.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="pattern">The pattern to use. Use '*' as wildcard string.</param>
    /// <returns>true if '@this' satisfy the specified pattern, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsLike
    ///               {
    ///                   [TestMethod]
    ///                   public void IsLike()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;FizzBuzz3&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @this.IsLike(&quot;Fizz*&quot;); // return true;
    ///                       bool value2 = @this.IsLike(&quot;*zzB*&quot;); // return true;
    ///                       bool value3 = @this.IsLike(&quot;*Buzz#&quot;); // return true;
    ///                       bool value4 = @this.IsLike(&quot;*zz?u*&quot;); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsTrue(value2);
    ///                       Assert.IsTrue(value3);
    ///                       Assert.IsTrue(value4);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsLike(this string @this, string pattern)
    {
        // Turn the pattern into regex pattern, and match the whole string with ^$
        string regexPattern = "^" + Regex.Escape(pattern) + "$";

        // Escape special character ?, #, *, [], and [!]
        regexPattern = regexPattern.Replace(@"\[!", "[^")
                                   .Replace(@"\[", "[")
                                   .Replace(@"\]", "]")
                                   .Replace(@"\?", ".")
                                   .Replace(@"\*", ".*")
                                   .Replace(@"\#", @"\d");

        return Regex.IsMatch(@this, regexPattern);
    }
}