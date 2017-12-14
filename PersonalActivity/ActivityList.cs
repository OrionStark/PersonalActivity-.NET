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
    public partial class ActivityList : Form
    {
        PersonalActivityReferences.LibraryStorage.ActivityList activity_lst;
        bool istopPaneldrag = false;
        Point offset;
        public ActivityList(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            activity_lst = new PersonalActivityReferences.LibraryStorage.ActivityList(user);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void setActivity()
        {
            if (activity_des.Text == "")
            {
                MessageBox.Show("Please check your input again");
            }
            else
            {
                activity_lst.setActivity(dateTimePicker1.Value, activity_des.Text);
                MessageBox.Show("Activity added");
                flowLayoutPanel2.Controls.Add(new Activity_box21(dateTimePicker1.Value, activity_des.Text));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.istopPaneldrag = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            setActivity();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                activity_lst.todayActivity();
                if (activity_lst.todayActivity().Count > 0)
                {
                    for (int i = 0; i < activity_lst.todayActivity().Count; i++)
                    {
                        flowLayoutPanel1.Controls.Add(new ActivityBox(activity_lst.todayActivity()[i]));
                    }
                }
            }
            else
            {
                activity_lst.todayActivity();
                if (activity_lst.todayActivity().Count > 0)
                {
                    for (int i = 0; i < activity_lst.todayActivity().Count; i++)
                    {
                        flowLayoutPanel1.Controls.Add(new ActivityBox(activity_lst.todayActivity()[i]));
                    }
                }
            }
        }
    }
}
