using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public static partial class ImageExtension
{
    /// <summary>
    /// ½«Image×ª»»Îªbyte[]
    /// </summary>
    /// <param name="image">Image</param>
    /// <returns>byte[]</returns>
    public static byte[] ToBytes(this Image image)
    {
        using (var ms = new MemoryStream())
        {
            image.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            var imageBytes = new byte[ms.Length];
            ms.Read(imageBytes, 0, imageBytes.Length);
            return imageBytes;
        }
    }
}