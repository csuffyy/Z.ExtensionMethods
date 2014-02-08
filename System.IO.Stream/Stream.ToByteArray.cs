// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class StreamExtension
{
    /// <summary>
    ///     A Stream extension method that converts the Stream to a byte array.
    /// </summary>
    /// <param name="this">The Stream to act on.</param>
    /// <returns>The Stream as a byte[].</returns>
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
    ///               public class System_IO_Stream_ToByteArray
    ///               {
    ///                   [TestMethod]
    ///                   public void ToByteArray()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_IO_FileInfo_ReadToEnd.txt&quot;));
    ///           
    ///                       // Examples
    ///                       byte[] value;
    ///                       using (FileStream @this = fileInfo.Create())
    ///                       {
    ///                           @this.WriteByte(0);
    ///                           @this.Position = 0;
    ///                           value = @this.ToByteArray(); // return &quot;0&quot;;
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(0, value[0]);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static byte[] ToByteArray(this Stream @this)
    {
        using (var ms = new MemoryStream())
        {
            @this.CopyTo(ms);
            return ms.ToArray();
        }
    }
}