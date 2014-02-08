// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that converts the @this to a file information.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a FileInfo.</returns>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using System.IO;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_ToFileInfo
    ///               {
    ///                   [TestMethod]
    ///                   public void ToFileInfo()
    ///                   {
    ///                       // Type
    ///                       string @this = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_String_ToFileInfo.txt&quot;);
    ///           
    ///                       // Examples
    ///                       FileInfo value = @this.ToFileInfo(); // return a FileInfo for the specified path.
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(@this, value.FullName);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static FileInfo ToFileInfo(this string @this)
    {
        return new FileInfo(@this);
    }
}