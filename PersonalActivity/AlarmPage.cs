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
    public partial class AlarmPage : Form
    {
        PersonalActivityReferences.LibraryStorage.UserStorage USER_ON;
        AlarmSystem.AlarmSystem alarm;
        public AlarmPage(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            this.USER_ON = user;
            timer_now.Enabled = true;
            timer1.Enabled = true;
            alarm = new AlarmSystem.AlarmSystem(this.USER_ON);
            for (int i = 1; i <= 59; i++)
            {
                if (i != 24 && i <= 24)
                {
                    hours.Items.Add(i);
                }
                else if (i == 24 && i <= 24)
                {
                    hours.Items.Add(00);
                }
                Minute.Items.Add(i);
                Second.Items.Add(i);
            }
        }
        bool istopPaneldrag = false;
        Point offset;
        private void timer_now_Tick(object sender, EventArgs e)
        {
            timenow.Text = DateTime.Now.ToString("HH:mm:ss");
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
            istopPaneldrag = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarm = new AlarmSystem.AlarmSystem(this.USER_ON);
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 
                dateTimePicker1.Value.Day, 
                this.hours.SelectedIndex + 1, this.Minute.SelectedIndex + 1, this.Second.SelectedIndex + 1);
            if (this.dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Please check your input again");
            }
            else
            {
                alarm.setAlarm(this.dateTimePicker1.Value);
                this.flowLayoutPanel1.Controls.Add(new Alarm_field(alarm.add_to_History()));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarm.isUp())
            {
                timer1.Stop();
                MessageBox.Show("Wake Up");
                alarm.stopYelling();
                timer1.Start();
            }
        }
    }
}
