// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that save the string into a file.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fileName">Filename of the file.</param>
    /// <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
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
    ///               public class System_String_SaveAs
    ///               {
    ///                   [TestMethod]
    ///                   public void SaveAs()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_String_SaveAs.txt&quot;));
    ///                       string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_String_SaveAs2.txt&quot;);
    ///           
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       @this.SaveAs(filePath); // Save string in a file.
    ///                       @this.SaveAs(fileInfo); // Save string in a file.
    ///                       @this.SaveAs(fileInfo, true); // Append string to existing file.
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(fileInfo.Exists);
    ///                       Assert.IsTrue(new FileInfo(filePath).Exists);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SaveAs(this string @this, string fileName, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(fileName, append))
        {
            tw.Write(@this);
        }
    }

    /// <summary>
    ///     A string extension method that save the string into a file.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="file">The FileInfo.</param>
    /// <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
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
    ///               public class System_String_SaveAs
    ///               {
    ///                   [TestMethod]
    ///                   public void SaveAs()
    ///                   {
    ///                       var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_String_SaveAs.txt&quot;));
    ///                       string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;Examples_System_String_SaveAs2.txt&quot;);
    ///           
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       @this.SaveAs(filePath); // Save string in a file.
    ///                       @this.SaveAs(fileInfo); // Save string in a file.
    ///                       @this.SaveAs(fileInfo, true); // Append string to existing file.
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(fileInfo.Exists);
    ///                       Assert.IsTrue(new FileInfo(filePath).Exists);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void SaveAs(this string @this, FileInfo file, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(file.FullName, append))
        {
            tw.Write(@this);
        }
    }
}