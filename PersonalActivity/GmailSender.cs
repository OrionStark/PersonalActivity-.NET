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
    public partial class GmailSender : Form
    {
        paemail.Email EMAIL_SENDER;
        public static string pass;
        bool istopPaneldrag = false;
        Point offset;
        public GmailSender(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            EMAIL_SENDER = new paemail.Email(user);
            this.sender_box.Text = user.getOnlineUserInformation()[0];
        }
        private bool checkField()
        {
            if (this.subject_box.Text == "" || this.sender_box.Text == "" || this.bodymessage.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void send_box_Click(object sender, EventArgs e)
        {
            PassInput warnBox = new PassInput();
            warnBox.ShowDialog();
            try
            {
                EMAIL_SENDER.SUBJECT_MAIL = this.subject_box.Text;
                EMAIL_SENDER.PASSWORD = pass;
                EMAIL_SENDER.MESSAGE = this.bodymessage.Text;
                EMAIL_SENDER.sendEmail(this.target.Text, this.sender_box.Text);
                MessageBox.Show("Email sent");
            }
            catch (Exception a){
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

        private void cls_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mnmz_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
