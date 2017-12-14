using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalActivity
{
    public partial class Home : Form
    {
        public static PersonalActivityReferences.LibraryStorage.UserStorage user_now;
        public Home()
        {
            splash();
            logorReg();
            InitializeComponent();
            weather = new Weather();
            music = new Music_and_Chatting(user_now);
            alarm = new AlarmPage(user_now);
            act_list = new ActivityList(user_now);
            email_f = new GmailSender(user_now);
            act_settings = new Account_Settings(user_now);
            //user_now = new PersonalActivityReferences.LibraryStorage.UserStorage();
            panel3.BackColor = Color.FromArgb(180, Color.DeepSkyBlue);
            panel6.BackColor = Color.FromArgb(180, Color.LightPink);
            panel8.BackColor = Color.FromArgb(180, Color.Orange);
            panel13.BackColor = Color.FromArgb(180, Color.LimeGreen);
            panel14.BackColor = Color.FromArgb(180, Color.Navy);
            this.label11.Text = user_now.getOnlineUserInformation()[0];
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }
        bool istopPaneldrag = false;
        Point offset;
        Weather weather;
        Music_and_Chatting music;
        AlarmPage alarm;
        ActivityList act_list;
        Account_Settings act_settings;
        GmailSender email_f;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                istopPaneldrag = true;
                Point pointstartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointstartPosition.X;
                offset.Y = this.Location.Y - pointstartPosition.Y;
            }
            else
            {
                istopPaneldrag = false;
            }
        }
        private void splash()
        {
            Splash splsh = new Splash();
            Application.Run(splsh);
        }
        private void logorReg()
        {
            FirstPage fp = new FirstPage();
            Application.Run(fp);
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (istopPaneldrag)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                Point newPoint = panel1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            this.istopPaneldrag = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (weather.IsHandleCreated)
            {
                weather.BringToFront();
            }
            weather.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (music.IsHandleCreated)
            {
                music.BringToFront();
            }
            music.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            if (alarm.IsHandleCreated)
            {
                alarm.BringToFront();
            }
            alarm.Show();
        }
        private void cleanBuffer()
        {
            this.music.disconnectFromservver();
            this.music.Dispose();
            this.music.music_player.WindowCLosedstop();
            this.weather.Dispose();
            this.alarm.Dispose();
            this.music = null;
            this.weather = null;
            this.alarm = null;
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            cleanBuffer();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (act_list.IsHandleCreated)
            {
                act_list.BringToFront();
            }
            act_list.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (email_f.IsHandleCreated)
            {
                email_f.BringToFront();
            }
            email_f.Show();
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            if (act_settings.IsHandleCreated)
            {
                act_settings.BringToFront();
            }

            act_settings.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label11.Text = user_now.getOnlineUserInformation()[0];
        }
    }
}
