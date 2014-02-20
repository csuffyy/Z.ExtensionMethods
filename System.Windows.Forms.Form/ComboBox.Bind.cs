using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public static partial class WinForm_ControlExtension
{
    /// <summary>
    /// °ó¶¨ComboBox
    /// </summary>
    /// <param name="cb"></param>
    /// <param name="list"></param>
    public static void Bind(this ComboBox cb, List<DictionaryEntry> list)
    {
        cb.DisplayMember = "Value";
        cb.ValueMember = "Key";
        cb.DataSource = list;
    }
}