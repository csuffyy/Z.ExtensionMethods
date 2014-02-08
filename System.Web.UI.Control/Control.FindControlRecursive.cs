// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Web.UI;

/// ###
/// <summary>Control extension.</summary>
public static partial class Web_ControlExtension
{
    /// <summary>
    ///     Searches recursively in the container and child container for a server control with the specified id
    ///     parameter.
    /// </summary>
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
    ///               public class System_Web_UI_Control_FindControlRecursive
    ///               {
    ///                   [TestMethod]
    ///                   public void FindControlRecursive()
    ///                   {
    ///                       // Type
    ///                       var @this = new Control();
    ///                       @this.Controls.Add(new Control {ID = &quot;Fizz&quot;});
    ///                       @this.Controls[0].Controls.Add(new Literal {ID = &quot;Buzz&quot;});
    ///           
    ///                       // Examples
    ///                       Control value1 = @this.FindControlRecursive(&quot;Fizz&quot;); // return control as Control.
    ///                       var value2 = @this.FindControlRecursive&lt;Literal&gt;(&quot;Buzz&quot;); // return control as Literal.
    ///                       Control value3 = @this.FindControlRecursive(&quot;Z&quot;); // return null;
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Control FindControlRecursive(this Control @this, string id)
    {
        Control rControl = @this.FindControl(id);

        if (rControl == null)
        {
            foreach (Control control in @this.Controls)
            {
                rControl = control.FindControl(id);
                if (rControl != null)
                {
                    break;
                }
            }
        }

        return rControl;
    }

    ///// <summary>
    /////     Searches recursively in the container and child container for a server control with the specified id
    /////     parameter.
    ///// </summary>
    ///// <typeparam name="T">Generic type parameter.</typeparam>
    ///// <param name="this">The @this to act on.</param>
    ///// <param name="id">The identifier for the control to be found.</param>
    ///// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    ///// <example>
    /////     <code>
    /////           using System.Web.UI;
    /////           using System.Web.UI.WebControls;
    /////           using Microsoft.VisualStudio.TestTools.UnitTesting;
    /////           using Z.ExtensionMethods;
    /////           
    /////           namespace ExtensionMethods.Examples
    /////           {
    /////               [TestClass]
    /////               public class System_Web_UI_Control_FindControlRecursive
    /////               {
    /////                   [TestMethod]
    /////                   public void FindControlRecursive()
    /////                   {
    /////                       // Type
    /////                       var @this = new Control();
    /////                       @this.Controls.Add(new Control {ID = &quot;Fizz&quot;});
    /////                       @this.Controls[0].Controls.Add(new Literal {ID = &quot;Buzz&quot;});
    /////           
    /////                       // Examples
    /////                       Control value1 = @this.FindControlRecursive(&quot;Fizz&quot;); // return control as Control.
    /////                       var value2 = @this.FindControlRecursive&lt;Literal&gt;(&quot;Buzz&quot;); // return control as Literal.
    /////                       Control value3 = @this.FindControlRecursive(&quot;Z&quot;); // return null;
    /////                   }
    /////               }
    /////           }
    /////     </code>
    ///// </example>
    //public static T FindControlRecursive<T>(this Control @this, string id) where T : Control
    //{
    //    Control rControl = @this.FindControl(id);

    //    if (rControl == null)
    //    {
    //        foreach (Control control in @this.Controls)
    //        {
    //            rControl = control.FindControl(id);
    //            if (rControl != null)
    //            {
    //                break;
    //            }
    //        }
    //    }

    //    return rControl as T;
    //}
}