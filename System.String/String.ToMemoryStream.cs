// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a MemoryStream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a MemoryStream.</returns>
    /// <example>
    ///     <code>
    ///           using System.IO;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToMemoryStream
    ///               {
    ///                   [TestMethod]
    ///                   public void ToMemoryStream()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;FizzBuzz&quot;;
    ///           
    ///                       // Examples
    ///                       using (Stream value = @this.ToMemoryStream()) // return a MemoryStream from the text
    ///                       {
    ///                           // Unit Test
    ///                           Assert.IsNotNull(value);
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Stream ToMemoryStream(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return new MemoryStream(encoding.GetBytes(@this));
    }
}