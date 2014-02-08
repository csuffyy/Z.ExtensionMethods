// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class BooleanExtension
{
    /// <summary>
    ///     A bool extension method that execute an Action if the value is false.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action to execute.</param>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Boolean_IfFalse
    ///               {
    ///                   [TestMethod]
    ///                   public void IfFalse()
    ///                   {
    ///                       // Variables
    ///                       string value1 = &quot;&quot;;
    ///                       string value2 = &quot;&quot;;
    ///           
    ///                       // Type
    ///                       const bool conditionTrue = true;
    ///                       const bool conditionFalse = false;
    ///           
    ///                       // Examples
    ///                       conditionTrue.IfFalse(() =&gt; value1 = &quot;FizzBuzz&quot;); // value1 = &quot;&quot;;
    ///                       conditionFalse.IfFalse(() =&gt; value2 = &quot;FizzBuzz&quot;); // value2 = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;&quot;, value1);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void IfFalse(this bool @this, Action action)
    {
        if (!@this)
        {
            action();
        }
    }
}