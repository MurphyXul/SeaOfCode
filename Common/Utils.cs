using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimpleMidiPlayer.Common
{
    public class Utils
    {

        public static void MsgBox(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MsgBoxErr(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MsgBoxQue(string msg)
        {
            return MessageBox.Show(msg, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        /// <summary>
        /// 输入是否为拍子
        /// </summary>
        /// <param name="beat"></param>
        /// <returns></returns>
        public static bool IsBeat(string beat)
        {
            Regex reg = new Regex("^\\d+/\\d+$");
            if(beat=="")return false;
            return  reg.IsMatch(beat);
        }

        /// <summary>
        /// 是否为有效音符
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static bool IsNote(string note)
        {
            Regex Reg = new Regex("([+\\-#!]?)([0-7])(/*)(-*)(\\.*)(\\(?)(\\)?)");
            return Reg.IsMatch(note);
        }
    }
}
