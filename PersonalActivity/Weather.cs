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
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
            weath = new weather.Weather();
        }
        bool istopPaneldrag = false;
        Point offset;
        weather.Weather weath;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.istopPaneldrag = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            try
            {
                weath.getCurentInfo(city_field.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Can't find this city");
            }
            city_name.Text = weath.getCity();
            condition.Text = weath.getCondition();
            wind_spd.Text = weath.getwindSpeed();
            wind_type.Text = weath.getWindType();
            temperature.Text = weath.getTemperature();
            wind_direction.Text = weath.getCondition();
        }
    }
}
