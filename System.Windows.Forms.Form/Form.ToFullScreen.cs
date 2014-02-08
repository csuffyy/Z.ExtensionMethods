// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Windows.Forms;

public static class FormExtension
{
    /// <summary>
    ///     A Form extension method that set the window form to full screen mode to the specified screen.
    /// </summary>
    /// <param name="form">The form to act on.</param>
    /// <param name="screen">(Optional) the screen to act on.</param>
    /// <example>
    ///     <code>
    ///           using System.Windows.Forms;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Windows_Forms_Form_ToFullScreen
    ///               {
    ///                   [TestMethod]
    ///                   public void ToFullScreen()
    ///                   {
    ///                       // Type
    ///                       var @this = new Form();
    ///           
    ///                       // Examples
    ///                       @this.ToFullScreen(); // The Form is now in FullScreen
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static void ToFullScreen(this Form form, int screen = 0)
    {
        form.StartPosition = FormStartPosition.Manual;
        form.Bounds = Screen.AllScreens[screen].Bounds;
    }
}