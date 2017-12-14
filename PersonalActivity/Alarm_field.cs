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
    public partial class Alarm_field : UserControl
    {
        public Alarm_field(string time_field)
        {
            InitializeComponent();
            this.name.Text = time_field;
        }
    }
}
