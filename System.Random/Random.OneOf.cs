// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class RandomExtension
{
    /// <summary>
    ///     A Random extension method that return a random value from the specified values.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing arguments.</param>
    /// <returns>One of the specified value.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Random_OneOf
    ///               {
    ///                   [TestMethod]
    ///                   public void OneOf()
    ///                   {
    ///                       // Type
    ///                       var @this = new Random();
    ///           
    ///                       // Examples
    ///                       int value1 = @this.OneOf(1, 2, 3, 4); // return one of this value at random.
    ///                       string value2 = @this.OneOf(&quot;a&quot;, &quot;b&quot;, &quot;c&quot;, &quot;d&quot;); // return one of this value at random.
    ///                       object value3 = @this.OneOf(1, &quot;a&quot;, DateTime.Now, new object()); // return one of this value at random.
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T OneOf<T>(this Random @this, params T[] values)
    {
        return values[@this.Next(values.Length)];
    }
}