// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if '@this' contains all values.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ContainsAll
    ///               {
    ///                   [TestMethod]
    ///                   public void ContainsAll()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @this.ContainsAll(&quot;F&quot;, &quot;i&quot;); // return true;
    ///                       bool value2 = @this.ContainsAll(&quot;F&quot;, &quot;i&quot;, &quot;Buzz&quot;); // return false;
    ///                       bool value3 = @this.ContainsAll(StringComparison.InvariantCultureIgnoreCase, &quot;f&quot;, &quot;i&quot;); // return true;
    ///                       bool value4 = @this.ContainsAll(StringComparison.InvariantCulture, &quot;f&quot;, &quot;i&quot;); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                       Assert.IsTrue(value3);
    ///                       Assert.IsFalse(value4);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool ContainsAll(this string @this, params string[] values)
    {
        foreach (string value in values)
        {
            if (@this.IndexOf(value) == -1)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    ///     A string extension method that query if this object contains the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ContainsAll
    ///               {
    ///                   [TestMethod]
    ///                   public void ContainsAll()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @this.ContainsAll(&quot;F&quot;, &quot;i&quot;); // return true;
    ///                       bool value2 = @this.ContainsAll(&quot;F&quot;, &quot;i&quot;, &quot;Buzz&quot;); // return false;
    ///                       bool value3 = @this.ContainsAll(StringComparison.InvariantCultureIgnoreCase, &quot;f&quot;, &quot;i&quot;); // return true;
    ///                       bool value4 = @this.ContainsAll(StringComparison.InvariantCulture, &quot;f&quot;, &quot;i&quot;); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                       Assert.IsTrue(value3);
    ///                       Assert.IsFalse(value4);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
    {
        foreach (string value in values)
        {
            if (@this.IndexOf(value, comparisonType) == -1)
            {
                return false;
            }
        }
        return true;
    }
}