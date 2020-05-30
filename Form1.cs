using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SimpleMidiPlayer.Midi;
namespace SimpleMidiPlayer
{
    public partial class Form1 : Form
    {
        private string _currentPath = "";

        private MusicDocument doc = new MusicDocument();

        public Form1()
        {
            InitializeComponent();
        }

        #region 加截窗口
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string name in Enum.GetNames(typeof(GeneralProgram)))
            {
                lbxMain.Items.Add(name);
            }
            txtScore.Dock = DockStyle.Fill;
            gbxProgram.Dock = DockStyle.Fill;
            gbxScore.Dock = DockStyle.Fill;
            //midi = new MidiDevice();
            CbxMode.Text = "G";

            string defaultPath = Application.StartupPath + "\\OpernFile";
            lblPath.Text = defaultPath;
            if (!System.IO.Directory.Exists(defaultPath)) System.IO.Directory.CreateDirectory(defaultPath);
            _currentPath = defaultPath;
            ReadFolder(_currentPath);
            ClearTextBox();
            doc.EndEvent += new MusicDocument.PlayEventHandler(PlayEnd);
        }
        #endregion

        #region 读取曲谱目录
        //加载默认目录曲谱
        private void ReadFolder(string path)
        {
            lbxScore.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (System.IO.Path.GetExtension(file).ToLower() == ".msf")
                    lbxScore.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file));
            }
        }
        #endregion

        #region 选择乐器
        private void lbxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMain.SelectedIndex == -1) return;
            lbxDetail.Items.Clear();
            foreach (string name in Enum.GetNames(Type.GetType("SimpleMidiPlayer.Midi." + Enum.GetName(typeof(GeneralProgramEN), lbxMain.SelectedIndex + 1))))
            {
                lbxDetail.Items.Add(name);
            }
        }
        private void btnSelectProgram_Click(object sender, EventArgs e)
        {
            if (lbxDetail.SelectedIndex == -1) return;
            int[] arr = (int[])Enum.GetValues(Type.GetType("SimpleMidiPlayer.Midi." + Enum.GetName(typeof(GeneralProgramEN), lbxMain.SelectedIndex + 1)));
            doc.ChangeProgram(arr[lbxDetail.SelectedIndex]);
            btnShowHide_Click(this, null);
        }
        private void lbxDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnSelectProgram_Click(this, null);
        }
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (btnShowHide.Text == ">>乐器选择>>")
            {
                btnShowHide.Text = "<<乐器选择<<";
                gbxProgram.Visible = true;
            }
            else
            {
                btnShowHide.Text = ">>乐器选择>>";
                gbxProgram.Visible = false;
            }
        }
        #endregion

        #region 曲谱选择
        private void btnSelectScore_Click(object sender, EventArgs e)
        {
            if (btnSelectScore.Text == ">>曲谱选择>>")
            {
                btnSelectScore.Text = "<<曲谱选择<<";
                gbxScore.Visible = false;
                //txtScore.Dock = DockStyle
            }
            else
            {
                btnSelectScore.Text = ">>曲谱选择>>";
                gbxScore.Visible = true;
            }
        }
        private void btnSelectMusicFile_Click(object sender, EventArgs e)
        {
            if (lbxScore.SelectedIndex == -1) return;
            doc.Open(_currentPath + "\\" + lbxScore.SelectedItem.ToString() + ".msf");
            ReadMusicScore();
            btnSelectScore_Click(this, null);
        }
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.MyComputer;
            dlg.SelectedPath = _currentPath;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _currentPath = dlg.SelectedPath;
                lblPath.Text = _currentPath;
                ReadFolder(_currentPath);
            }
        }
        private void lbxScore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnSelectMusicFile_Click(this, null);

        }
        #endregion



        #region 刷新文档
        private void RefreshDoc()
        {
            doc.MusicScore.Beat = txtBeat.Text;
            doc.MusicScore.BeatsPerMinute = (int)txtBeatsPerMinute.Value;
            doc.MusicScore.Mode = CbxMode.Text;
            doc.MusicScore.MusicName = txtMusicName.Text;
            doc.MusicScore.Score = txtScore.Text;

        }
        #endregion

        #region 保存
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtMusicName.Text.Trim() == "")
            {
              Common.Utils.MsgBoxErr("请输入歌曲名称！");
                txtMusicName.Focus();
                return;
            }
            if (!Common.Utils.IsBeat(txtBeat.Text))
            {
                Common.Utils.MsgBoxErr("拍子输入不正确,正确示例：4/4");
                txtBeat.Focus();
                return;
            }
            if (txtMusicName.Text.Trim() == "")
            {
                Common.Utils.MsgBoxErr("请输入歌曲名称！");
                txtMusicName.Focus();
                return;
            }
            if (txtScore.Text.Trim() == "")
            {
                Common.Utils.MsgBoxErr("请输入曲谱！");
                txtScore.Focus();
                return;
            }
            int i = 0, l = 0;  //第几个字符，字符长度

            foreach (string note in txtScore.Text.Split(','))
            {
                i++;
                l += note.Length;
                if (note == "") continue;
                if (!Common.Utils.IsNote(note))
                {
                    Common.Utils.MsgBoxErr(note + " 无法识别！");
                    txtScore.Select(l + i - note.Length - 1, note.Length);
                    return;
                }
            }

            doc.MusicScore.Beat = txtBeat.Text;
            doc.MusicScore.BeatsPerMinute = (int)txtBeatsPerMinute.Value;
            doc.MusicScore.Mode = CbxMode.Text;
            doc.MusicScore.MusicName = txtMusicName.Text;
            doc.MusicScore.Score = txtScore.Text;
            if (doc.Save())
            {
                Common.Utils.MsgBox("保存成功！");
                ReadFolder(_currentPath);
            }
        }
        #endregion

        #region 新建
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc.Close();
            doc = new MusicDocument();
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            txtScore.Text = "";
            txtMusicName.Text = "";
            CbxMode.Text = "G";
            txtBeat.Text = "4/4";
            txtBeatsPerMinute.Value = 80;
        }
        #endregion

        #region 打开
        private void ReadMusicScore()
        {
            if (doc.MusicScore != null)
            {
                txtScore.Text = doc.MusicScore.Score;
                txtMusicName.Text = doc.MusicScore.MusicName;
                CbxMode.Text = doc.MusicScore.Mode;
                txtBeat.Text = doc.MusicScore.Beat;
                txtBeatsPerMinute.Value = doc.MusicScore.BeatsPerMinute;

            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            doc.Open();
            ReadMusicScore();
        }
        #endregion

        #region 删除文件
        private void btnDeleteMusicFile_Click(object sender, EventArgs e)
        {
            if (lbxScore.SelectedIndex == -1) return;
            if (Common.Utils.MsgBoxQue("是否删除文件“" + lbxScore.SelectedItem.ToString() + "”？") != System.Windows.Forms.DialogResult.Yes) return;
            if (doc.Delete(_currentPath + "\\" + lbxScore.SelectedItem.ToString() + ".msf"))
            {
                Common.Utils.MsgBox("删除成功！");
                ReadFolder(_currentPath);
            }
        }
        #endregion


        private void PlayEnd()
        {
            btnPlay.Image = Properties.Resources.Play;
            btnPlay.Text = "播放";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            doc.Stop();
            btnPlay.Image = Properties.Resources.Play;
            btnPlay.Text = "播放";
        }
        #region 播放
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "播放")
            {
                RefreshDoc();
                if (doc.Play())
                {
                    btnPlay.Image = Properties.Resources.Pause;
                    btnPlay.Text = "暂停";
                }
            }
            else if (btnPlay.Text == "暂停")
            {
                btnPlay.Image = Properties.Resources.Play;
                btnPlay.Text = "播放";
                doc.Pause();
            }
        }
        #endregion

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            doc.Stop();
            doc.Close();
        }










    }
}
