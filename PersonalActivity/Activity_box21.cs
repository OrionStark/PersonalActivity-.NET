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
    public partial class Activity_box21 : UserControl
    {
        public Activity_box21(DateTime time, string todo)
        {
            InitializeComponent();
            tanggal.Text = time.DayOfWeek.ToString();
            what_to_do.Text = todo;
        }
    }
}
