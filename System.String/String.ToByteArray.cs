// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a byte array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a byte[].</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToByteArray
    ///               {
    ///                   [TestMethod]
    ///                   public void ToByteArray()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       byte[] value = @this.ToByteArray(); // return new byte[] { 70, 105, 122, 122 };
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(4, value.Length);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static byte[] ToByteArray(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return encoding.GetBytes(@this);
    }
}