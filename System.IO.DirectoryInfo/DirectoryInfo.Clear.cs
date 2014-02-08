// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;

public static partial class DirectoryInfoExtension
{
    /// <summary>
    ///     A DirectoryInfo extension method that clears all files and directories in this directory.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
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
    ///               public class System_IO_DirectoryInfo_Clear
    ///               {
    ///                   [TestMethod]
    ///                   public void Clear()
    ///                   {
    ///                       // Type
    ///                       var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;DirectoryInfo_Clear&quot;));
    ///                       Directory.CreateDirectory(@this.FullName);
    ///           
    ///                       // Exemples
    ///                       @this.Clear(); // Remove all file and directory in this directory
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void Clear(this DirectoryInfo obj)
    {
        Array.ForEach(obj.GetFiles(), x => x.Delete());
        Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
    }
}