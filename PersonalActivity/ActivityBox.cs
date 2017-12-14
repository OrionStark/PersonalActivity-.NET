using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalActivity
{
    public partial class ActivityBox : UserControl
    {
        public ActivityBox(string activity)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(200, Color.DodgerBlue);
            this.activity.Text = activity;
        }
    }
}
