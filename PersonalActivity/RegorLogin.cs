using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PersonalActivity
{
    public partial class FirstPage : Form
    {
        public static PersonalActivityReferences.LibraryStorage.UserStorage user;
        Register reg_page;
        Home home;
        bool istopPaneldrag = false;
        Point offset;
        public FirstPage()
        {
            InitializeComponent();
        }
        /*
        public FirstPage(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            reg_page = new Register();
            this.user = user;
        }
         * */
        private void reg_btn_Click(object sender, EventArgs e)
        {
            reg_page = new Register();
            reg_page.ShowDialog();
        }
        private bool checkField()
        {
            if (username.Text != "" && password.Text != "")
            {
                if (user.logIn(username.Text, password.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkField())
                {
                    /*
                    home = new Home();
                    home.Show();
                    this.Hide();
                     
                     * */
                    Home.user_now = user;
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Check again your information");
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
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
