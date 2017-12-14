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
    public partial class PassInput : Form
    {
        public PassInput()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            GmailSender.pass = this.passBox.Text;
            this.Close();
        }
    }
}
