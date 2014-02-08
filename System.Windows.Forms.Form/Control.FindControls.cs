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
    /// ��ȡ�ؼ�������ΪT�Ŀؼ��ļ���
    /// </summary>
    /// <typeparam name="T">�ؼ�</typeparam>
    /// <param name="control">�ؼ�</param>
    /// <returns>�ؼ�������ΪT�Ŀؼ��ļ���</returns>
    public static IEnumerable<T> FindControls<T>(this Control control) where T : Control
    {
        return FindControls<T>(control, null);
    }

    /// <summary>
    /// ��ȡ�ؼ�������ΪT�Ŀؼ��ļ���
    /// </summary>
    /// <typeparam name="T">�ؼ�</typeparam>
    /// <param name="control">�ؼ�</param>
    /// <param name="filter">��������</param>
    /// <returns>�ؼ�������ΪT�Ŀؼ��ļ���</returns>
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