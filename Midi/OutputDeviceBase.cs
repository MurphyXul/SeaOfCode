using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace SimpleMidiPlayer.Midi
{
    public class OutputDeviceBase 
    {
        #region Api定义
        

        [DllImport("winmm.dll")]
        protected static extern int midiOutPrepareHeader(int handle,
            IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        protected static extern int midiOutUnprepareHeader(int handle,
            IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        protected static extern int midiOutLongMsg(int handle,
            IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        protected static extern int midiOutGetDevCaps(int deviceID,
            ref MidiOutCaps caps, int sizeOfMidiOutCaps);

        [DllImport("winmm.dll")]
        protected static extern int midiOutGetNumDevs();
        /// <summary>
        /// 复置midi输出
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        protected static extern int midiOutReset(int handle);

        /// <summary>
        /// 向输出端口发送信息
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        protected static extern int midiOutShortMsg(int handle, int message);
        /// <summary>
        /// 打开midi输出设备
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="deviceID"></param>
        /// <param name="proc"></param>
        /// <param name="instance"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        protected static extern int midiOutOpen(ref int handle, int deviceID,
            MidiOutProc proc, int instance, int flags);

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        protected static extern int midiOutClose(int handle);


        protected const int MOM_OPEN = 0x3C7;
        protected const int MOM_CLOSE = 0x3C8;
        protected const int MOM_DONE = 0x3C9;
        #endregion
        

        protected delegate void GenericDelegate<T>(T args);

        // Represents the method that handles messages from Windows.
        protected delegate void MidiOutProc(int handle, int msg, int instance, int param1, int param2);

        private MidiOutProc midiOutProc;
        protected readonly object lockObject = new object();
        protected const int CALLBACK_FUNCTION = 196608;
        // The number of buffers still in the queue.
        protected int bufferCount = 0;
        
        protected int hndle = 0;
        public int Handle
        {
            get
            {
                return hndle;
            }
        }
        protected virtual void HandleMessage(int handle, int msg, int instance, int param1, int param2)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="deviceID"></param>
        public OutputDeviceBase(int deviceID)
        {
            midiOutProc = HandleMessage;
            int result = midiOutOpen(ref hndle, 0, midiOutProc, 0, CALLBACK_FUNCTION);
            if (result != MidiDeviceException.MMSYSERR_NOERROR)
            {
                Reset();
                throw new OutputDeviceException(result);
            }
        }

        /// <summary>
        /// 复位设备
        /// </summary>
        public void Reset()
        {

            lock (lockObject)
            {
                // Reset the OutputDevice.
                int result = midiOutReset(Handle);

                if (result == MidiDeviceException.MMSYSERR_NOERROR)
                {
                    while (bufferCount > 0)
                    {
                        Monitor.Wait(lockObject);
                    }
                }
                else
                {
                    // Throw an exception.
                    throw new OutputDeviceException(result);
                }
            }
        }

        /// <summary>
        /// 关闭设备
        /// </summary>
        public void Close()
        {
            lock (lockObject)
            {
                Reset();

                // Close the OutputDevice.
                int result = midiOutClose(Handle);

                if (result != MidiDeviceException.MMSYSERR_NOERROR)
                {
                    // Throw an exception.
                    throw new OutputDeviceException(result);
                }
            }
        }

        /// <summary>
        /// 发送消息到设备
        /// </summary>
        /// <param name="message"></param>
        protected void Send(int message)
        {
            lock (lockObject)
            {
                int result = midiOutShortMsg(Handle, message);

                if (result != MidiDeviceException.MMSYSERR_NOERROR)
                {
                    throw new OutputDeviceException(result);
                }
            }
        }

        /// <summary>
        /// 取设备信息
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        public static MidiOutCaps GetDeviceCapabilities(int deviceID)
        {
            MidiOutCaps caps = new MidiOutCaps();

            // Get the device's capabilities.
            int result = midiOutGetDevCaps(deviceID, ref caps, Marshal.SizeOf(caps));

            // If the capabilities could not be retrieved.
            if (result != MidiDeviceException.MMSYSERR_NOERROR)
            {
                // Throw an exception.
                throw new OutputDeviceException(result);
            }

            return caps;
        }
    }
}
