namespace SimpleMidiPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxProgram = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelectProgram = new System.Windows.Forms.Button();
            this.lbxDetail = new System.Windows.Forms.ListBox();
            this.lbxMain = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.CbxMode = new System.Windows.Forms.ComboBox();
            this.gbxScore = new System.Windows.Forms.GroupBox();
            this.lbxScore = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteMusicFile = new System.Windows.Forms.Button();
            this.btnSelectMusicFile = new System.Windows.Forms.Button();
            this.btnSelectScore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBeatsPerMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusicName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.gbxProgram.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbxScore.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeatsPerMinute)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProgram
            // 
            this.gbxProgram.Controls.Add(this.panel4);
            this.gbxProgram.Controls.Add(this.lbxDetail);
            this.gbxProgram.Controls.Add(this.lbxMain);
            this.gbxProgram.Location = new System.Drawing.Point(107, 133);
            this.gbxProgram.Name = "gbxProgram";
            this.gbxProgram.Size = new System.Drawing.Size(423, 74);
            this.gbxProgram.TabIndex = 0;
            this.gbxProgram.TabStop = false;
            this.gbxProgram.Text = "音色选择";
            this.gbxProgram.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSelectProgram);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(256, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 28);
            this.panel4.TabIndex = 2;
            // 
            // btnSelectProgram
            // 
            this.btnSelectProgram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectProgram.Location = new System.Drawing.Point(35, 3);
            this.btnSelectProgram.Name = "btnSelectProgram";
            this.btnSelectProgram.Size = new System.Drawing.Size(94, 23);
            this.btnSelectProgram.TabIndex = 0;
            this.btnSelectProgram.Text = "使用所选音色";
            this.btnSelectProgram.UseVisualStyleBackColor = true;
            this.btnSelectProgram.Click += new System.EventHandler(this.btnSelectProgram_Click);
            // 
            // lbxDetail
            // 
            this.lbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDetail.FormattingEnabled = true;
            this.lbxDetail.ItemHeight = 12;
            this.lbxDetail.Location = new System.Drawing.Point(256, 17);
            this.lbxDetail.Name = "lbxDetail";
            this.lbxDetail.Size = new System.Drawing.Size(164, 54);
            this.lbxDetail.TabIndex = 1;
            this.lbxDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxDetail_MouseDoubleClick);
            // 
            // lbxMain
            // 
            this.lbxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxMain.FormattingEnabled = true;
            this.lbxMain.ItemHeight = 12;
            this.lbxMain.Location = new System.Drawing.Point(3, 17);
            this.lbxMain.Name = "lbxMain";
            this.lbxMain.Size = new System.Drawing.Size(253, 54);
            this.lbxMain.TabIndex = 0;
            this.lbxMain.SelectedIndexChanged += new System.EventHandler(this.lbxMain_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(25, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 363);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowHide.Location = new System.Drawing.Point(0, 0);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(25, 388);
            this.btnShowHide.TabIndex = 2;
            this.btnShowHide.Text = ">>乐器选择>>";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtScore
            // 
            this.txtScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScore.Location = new System.Drawing.Point(28, 57);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(617, 331);
            this.txtScore.TabIndex = 5;
            // 
            // CbxMode
            // 
            this.CbxMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMode.FormattingEnabled = true;
            this.CbxMode.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.CbxMode.Location = new System.Drawing.Point(294, 6);
            this.CbxMode.Name = "CbxMode";
            this.CbxMode.Size = new System.Drawing.Size(57, 20);
            this.CbxMode.TabIndex = 7;
            // 
            // gbxScore
            // 
            this.gbxScore.Controls.Add(this.lbxScore);
            this.gbxScore.Controls.Add(this.panel1);
            this.gbxScore.Controls.Add(this.panel3);
            this.gbxScore.Location = new System.Drawing.Point(110, 213);
            this.gbxScore.Name = "gbxScore";
            this.gbxScore.Size = new System.Drawing.Size(420, 158);
            this.gbxScore.TabIndex = 9;
            this.gbxScore.TabStop = false;
            this.gbxScore.Text = "曲谱";
            this.gbxScore.Visible = false;
            // 
            // lbxScore
            // 
            this.lbxScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxScore.FormattingEnabled = true;
            this.lbxScore.ItemHeight = 12;
            this.lbxScore.Location = new System.Drawing.Point(3, 47);
            this.lbxScore.Name = "lbxScore";
            this.lbxScore.Size = new System.Drawing.Size(414, 67);
            this.lbxScore.TabIndex = 3;
            this.lbxScore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxScore_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 30);
            this.panel1.TabIndex = 4;
            // 
            // lblPath
            // 
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(0, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(308, 30);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "曲谱目录：";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectPath.Location = new System.Drawing.Point(308, 0);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(106, 30);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "查看其它目录...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteMusicFile);
            this.panel3.Controls.Add(this.btnSelectMusicFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 41);
            this.panel3.TabIndex = 5;
            // 
            // btnDeleteMusicFile
            // 
            this.btnDeleteMusicFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteMusicFile.Location = new System.Drawing.Point(231, 9);
            this.btnDeleteMusicFile.Name = "btnDeleteMusicFile";
            this.btnDeleteMusicFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMusicFile.TabIndex = 1;
            this.btnDeleteMusicFile.Text = "删除所选";
            this.btnDeleteMusicFile.UseVisualStyleBackColor = true;
            this.btnDeleteMusicFile.Click += new System.EventHandler(this.btnDeleteMusicFile_Click);
            // 
            // btnSelectMusicFile
            // 
            this.btnSelectMusicFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectMusicFile.Location = new System.Drawing.Point(108, 9);
            this.btnSelectMusicFile.Name = "btnSelectMusicFile";
            this.btnSelectMusicFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectMusicFile.TabIndex = 0;
            this.btnSelectMusicFile.Text = "打开所选";
            this.btnSelectMusicFile.UseVisualStyleBackColor = true;
            this.btnSelectMusicFile.Click += new System.EventHandler(this.btnSelectMusicFile_Click);
            // 
            // btnSelectScore
            // 
            this.btnSelectScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectScore.Location = new System.Drawing.Point(645, 0);
            this.btnSelectScore.Name = "btnSelectScore";
            this.btnSelectScore.Size = new System.Drawing.Size(25, 388);
            this.btnSelectScore.TabIndex = 10;
            this.btnSelectScore.Text = "<<选择曲谱<<";
            this.btnSelectScore.UseVisualStyleBackColor = true;
            this.btnSelectScore.Click += new System.EventHandler(this.btnSelectScore_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBeat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBeatsPerMinute);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMusicName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CbxMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 32);
            this.panel2.TabIndex = 12;
            // 
            // txtBeat
            // 
            this.txtBeat.Location = new System.Drawing.Point(556, 6);
            this.txtBeat.Name = "txtBeat";
            this.txtBeat.Size = new System.Drawing.Size(55, 21);
            this.txtBeat.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "拍子：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "每分钟拍数：";
            // 
            // txtBeatsPerMinute
            // 
            this.txtBeatsPerMinute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBeatsPerMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBeatsPerMinute.Location = new System.Drawing.Point(451, 6);
            this.txtBeatsPerMinute.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtBeatsPerMinute.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBeatsPerMinute.Name = "txtBeatsPerMinute";
            this.txtBeatsPerMinute.Size = new System.Drawing.Size(51, 21);
            this.txtBeatsPerMinute.TabIndex = 8;
            this.txtBeatsPerMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBeatsPerMinute.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "调式：";
            // 
            // txtMusicName
            // 
            this.txtMusicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMusicName.Location = new System.Drawing.Point(61, 6);
            this.txtMusicName.Name = "txtMusicName";
            this.txtMusicName.Size = new System.Drawing.Size(171, 21);
            this.txtMusicName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "曲名：";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.btnPlay,
            this.btnStop});
            this.toolStrip.Location = new System.Drawing.Point(25, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(620, 25);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "新建";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "打开";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "保存";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "帮助";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = global::SimpleMidiPlayer.Properties.Resources.Play;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "播放";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::SimpleMidiPlayer.Properties.Resources.Stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 388);
            this.Controls.Add(this.gbxScore);
            this.Controls.Add(this.gbxProgram);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.btnSelectScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简谱播放器 1.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProgram.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbxScore.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeatsPerMinute)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProgram;
        private System.Windows.Forms.ListBox lbxDetail;
        private System.Windows.Forms.ListBox lbxMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ComboBox CbxMode;
        private System.Windows.Forms.GroupBox gbxScore;
        private System.Windows.Forms.ListBox lbxScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnSelectScore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtBeatsPerMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusicName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBeat;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteMusicFile;
        private System.Windows.Forms.Button btnSelectMusicFile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelectProgram;
        private System.Windows.Forms.ToolStripButton btnStop;
    }
}

