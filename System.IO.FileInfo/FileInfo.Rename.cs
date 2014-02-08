// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class FileInfoExtension
{
    /// <summary>
    ///     A FileInfo extension method that renames.
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
    ///               public class System_IO_FileInfo_Rename
    ///               {
    ///                   [TestMethod]
    ///                   public void Rename()
    ///                   {
    ///                       //// Type
    ///                       //var @this = null;
    ///           
    ///                       //// Exemples
    ///                       //var result = @this.Rename(); // result = &quot;;
    ///           
    ///                       //// Unit Test
    ///                       //Assert.Fail(&quot;Not implemented&quot;);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static FileInfo Rename(this FileInfo @this, string newName)
    {
        string filePath = Path.Combine(Path.GetDirectoryName(@this.FullName), newName);
        @this.MoveTo(filePath);
        return @this;
    }
}