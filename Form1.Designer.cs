namespace VlcPlayer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tkbProgress = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolumeDecrease = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnVolumeIncrease = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlControl);
            this.panel1.Controls.Add(this.pnlVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 468);
            this.panel1.TabIndex = 0;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVideo.Location = new System.Drawing.Point(3, 3);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(688, 385);
            this.pnlVideo.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Controls.Add(this.lblProgress);
            this.pnlControl.Controls.Add(this.lblVolume);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.btnVolumeIncrease);
            this.pnlControl.Controls.Add(this.btnVolumeDecrease);
            this.pnlControl.Controls.Add(this.btnStop);
            this.pnlControl.Controls.Add(this.btnPause);
            this.pnlControl.Controls.Add(this.btnPlay);
            this.pnlControl.Controls.Add(this.btnOpenFile);
            this.pnlControl.Controls.Add(this.tkbProgress);
            this.pnlControl.Location = new System.Drawing.Point(3, 394);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(688, 71);
            this.pnlControl.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(3, 42);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(50, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(59, 42);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(115, 42);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(171, 42);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tkbProgress
            // 
            this.tkbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbProgress.Location = new System.Drawing.Point(3, 3);
            this.tkbProgress.Maximum = 100;
            this.tkbProgress.Name = "tkbProgress";
            this.tkbProgress.Size = new System.Drawing.Size(682, 45);
            this.tkbProgress.TabIndex = 1;
            this.tkbProgress.Scroll += new System.EventHandler(this.tkbProgress_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(250, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "音量：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVolumeDecrease
            // 
            this.btnVolumeDecrease.Location = new System.Drawing.Point(358, 42);
            this.btnVolumeDecrease.Name = "btnVolumeDecrease";
            this.btnVolumeDecrease.Size = new System.Drawing.Size(25, 23);
            this.btnVolumeDecrease.TabIndex = 0;
            this.btnVolumeDecrease.Text = "-";
            this.btnVolumeDecrease.UseVisualStyleBackColor = true;
            this.btnVolumeDecrease.Click += new System.EventHandler(this.btnVolumeDecrease_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(316, 42);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(36, 23);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "100";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVolumeIncrease
            // 
            this.btnVolumeIncrease.Location = new System.Drawing.Point(389, 42);
            this.btnVolumeIncrease.Name = "btnVolumeIncrease";
            this.btnVolumeIncrease.Size = new System.Drawing.Size(25, 23);
            this.btnVolumeIncrease.TabIndex = 0;
            this.btnVolumeIncrease.Text = "+";
            this.btnVolumeIncrease.UseVisualStyleBackColor = true;
            this.btnVolumeIncrease.Click += new System.EventHandler(this.btnVolumeIncrease_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Location = new System.Drawing.Point(584, 42);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(95, 23);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "00:00/00:00";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 500;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "VLC  播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tkbProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolumeDecrease;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnVolumeIncrease;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Timer timerRefresh;
    }
}

