// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Net.Mail;

public static partial class MailMessageExtension
{
    /// <summary>
    ///     A MailMessage extension method that send this message.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <example>
    ///     <code>
    ///           using System.Net.Mail;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Net_Mail_MailMessage_Send
    ///               {
    ///                   [TestMethod]
    ///                   public void Send()
    ///                   {
    ///                       // Type
    ///                       var @this = new MailMessage(&quot;noreply@zzzportal.com&quot;, &quot;noreply@zzzportal.com&quot;, &quot;Fizz&quot;, &quot;Buzz&quot;);
    ///           
    ///                       // Examples
    ///                       @this.Send(); // Send a mail
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void Send(this MailMessage @this)
    {
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.Send(@this);
        }
    }
}