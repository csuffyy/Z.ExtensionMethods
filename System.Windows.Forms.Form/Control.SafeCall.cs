using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public static partial class WinForm_ControlExtension
{
    /// <summary>
    /// ��ȫ����
    /// </summary>
    /// <param name="ctrl">�ؼ�</param>
    /// <param name="callback">���õ�ί��</param>
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