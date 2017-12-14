using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalActivityReferences.LibraryStorage;

namespace PersonalActivity
{
    public partial class Register : Form
    {
        UserStorage user_get_data;
        bool istopPaneldrag = false;
        Point offset;
        public Register()
        {
            InitializeComponent();
            user_get_data = new UserStorage();
        }
        private char getGender()
        {
            if (this.male_btn.Checked)
            {
                return 'M';
            }
            else if (this.female_btn.Checked)
            {
                return 'F';
            }
            else
            {
                return 'N';
            }
        }
        private void addUser()
        {
            try
            {
                user_get_data.UserCreator(this.name_field.Text, this.numberphone_field.Text, this.nickname_field.Text, this.password_field.Text
                    , this.email_field.Text, this.getGender());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private bool checkField()
        {
            if (this.name_field.Text != "" || this.numberphone_field.Text != ""
                || this.nickname_field.Text != "" || this.email_field.Text != "" || this.password_field.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void register_btnNow_Click(object sender, EventArgs e)
        {
            if (checkField())
            {
                addUser();
                /*
                FirstPage firstPage = new FirstPage(this.user_get_data);
                firstPage.Show();
                 * */
                FirstPage.user = this.user_get_data;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Some Field is Empty, Please Check Again !!!");
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
