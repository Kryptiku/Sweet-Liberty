using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Initial_UI_Design
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            setMusic(@"Long Night of Solace.wav");
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            CreateGame();
        }

        private void CreateGame()
        {
            playMusic();
        }

        private void setMusic(string filepath)
        {
            MXP.URL = filepath;
            MXP.settings.playCount = 9999;
            MXP.Ctlcontrols.stop();
            MXP.Visible = false;
        }

        private void playMusic()
        {
            MXP.Ctlcontrols.play();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pickup_btn_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void top_control_btn_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
