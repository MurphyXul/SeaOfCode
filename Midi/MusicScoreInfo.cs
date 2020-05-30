using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SimpleMidiPlayer.Midi
{
    public class MusicScoreInfo
    {
        private int _beatsPerMinute = 80;    //每分钟80拍

        private string _beat = "4/4";   //以几分音符为一拍，默认为4/4
        //private int _millisecondPerBeat = 750;   //每拍750毫秒
        private string _score = "";
        private string _mode = "G";
        private string _musicName;

        #region 属性
        /// <summary>
        /// 曲名
        /// </summary>
        public string MusicName
        {
            get { return this._musicName; }
            set { this._musicName = value; }
        }

        /// <summary>
        /// 每分钟拍数
        /// </summary>
        public int BeatsPerMinute
        {
            get { return this._beatsPerMinute; }
            set { this._beatsPerMinute = value; }
        }

        /// <summary>
        /// 拍子
        /// </summary>
        public string Beat
        {
            get { return this._beat; }
            set { this._beat = value; }
        }

        /// <summary>
        /// 曲谱
        /// </summary>
        public string Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        public string Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 保存
        /// </summary>
        public bool Save(string filePath)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(MusicScoreInfo));
                Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                xs.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch (Exception er)
            {
                Common.Utils.MsgBoxErr(er.Message);
                return false;
            }
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <returns></returns>
        public static MusicScoreInfo Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(MusicScoreInfo));
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                MusicScoreInfo gc = xs.Deserialize(stream) as MusicScoreInfo;
                stream.Close();
                return gc;
            }
            return new MusicScoreInfo();

        }
        #endregion
    }
}
