// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Returns a String array containing the substrings in this string that are delimited by elements of a specified
    ///     String array. A parameter specifies whether to return empty array elements.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">A string that delimit the substrings in this string.</param>
    /// <param name="option">
    ///     (Optional) Specify RemoveEmptyEntries to omit empty array elements from the array returned, or None to include
    ///     empty array elements in the array returned.
    /// </param>
    /// <returns>
    ///     An array whose elements contain the substrings in this string that are delimited by the separator.
    /// </returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Split
    ///               {
    ///                   [TestMethod]
    ///                   public void Split()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Examples
    ///                       string[] value = @this.Split(&quot;B&quot;); // return new[] {&quot;Fizz&quot;, &quot;uzz&quot;}
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot;, value[0]);
    ///                       Assert.AreEqual(&quot;uzz&quot;, value[1]);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
    {
        return @this.Split(new[] {separator}, option);
    }
}