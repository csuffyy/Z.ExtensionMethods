// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections;

public static partial class IDictionaryExtension
{
    /// <summary>
    ///     An IDictionary extension method that converts the @this to a hashtable.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Hashtable.</returns>
    /// <example>
    ///     <code>
    ///           using System.Collections;
    ///           using System.Collections.Generic;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Collections_IDictionary_ToHashtable
    ///               {
    ///                   [TestMethod]
    ///                   public void ToHashtable()
    ///                   {
    ///                       // Type
    ///                       var @this = new Dictionary&lt;string, string&gt; {{&quot;Fizz&quot;, &quot;Buzz&quot;}};
    ///           
    ///                       // Exemples
    ///                       Hashtable result = @this.ToHashtable(); // return Hashtable;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Buzz&quot;, result[&quot;Fizz&quot;]);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Hashtable ToHashtable(this IDictionary @this)
    {
        return new Hashtable(@this);
    }
}