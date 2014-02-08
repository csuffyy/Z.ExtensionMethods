// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Linq;

public static partial class CharExtension
{
    /// <summary>
    ///     Enumerates from @this to toCharacter.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="toCharacter">to character.</param>
    /// <returns>An enumerator that allows foreach to be used to process @this to toCharacter.</returns>
    /// <example>
    ///     <code>
    ///           using System.Collections.Generic;
    ///           using System.Linq;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Char_To
    ///               {
    ///                   [TestMethod]
    ///                   public void To()
    ///                   {
    ///                       // Type
    ///                       char @this = &apos;A&apos;;
    ///           
    ///                       // Examples
    ///                       List&lt;char&gt; list = @this.To(&apos;C&apos;).ToList(); // return new [] {&apos;a&apos;, &apos;b&apos;, &apos;c&apos;};
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(3, list.Count);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        bool reverseRequired = (@this > toCharacter);

        char first = reverseRequired ? toCharacter : @this;
        char last = reverseRequired ? @this : toCharacter;

        IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char) charCode);

        if (reverseRequired)
        {
            result = result.Reverse();
        }


        return result;
    }
}