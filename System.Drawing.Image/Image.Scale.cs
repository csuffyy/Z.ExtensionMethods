// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public static partial class ImageExtension
{
    /// <summary>
    ///     An Image extension method that scales an image to the specific ratio.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="ratio">The ratio.</param>
    /// <returns>The scaled image to the specific ratio.</returns>
    /// <example>
    ///     <code>
    ///           using System.Drawing;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Drawing_Image_Scale
    ///               {
    ///                   [TestMethod]
    ///                   public void Scale()
    ///                   {
    ///                       // Type
    ///                       var @this = new Bitmap(1, 1);
    ///           
    ///                       // Examples
    ///                       Image value1 = @this.Scale(2); // return an Image(2, 2);
    ///                       Image value2 = @this.Scale(2, 2); // return an Image(2, 2);
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(2, value1.Width);
    ///                       Assert.AreEqual(2, value1.Height);
    ///                       Assert.AreEqual(2, value2.Width);
    ///                       Assert.AreEqual(2, value2.Height);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Image Scale(this Image @this, double ratio)
    {
        int width = Convert.ToInt32(@this.Width*ratio);
        int height = Convert.ToInt32(@this.Height*ratio);

        var r = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(@this, 0, 0, width, height);
        }

        return r;
    }

    /// <summary>
    ///     An Image extension method that scales an image to a specific with and height.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <returns>The scaled image to the specific width and height.</returns>
    /// <example>
    ///     <code>
    ///           using System.Drawing;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Drawing_Image_Scale
    ///               {
    ///                   [TestMethod]
    ///                   public void Scale()
    ///                   {
    ///                       // Type
    ///                       var @this = new Bitmap(1, 1);
    ///           
    ///                       // Examples
    ///                       Image value1 = @this.Scale(2); // return an Image(2, 2);
    ///                       Image value2 = @this.Scale(2, 2); // return an Image(2, 2);
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(2, value1.Width);
    ///                       Assert.AreEqual(2, value1.Height);
    ///                       Assert.AreEqual(2, value2.Width);
    ///                       Assert.AreEqual(2, value2.Height);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static Image Scale(this Image @this, int width, int height)
    {
        var r = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(@this, 0, 0, width, height);
        }

        return r;
    }
}