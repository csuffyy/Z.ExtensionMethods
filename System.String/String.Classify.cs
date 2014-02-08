using System.Collections.Generic;
using System.Linq;

public static partial class StringExtension
{
    /// <summary>
    /// 对字符串进行分类
    /// </summary>
    /// <param name="s">要分类的字符串</param>
    /// <param name="list">类别组</param>
    /// <returns>所属的类别组</returns>
    public static IEnumerable<string> Classify(this string s, string[] list)
    {
        return list.IsNullOrEmpty() ? null : list.Where(s.Contains);
    }
}
