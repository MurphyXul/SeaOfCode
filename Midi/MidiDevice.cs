using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SimpleMidiPlayer.Midi
{
    public class MidiDevice : OutputDeviceBase
    {
        /// <summary>
        /// 获取设备数量
        /// </summary>
        public static int DeviceCount
        {
            get
            {
                return midiOutGetNumDevs();
            }
        }

        #region 设备相关函数
        /// <summary>
        /// 使用第一个设备
        /// </summary>
        public MidiDevice()
            : base(0)
        {
        }
        

        /// <summary>
        /// 取得所有Midi设备信息
        /// </summary>
        /// <returns></returns>
        public MidiOutCaps[] GetMidiDevice()
        {
            MidiOutCaps[] caps = new MidiOutCaps[MidiDevice.DeviceCount];
            for (int i = 0; i < MidiDevice.DeviceCount; i++)
            {
                midiOutGetDevCaps(i, ref caps[i], Marshal.SizeOf(caps[i]));
            }

            return caps;
        }
        #endregion

        #region 音乐相关函数
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="iStatus"></param>
        /// <param name="iChannel"></param>
        /// <param name="iData1"></param>
        /// <param name="iData2"></param>
        private void Send(int iStatus, int iChannel, int iData1, int iData2)
        {
            midiOutShortMsg(hndle, iStatus | iChannel | (iData1 << 8) | (iData2 << 16));
        }
        /// <summary>
        /// 键盘按下，默认为第一通道
        /// </summary>
        /// <param name="iData1"></param>
        /// <param name="iData2"></param>
        public void Note_On(int iData1, int iData2)
        {
            Note_On(0, iData1, iData2);
        }
        public void Note_On(int iChannel, int iData1, int iData2)
        {
            Send(0x90, iChannel, iData1, iData2);
        }
        public void Note_Off(int iData1, int iData2)
        {
            Note_Off(0, iData1, iData2);
        }
        public void Note_Off(int iChannel, int iData1, int iData2)
        {
            Send(0x80, iChannel, iData1, iData2);
        }

        public void LineBegin()
        {
            LineBegin( 0);
        }
        public void LineBegin(int iChannel)
        {
            Send(0xB0, iChannel, 73, 0);
            //Send(0xB0, iChannel,73, 20);
        }
        public void LineEnd()
        {
            LineEnd(0);
        }
        public void LineEnd(int iChannel)
        {
            //Send(0xB0, iChannel, 72, 0);
            Send(0xB0, iChannel, 73, 100);
        }

        /// <summary>
        /// 改变音色（乐器）
        /// </summary>
        /// <param name="iData1">音色序号（0-127）</param>
        public void ChangeProgram(int iData1)
        {
            ChangeProgram(0, iData1, 0);
        }
        public void ChangeProgram(int iChannel, int iData1, int iData2)
        {
           // ChangeControl(iChannel, 0, 0);
            Send(0xC0, iChannel, iData1, iData2);
        }

        public void ChangeControl(int iChannel, int iData1, int iData2)
        {
            Send(0xB0, iChannel, iData1, iData2);
        }
        #endregion

    }

    /// <summary>
    /// The exception that is thrown when a error occurs with the OutputDevice
    /// class.
    /// </summary>
    public class OutputDeviceException : MidiDeviceException
    {
        #region OutputDeviceException Members

        #region Win32 Midi Output Error Function

        [DllImport("winmm.dll")]
        private static extern int midiOutGetErrorText(int errCode,
            StringBuilder message, int sizeOfMessage);

        #endregion

        #region Fields

        // The error message.
        private StringBuilder message = new StringBuilder(128);

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the OutputDeviceException class with
        /// the specified error code.
        /// </summary>
        /// <param name="errCode">
        /// The error code.
        /// </param>
        public OutputDeviceException(int errCode)
            : base(errCode)
        {
            // Get error message.
            midiOutGetErrorText(errCode, message, message.Capacity);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return message.ToString();
            }
        }

        #endregion

        #endregion
    }
}
