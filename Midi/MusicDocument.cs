using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleMidiPlayer.Midi
{
    public class MusicDocument
    {
        private string _fullFileName = "";

        private MusicScoreInfo _musicScore;
        private MidiDevice midi = new MidiDevice();
        private Note[] _noteseq = null;
        private System.Timers.Timer timer = new System.Timers.Timer(1000);
        private int _playIndex = 0;
        private DateTime _noteOnTime;   //按下时间
        private DateTime _pauseTime;    //暂停时间
        private bool _isPause = false;  //是否已暂停

        public delegate void PlayEventHandler();
        public event PlayEventHandler EndEvent;
        public MusicDocument()
        {
            _musicScore = new MusicScoreInfo();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        public void Close()
        {
            midi.Close();
        }

        #region 保存
        public bool Save()
        {
            if (_fullFileName == "")
            {
                _fullFileName = ShowSaveDialog();
                if (_fullFileName == "") return false;
            }
            else
            {
                _fullFileName = _fullFileName.Substring(0, _fullFileName.LastIndexOf('\\') + 1) + _musicScore.MusicName + ".msf";
            }
            return _musicScore.Save(_fullFileName);
        }

        private string ShowSaveDialog()
        {
            System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.DefaultExt = ".msf";
            dlg.Filter = "简谱乐曲文件(*.msf)|*.msf";
            dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "OpernFile";

            dlg.FileName = _musicScore.MusicName;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
                return "";
        }
        #endregion

        #region 打开
        private string ShowOpenDialog()
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.DefaultExt = ".msf";
            dlg.Filter = "简谱乐曲文件(*.msf)|*.msf";
            dlg.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\" + _musicScore.MusicName;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
                return "";
        }
        public void Open()
        {
            _fullFileName = ShowOpenDialog();
            if (_fullFileName == "") return;
            Open(_fullFileName);
        }

        public void Open(string fileName)
        {
            _fullFileName = fileName;
            _musicScore = MusicScoreInfo.Read(fileName);
        }
        #endregion

        #region 删除
        public bool Delete(string fileName)
        {
            try
            {
                System.IO.File.Delete(fileName);
                return true;
            }
            catch (Exception er)
            {
                Common.Utils.MsgBoxErr(er.Message);
                return false;
            }
        }
        #endregion

        public MusicScoreInfo MusicScore
        {
            get { return _musicScore; }
            set { this._musicScore = value; }
        }

        #region 获取拍子时值
        private int Beat
        {
            get
            {
                switch (_musicScore.Beat.Split('/')[1])
                {
                    case "2":
                        return 30000;

                    case "6":
                        return 90000;

                    case "8":
                        return 120000;

                    case "16":
                        return 240000;

                    default:
                        return 60000;
                }
            }
        }
        #endregion

        #region 播放
        public bool Play()
        {
            //if (_noteseq == null)
            if (_musicScore.Score == "") return false;
            ReadNoteSeq();
            if (_noteseq.Length == 0) return false;
            if (_isPause)
            {
                int ms = (_pauseTime - _noteOnTime).Milliseconds;
                if (_noteseq[_playIndex - 1].iDur >= ms)
                    timer.Interval = _noteseq[_playIndex - 1].iDur - (_pauseTime - _noteOnTime).Milliseconds;
                
            }
            else
                timer.Interval = 100;
            timer.Start();
            return true;
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_playIndex == _noteseq.Length)
            {
                midi.Note_On((int)_noteseq[_playIndex - 1].iNote, 0);
                timer.Stop();
                _playIndex = 0;
                _isPause = false;
                EndEvent();
                return;
            }
            if (_playIndex > 0)
            {
                midi.Note_On((int)_noteseq[_playIndex - 1].iNote, 0);
            }
            if (_noteseq[_playIndex].iNote != Octave.Z)
            {
                if (_noteseq[_playIndex].line == 1)
                    midi.LineEnd();
                else if (_noteseq[_playIndex].line == 0)
                    midi.LineBegin();
                midi.Note_On((int)_noteseq[_playIndex].iNote, 100);

            }
            _noteOnTime = DateTime.Now;
            timer.Interval = _noteseq[_playIndex].iDur;
            _playIndex++;
        }
        private void ReadNoteSeq()
        {
            int _millisecondPerBeat = (int)((float)Beat / (float)_musicScore.BeatsPerMinute);    //重新计算每拍毫秒时间
            MusicMode _mode = (MusicMode)Enum.Parse(typeof(MusicMode), _musicScore.Mode);

            Regex Reg = new Regex("([+\\-#!]?)([0-7])(/*)(-*)(\\.*)(\\(?)(\\)?)(%*)");
            string[] notes = _musicScore.Score.TrimEnd(',').TrimStart(',').Split(',');
            _noteseq = new Note[notes.Length];
            int[] octave = (int[])Enum.GetValues(typeof(Octave));
            int i = 0;
            foreach (string n in notes)
            {

                Match m = Reg.Match(n);
                if (!m.Success) continue;
                //唱名
                if (int.Parse(m.Groups[2].Value) == 0)
                    _noteseq[i].iNote = Octave.Z;
                else
                    _noteseq[i].iNote = (Octave)(octave[int.Parse(m.Groups[2].Value) - 1] + _mode);
                _noteseq[i].iDur = _millisecondPerBeat;    //
                _noteseq[i].line = -1;
                //高低音
                if (m.Groups[1].Value != "")
                {
                    if (m.Groups[1].Value == "+")
                        _noteseq[i].iNote += 12;
                    else if (m.Groups[1].Value == "-")
                        _noteseq[i].iNote -= 12;
                    else if (m.Groups[1].Value == "#")
                        _noteseq[i].iNote += 1;
                    else if (m.Groups[1].Value == "!")
                        _noteseq[i].iNote -= 1;

                }
                //8分音符或更短
                if (m.Groups[3].Value != "")
                {
                    _noteseq[i].iDur = _noteseq[i].iDur / m.Groups[3].Value.Length / 2;
                    if(m.Groups[8].Value != "") 
                    {
                        _noteseq[i].iDur = _noteseq[i].iDur * 2 / 3;
                    }

                }
                //二分音符或更长
                if (m.Groups[4].Value != "")
                {
                    _noteseq[i].iDur += m.Groups[4].Value.Length * _noteseq[i].iDur;
                }
                //附点音符
                if (m.Groups[5].Value != "")
                {
                    if (m.Groups[5].Value.Length == 1)
                        _noteseq[i].iDur = (float)(_noteseq[i].iDur * 1.5);
                    else
                        _noteseq[i].iDur = (float)(_noteseq[i].iDur * 1.75);
                }
                //连音开始
                if (m.Groups[6].Value != "")
                {
                    _noteseq[i].line = 1;
                }
                //连音结束
                if (m.Groups[7].Value != "")
                {
                    _noteseq[i].line = 0;
                }
                i++;

            }

        }
        #endregion

        #region 改变音色
        public void ChangeProgram(int program)
        {
            midi.ChangeProgram(program - 1);
        }
        #endregion

        #region 停止
        public void Stop()
        {
            timer.Stop();
            if (_musicScore.Score == "") return;
            if (_noteseq.Length == 0) return;
            if (_playIndex != 0)
                midi.Note_On((int)_noteseq[_playIndex - 1].iNote, 0);
            _playIndex = 0;
            _isPause = false;
            EndEvent();
        }

        public void Pause()
        {
            timer.Stop();
            _pauseTime = DateTime.Now;
            _isPause = true;
            if (_musicScore.Score == "") return;
            if (_noteseq.Length == 0) return;
            midi.Note_On((int)_noteseq[_playIndex - 1].iNote, 0);
        }
        #endregion
    }
}
