// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class StringExtension
{
    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0)
    {
        return String.Format(@this, arg0);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0, Object arg1)
    {
        return String.Format(@this, arg0, arg1);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <param name="arg2">The second argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0, Object arg1, Object arg2)
    {
        return String.Format(@this, arg0, arg1, arg2);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">A String containing zero or more format items.</param>
    /// <param name="values">An Object array containing zero or more objects to format.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_FormatWith
    ///               {
    ///                   [TestMethod]
    ///                   public void FormatWith()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;{0}{1}&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.FormatWith(&quot;Fizz&quot;, &quot;Buzz&quot;); // return &quot;FizzBuzz&quot;;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string FormatWith(this string @this, params object[] values)
    {
        return String.Format(@this, values);
    }
}