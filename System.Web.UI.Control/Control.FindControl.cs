// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Web.UI;

public static partial class ControlExtension
{
    /// <summary>
    ///     Searches the current naming container for a server control with the specified id parameter.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="id">The identifier for the control to be found.</param>
    /// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    /// <example>
    ///     <code>
    ///           using System.Web.UI;
    ///           using System.Web.UI.WebControls;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Web_UI_Control_FindControl
    ///               {
    ///                   [TestMethod]
    ///                   public void FindControl()
    ///                   {
    ///                       // Type
    ///                       var @this = new Control();
    ///                       @this.Controls.Add(new Literal {ID = &quot;Fizz&quot;});
    ///           
    ///                       // Examples
    ///                       var value1 = @this.FindControl&lt;Literal&gt;(&quot;Fizz&quot;); // return control as Literal.
    ///                       var value2 = @this.FindControl&lt;Literal&gt;(&quot;Buzz&quot;); // return null;
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T FindControl<T>(this Control @this, string id) where T : class
    {
        return (@this.FindControl(id) as T);
    }
}