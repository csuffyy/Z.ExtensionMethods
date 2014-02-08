// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class BooleanExtension
{
    /// <summary>
    ///     A bool extension method that show the trueValue when the @this value is true; otherwise show the falseValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="trueValue">The true value to be returned if the @this value is true.</param>
    /// <param name="falseValue">The false value to be returned if the @this value is false.</param>
    /// <returns>A string that represents of the current boolean value.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Boolean_ToString
    ///               {
    ///                   [TestMethod]
    ///                   public void ToString()
    ///                   {
    ///                       // Type
    ///                       bool @thisTrue = true;
    ///                       bool @thisFalse = false;
    ///           
    ///                       // Exemples
    ///                       string result1 = @thisTrue.ToString(&quot;Fizz&quot;, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
    ///                       string result2 = @thisFalse.ToString(&quot;Fizz&quot;, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot;, result1);
    ///                       Assert.AreEqual(&quot;Buzz&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToString(this bool @this, string trueValue, string falseValue)
    {
        return @this ? trueValue : falseValue;
    }
}