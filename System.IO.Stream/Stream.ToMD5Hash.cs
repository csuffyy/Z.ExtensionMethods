// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Security.Cryptography;
using System.Text;

public static partial class StreamExtension
{
    /// <summary>
    ///     A Stream extension method that converts the @this to a md 5 hash.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_Stream_ToMD5Hash
    ///               {
    ///                   [TestMethod]
    ///                   public void ToMD5Hash()
    ///                   {
    ///                       //// Type
    ///                       //var @this = null;
    ///           
    ///                       //// Exemples
    ///                       //var result = @this.ToMD5Hash(); // result = &quot;;
    ///           
    ///                       //// Unit Test
    ///                       //Assert.Fail(&quot;Not implemented&quot;);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string ToMD5Hash(this Stream @this)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(@this);
            var sb = new StringBuilder();
            foreach (byte bytes in hashBytes)
            {
                sb.Append(bytes.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}