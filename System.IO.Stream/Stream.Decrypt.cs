// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Security.Cryptography;

public static partial class StreamExtension
{
    /// <summary>
    ///     A Stream extension method that decrypts.
    /// </summary>
    /// <typeparam name="Algorithm">Type of the algorithm.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="iv">(Optional) the iv.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_Stream_Decrypt
    ///               {
    ///                   [TestMethod]
    ///                   public void Decrypt()
    ///                   {
    ///                       //// Type
    ///                       //var @this = null;
    ///           
    ///                       //// Exemples
    ///                       //var result = @this.Decrypt(); // result = &quot;;
    ///           
    ///                       //// Unit Test
    ///                       //Assert.Fail(&quot;Not implemented&quot;);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Stream Decrypt<Algorithm>(this Stream @this, byte[] key, byte[] iv = null)
        where Algorithm : SymmetricAlgorithm
    {
        var alg = Activator.CreateInstance<Algorithm>();
        alg.Key = key;
        alg.IV = iv ?? key;
        ICryptoTransform encryptor = alg.CreateDecryptor();
        return new CryptoStream(@this, encryptor, CryptoStreamMode.Read);
    }
}