// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Drawing;

public static partial class ImageExtension
{
    /// <summary>
    ///     An Image extension method that cuts an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    /// <returns>The cutted image.</returns>
    /// <example>
    ///     <code>
    ///           using System.Drawing;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Drawing_Image_Cut
    ///               {
    ///                   [TestMethod]
    ///                   public void Cut()
    ///                   {
    ///                       // Type
    ///                       var @this = new Bitmap(2, 2);
    ///           
    ///                       // Examples
    ///                       Image value = @this.Cut(1, 1, 1, 1); // Return an Image(1, 1)
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(1, value.Width);
    ///                       Assert.AreEqual(1, value.Height);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Image Cut(this Image @this, int width, int height, int x, int y)
    {
        var r = new Bitmap(width, height);
        var destinationRectange = new Rectangle(0, 0, width, height);
        var sourceRectangle = new Rectangle(x, y, width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.DrawImage(@this, destinationRectange, sourceRectangle, GraphicsUnit.Pixel);
        }

        return r;
    }
}