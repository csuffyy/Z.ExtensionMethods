// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that query if '@this' is Alphanumeric.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if Alphanumeric, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_IsAlphaNumeric
    ///               {
    ///                   [TestMethod]
    ///                   public void IsAlphaNumeric()
    ///                   {
    ///                       // Type
    ///                       string @thisAlphaNumeric = &quot;abc123&quot;;
    ///                       string @thisNotAlphaNumeric = &quot;abc123!&lt;&gt;&quot;;
    ///           
    ///                       // Examples
    ///                       bool value1 = @thisAlphaNumeric.IsAlphaNumeric(); // return true;
    ///                       bool value2 = @thisNotAlphaNumeric.IsAlphaNumeric(); // return false;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(value1);
    ///                       Assert.IsFalse(value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsAlphaNumeric(this string @this)
    {
        return !Regex.IsMatch(@this, "[^a-zA-Z0-9]");
    }
}