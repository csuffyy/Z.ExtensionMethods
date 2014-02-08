// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if this object contains the given value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <returns>true if the value is in the string, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Contains
    ///               {
    ///                   [TestMethod]
    ///                   public void Contains()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @this.Contains(&quot;f&quot;, StringComparison.InvariantCultureIgnoreCase); // return true;
    ///                       bool value2 = @this.Contains(&quot;f&quot;, StringComparison.InvariantCulture); // return false;
    ///                       bool value3 = @this.Contains(&quot;F&quot;); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                       Assert.IsTrue(value3);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool Contains(this string @this, string value)
    {
        return @this.IndexOf(value) != -1;
    }

    /// <summary>
    ///     A string extension method that query if this object contains the given value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <returns>true if the value is in the string, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_Contains
    ///               {
    ///                   [TestMethod]
    ///                   public void Contains()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @this.Contains(&quot;f&quot;, StringComparison.InvariantCultureIgnoreCase); // return true;
    ///                       bool value2 = @this.Contains(&quot;f&quot;, StringComparison.InvariantCulture); // return false;
    ///                       bool value3 = @this.Contains(&quot;F&quot;); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                       Assert.IsTrue(value3);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool Contains(this string @this, string value, StringComparison comparisonType)
    {
        return @this.IndexOf(value, comparisonType) != -1;
    }
}