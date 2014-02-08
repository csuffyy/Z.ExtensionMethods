// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

public static partial class FileInfoExtension
{
    /// <summary>
    ///     A FileInfo extension method that change extension.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newExtension">The new extension.</param>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_FileInfo_ChangeExtension
    ///               {
    ///                   [TestMethod]
    ///                   public void ChangeExtension()
    ///                   {
    ///                       //// Type
    ///                       //var @this = null;
    ///           
    ///                       //// Exemples
    ///                       //var result = @this.ChangeExtension(); // result = &quot;;
    ///           
    ///                       //// Unit Test
    ///                       //Assert.Fail(&quot;Not implemented&quot;);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void ChangeExtension(this FileInfo @this, string newExtension)
    {
        newExtension = newExtension.StartsWith(".") ? newExtension : string.Concat(".", newExtension);

        string filePath = Path.Combine(Path.GetFileNameWithoutExtension(@this.FullName), newExtension);
        @this.MoveTo(filePath);
    }
}