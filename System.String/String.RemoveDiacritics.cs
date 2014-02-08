// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Globalization;
using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that removes the diacritics character from the strings.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string without diacritics character.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_RemoveDiacritics
    ///               {
    ///                   [TestMethod]
    ///                   public void RemoveDiacritics()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;éèêôîâ&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.RemoveDiacritics(); // return &quot;eeeoia&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;eeeoia&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string RemoveDiacritics(this string @this)
    {
        string normalizedString = @this.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (char t in normalizedString)
        {
            UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(t);
            if (uc != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(t);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}