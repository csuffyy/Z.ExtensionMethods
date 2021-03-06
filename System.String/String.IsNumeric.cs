// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if '@this' is numeric.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if numeric, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsNumeric
    ///               {
    ///                   [TestMethod]
    ///                   public void IsNumeric()
    ///                   {
    ///                       // Type
    ///                       string @thisNumeric = &quot;123&quot;;
    ///                       string @thisNotNumeric = &quot;abc123&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @thisNumeric.IsNumeric(); // return true;
    ///                       bool value2 = @thisNotNumeric.IsNumeric(); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsNumeric(this string @this)
    {
        return !Regex.IsMatch(@this, "[^0-9]");
    }
}