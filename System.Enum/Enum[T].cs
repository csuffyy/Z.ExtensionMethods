using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 提供将枚举类型输出为集合类型的扩展方法
/// </summary>
/// <typeparam name="T">枚举类型</typeparam>
public partial class Enum<T> : IEnumerable<T>
{
    /// <summary>
    /// 返回类型为 IEnumerable 的输入。
    /// </summary>
    /// <returns>类型为 IEnumerable 的序列。</returns>
    public static IEnumerable<T> AsEnumerable()
    {
        return new Enum<T>();
    }

    /// <summary>
    /// To the list.
    /// </summary>
    /// <returns>List{`0}.</returns>
    public static IList<T> ToList()
    {
        return Enumerable.ToList(new Enum<T>());
    }

    /// <summary>
    /// 返回一个循环访问集合的枚举数。
    /// </summary>
    /// <returns>可用于循环访问集合的 IEnumerator</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return Enumerable.Cast<T>(Enum.GetValues(typeof(T))).GetEnumerator();
    }

    /// <summary>
    /// 返回一个循环访问集合的枚举器。
    /// </summary>
    /// <returns>可用于循环访问集合的 <see cref="T:System.Collections.IEnumerator" /> 对象。</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// 返回一个循环访问集合的枚举器。
    /// </summary>
    /// <returns>可用于循环访问集合的 <see cref="T:System.Collections.IEnumerator" /> 对象。</returns>
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return GetEnumerator();
    }
}
