using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlcPlayer
{
    public partial class Form1 : Form
    {
        VlcPlayerBase player = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string pluginPath = Environment.CurrentDirectory + "\\plugins\\";  //插件目录
                player = new VlcPlayerBase(pluginPath);
                player.SetRenderWindow((int)pnlVideo.Handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolumeDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    int volume = this.player.GetVolume();
                    volume--;
                    if (volume <0) volume = 0;
                    this.player.SetVolume(volume);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolumeIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    int volume = this.player.GetVolume();
                    volume++;

                    if (volume > 100) volume = 100;

                    this.player.SetVolume(volume);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if(ofd.ShowDialog()== DialogResult.OK)
                    {
                        player.LoadFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    this.player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    this.player.Pause();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    this.player.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player != null)
                {
                    int durationSecond = (int)this.player.Duration;
                    int playTimeSecond = (int)this.player.GetPlayTime();


                    this.lblProgress.Text = string.Format("{0}:{1}:{2}/{3}:{4}:{5}",
                        (playTimeSecond / 3600).ToString(),
                        (playTimeSecond / 60 % 60).ToString().PadLeft(2, '0'),
                        (playTimeSecond % 60).ToString().PadLeft(2, '0'),
                        (durationSecond / 3600).ToString(),
                        (durationSecond / 60 % 60).ToString().PadLeft(2, '0'),
                        (durationSecond % 60).ToString().PadLeft(2, '0'));

                    this.tkbProgress.Maximum = durationSecond;
                    this.tkbProgress.Value = playTimeSecond;
                    this.lblVolume.Text = string.Format("{0}",this.player.GetVolume());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tkbProgress_Scroll(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            try
            {
                if (player != null)
                {
                    this.player.SetPlayTime(this.tkbProgress.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timerRefresh.Enabled = true;
        }
    }
}
