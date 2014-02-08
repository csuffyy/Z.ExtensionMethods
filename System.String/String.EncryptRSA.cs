// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Security.Cryptography;
using System.Text;

public static partial class StringExtension
{
    /// <summary>
    ///     A string extension method that encrypts the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <returns>The encrypted string.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_String_EncryptRSA
    ///               {
    ///                   [TestMethod]
    ///                   public void EncryptRSA()
    ///                   {
    ///                       // Type
    ///                       string @this = &quot;Fizz&quot;;
    ///           
    ///                       // Examples
    ///                       string value = @this.EncryptRSA(&quot;Buzz&quot;); // return Encrypted string;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;Fizz&quot;, value.DecryptRSA(&quot;Buzz&quot;));
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static string EncryptRSA(this string @this, string key)
    {
        var cspp = new CspParameters {KeyContainerName = key};
        var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};
        byte[] bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(@this), true);

        return BitConverter.ToString(bytes);
    }
}