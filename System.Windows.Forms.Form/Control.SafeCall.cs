using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public static partial class WinForm_ControlExtension
{
    /// <summary>
    /// 安全调用
    /// </summary>
    /// <param name="ctrl">控件</param>
    /// <param name="callback">调用的委托</param>
    public static void SafeCall(this Control ctrl, Action callback)
    {
        if (ctrl.InvokeRequired)
        {
            ctrl.Invoke(callback);
        }
        else
        {
            callback();
        }
    }
}