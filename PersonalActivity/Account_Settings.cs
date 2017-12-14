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
    public partial class Account_Settings : Form
    {
        PersonalActivityReferences.LibraryStorage.UserStorage NOW_USER;
        PACheckUP.SystemCheckup checkup_system;
        bool istopPaneldrag = false;
        Point offset;
        public Account_Settings(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            NOW_USER = user;
            this.checkup_system = new PACheckUP.SystemCheckup();
            this.name_field.Text = this.NOW_USER.getOnlineUserInformation()[0];
            this.username_field.Text = this.NOW_USER.getOnlineUserInformation()[2];
            this.email_field.Text = this.NOW_USER.getOnlineUserInformation()[3];
            this.phoneN_field.Text = this.NOW_USER.getOnlineUserInformation()[1];
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                NOW_USER.changeUserInfo(this.NOW_USER.getOnlineUserInformation()[2], this.phoneN_field.Text);
                NOW_USER.changeUserInfoincaseName(this.NOW_USER.getOnlineUserInformation()[2], this.name_field.Text);
                Home.user_now = this.NOW_USER;
                MessageBox.Show("Information Changing Completed");
            }
            catch
            {
                MessageBox.Show("INformation Changing Failed");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.istopPaneldrag = false;
        }
    }
}
