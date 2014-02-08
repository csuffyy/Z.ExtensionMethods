// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class FileInfoExtension
{
    /// <summary>
    ///     A FileInfo extension method that rename file without extension.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newName">Name of the new.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_FileInfo_RenameFileWithoutExtension
    ///               {
    ///                   [TestMethod]
    ///                   public void RenameFileWithoutExtension()
    ///                   {
    ///                       //// Type
    ///                       //var @this = null;
    ///           
    ///                       //// Exemples
    ///                       //var result = @this.RenameFileWithoutExtension(); // result = &quot;;
    ///           
    ///                       //// Unit Test
    ///                       //Assert.Fail(&quot;Not implemented&quot;);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static FileInfo RenameFileWithoutExtension(this FileInfo @this, string newName)
    {
        string fileName = string.Concat(newName, @this.Extension);
        @this.Rename(fileName);
        return @this;
    }
}