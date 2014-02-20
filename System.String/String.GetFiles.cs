using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class StringExtension
{
    /// <summary>
    /// 获取文件夹下所有文件（不包含子文件夹）
    /// </summary>
    /// <param name="path">文件路径</param>
    /// <returns>所有文件名称集合</returns>
    public static IEnumerable<string> GetFiles(this string path)
    {
        if (path.IsNullOrWhiteSpace() || !Directory.Exists(path))
        {
            return null;
        }
        return new DirectoryInfo(path).GetFiles().Select(x => x.FullName);
    }

    /// <summary>
    /// 获取文件夹下所有文件（包含子文件夹）
    /// </summary>
    /// <param name="path">文件路径</param>
    /// <returns>所有文件名称集合</returns>
    public static IEnumerable<string> GetFilesInAllSubdirectories(this string path)
    {
        if (path.IsNullOrWhiteSpace() || !Directory.Exists(path))
        {
            return null;
        }
        var di = new DirectoryInfo(path);
        return di.GetDirectories()
                 .SelectMany(x => GetFilesInAllSubdirectories(x.FullName))
                 .Concat(di.GetFiles()
                           .Select(x => x.FullName));
    }
}