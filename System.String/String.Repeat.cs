// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that repeats the string a specified number of times.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="repeatCount">Number of repeats.</param>
    /// <returns>The repeated string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Repeat
    ///               {
    ///                   [TestMethod]
    ///                   public void Repeat()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.Repeat(3); // return &quot;FizzFizzFizz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FizzFizzFizz&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Repeat(this string @this, int repeatCount)
    {
        if (@this.Length == 1)
        {
            return new string(@this[0], repeatCount);
        }

        var sb = new StringBuilder(repeatCount*@this.Length);
        while (repeatCount-- > 0)
        {
            sb.Append(@this);
        }

        return sb.ToString();
    }
}