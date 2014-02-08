// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Linq;

public static partial class DirectoryInfoExtension
{
    /// <summary>
    ///     A DirectoryInfo extension method that deletes the older than x coordinate days.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="day">The day.</param>
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
    ///               public class System_IO_DirectoryInfo_DeleteOlderThanXDays
    ///               {
    ///                   [TestMethod]
    ///                   public void DeleteOlderThanXDays()
    ///                   {
    ///                       // Type
    ///                       var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;DirectoryInfo_DeleteOlderThanXDays&quot;));
    ///                       Directory.CreateDirectory(@this.FullName);
    ///           
    ///                       // Exemples
    ///                       @this.DeleteOlderThanXDays(90); // Remove all file and directory older than X days without a write in this directory
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void DeleteOlderThanXDays(this DirectoryInfo obj, int day)
    {
        DateTime minDate = DateTime.Now.AddDays(day);
        obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
    }
}