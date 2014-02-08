// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Text;

public static partial class StreamExtension
{
    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
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
    ///               public class System_IO_Stream_ReadToEnd
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEnd()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_IO_FileInfo_ReadToEnd.txt&quot;));
    ///           
    ///                       // Examples
    ///                       string value = &quot;&quot;;
    ///                       using (FileStream @this = fileInfo.Create())
    ///                       {
    ///                           @this.WriteByte(0);
    ///                           @this.Position = 0;
    ///                           value = @this.ReadToEnd(); // return &quot;\0&quot;;
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;\0&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEnd(this Stream @this)
    {
        using (var sr = new StreamReader(@this, Encoding.Default))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
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
    ///               public class System_IO_Stream_ReadToEnd
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEnd()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_IO_FileInfo_ReadToEnd.txt&quot;));
    ///           
    ///                       // Examples
    ///                       string value = &quot;&quot;;
    ///                       using (FileStream @this = fileInfo.Create())
    ///                       {
    ///                           @this.WriteByte(0);
    ///                           @this.Position = 0;
    ///                           value = @this.ReadToEnd(); // return &quot;\0&quot;;
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;\0&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEnd(this Stream @this, Encoding encoding)
    {
        using (var sr = new StreamReader(@this, encoding))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
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
    ///               public class System_IO_Stream_ReadToEnd
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEnd()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_IO_FileInfo_ReadToEnd.txt&quot;));
    ///           
    ///                       // Examples
    ///                       string value = &quot;&quot;;
    ///                       using (FileStream @this = fileInfo.Create())
    ///                       {
    ///                           @this.WriteByte(0);
    ///                           @this.Position = 0;
    ///                           value = @this.ReadToEnd(); // return &quot;\0&quot;;
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;\0&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEnd(this Stream @this, long position)
    {
        @this.Position = position;

        using (var sr = new StreamReader(@this, Encoding.Default))
        {
            return sr.ReadToEnd();
        }
    }

    /// <summary>
    ///     A Stream extension method that reads a stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
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
    ///               public class System_IO_Stream_ReadToEnd
    ///               {
    ///                   [TestMethod]
    ///                   public void ReadToEnd()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_IO_FileInfo_ReadToEnd.txt&quot;));
    ///           
    ///                       // Examples
    ///                       string value = &quot;&quot;;
    ///                       using (FileStream @this = fileInfo.Create())
    ///                       {
    ///                           @this.WriteByte(0);
    ///                           @this.Position = 0;
    ///                           value = @this.ReadToEnd(); // return &quot;\0&quot;;
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;\0&quot;, value);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ReadToEnd(this Stream @this, Encoding encoding, long position)
    {
        @this.Position = position;

        using (var sr = new StreamReader(@this, encoding))
        {
            return sr.ReadToEnd();
        }
    }
}