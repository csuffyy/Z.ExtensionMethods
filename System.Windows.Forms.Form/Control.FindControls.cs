// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Windows.Forms;

public static partial class WinForm_ControlExtension
{
    /// <summary>
    /// 获取控件中类型为T的控件的集合
    /// </summary>
    /// <typeparam name="T">控件</typeparam>
    /// <param name="control">控件</param>
    /// <returns>控件中类型为T的控件的集合</returns>
    public static IEnumerable<T> FindControls<T>(this Control control) where T : Control
    {
        return FindControls<T>(control, null);
    }

    /// <summary>
    /// 获取控件中类型为T的控件的集合
    /// </summary>
    /// <typeparam name="T">控件</typeparam>
    /// <param name="control">控件</param>
    /// <param name="filter">过滤条件</param>
    /// <returns>控件中类型为T的控件的集合</returns>
    public static IEnumerable<T> FindControls<T>(this Control control, Predicate<T> filter) where T : Control
    {
        foreach (Control c in control.Controls)
        {
            if (c is T && (filter == null || filter(c as T)))
            {
                yield return c as T;
            }
            foreach (T fc in FindControls<T>(c, filter))
            {
                yield return fc;
            }
        }
    }
}