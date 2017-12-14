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
    public partial class Splash : Form
    {
        //FirstPage firstPage;
        PACheckUP.SystemCheckup checkupSystem;
        public Splash()
        {
            checkupSystem = new PACheckUP.SystemCheckup();
            InitializeComponent();
            //firstPage = new FirstPage();
        }
        private void Splash_Load(object sender, EventArgs e)
        {            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool networkCheck = false;
            bool FileCheck = false;
            this.statusprogress.Increment(1);
            if (this.statusprogress.Value == 20)
            {
                timer1.Stop();
                checkupSystem.ConnectionTest();
                checkNav.Text = "Checking internet Connection";
                if (checkupSystem.ConnectionTest())
                {
                    timer1.Start();
                    checkNav.Text = "Internet status is OK";
                    networkCheck = true;
                    checkupSystem.createLog(DateTime.Now, "Internet Check System", "Success");
                    checkupSystem.packAll();
                }
                else
                {
                    MessageBox.Show("You didn't have any Internet connection");
                    timer1.Start();
                    checkNav.Text = "Internet status is Bad";
                    networkCheck = false;
                    checkupSystem.createLog(DateTime.Now, "Internet Check System", "Fail");
                    checkupSystem.packAll();
                }
            }
            if (this.statusprogress.Value == 60)
            {
                timer1.Stop();
                checkNav.Text = "Checking some depedency files";
                if (checkupSystem.checkExistingFile())
                {
                    timer1.Start();
                    FileCheck = true;
                    checkupSystem.createLog(DateTime.Now, "File Checking System", "Success");
                    checkupSystem.packAll();
                }
                else
                {
                    MessageBox.Show("Some files is doesn't exists, you may can't do something");
                    timer1.Start();
                    FileCheck = false;
                    checkupSystem.createLog(DateTime.Now, "File Checking System", "Fail");
                    checkupSystem.packAll();
                }
            }
            if (this.statusprogress.Value == 100)
            {
                timer1.Stop();
                //firstPage.Show();
                this.Close();
            }
        }
        public void CloseThisApps()
        {
            this.Dispose();
        }
    }
}
