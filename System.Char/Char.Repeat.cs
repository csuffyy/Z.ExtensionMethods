// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license


public static partial class CharExtension
{
    /// <summary>
    ///     A char extension method that repeats a character the specified number of times.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="repeatCount">Number of repeats.</param>
    /// <returns>The repeated char.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Char_Repeat
    ///               {
    ///                   [TestMethod]
    ///                   public void Repeat()
    ///                   {
    ///                       // Type
    ///                       char @this = &apos;F&apos;;
    ///           
    ///                       // Examples
    ///                       string result = @this.Repeat(3); // return &quot;FFF&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FFF&quot;, result);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string Repeat(this char @this, int repeatCount)
    {
        return new string(@this, repeatCount);
    }
}