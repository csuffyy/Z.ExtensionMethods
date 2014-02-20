using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class StringExtension
{
    /// <summary>
    /// ��ȡ�ļ����������ļ������������ļ��У�
    /// </summary>
    /// <param name="path">�ļ�·��</param>
    /// <returns>�����ļ����Ƽ���</returns>
    public static IEnumerable<string> GetFiles(this string path)
    {
        if (path.IsNullOrWhiteSpace() || !Directory.Exists(path))
        {
            return null;
        }
        return new DirectoryInfo(path).GetFiles().Select(x => x.FullName);
    }

    /// <summary>
    /// ��ȡ�ļ����������ļ����������ļ��У�
    /// </summary>
    /// <param name="path">�ļ�·��</param>
    /// <returns>�����ļ����Ƽ���</returns>
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