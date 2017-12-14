using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pamusic;

namespace PersonalActivity
{
    public partial class Music_and_Chatting : Form
    {
        public Music_and_Chatting(PersonalActivityReferences.LibraryStorage.UserStorage user)
        {
            InitializeComponent();
            music_player = new Music();
            this.ONLINLE_USER = user;
            //this.waitNewMessage.Enabled = true;
            chat_client = new OrionChatClient.ChatClient(this.ONLINLE_USER);
            checkup_system = new PACheckUP.SystemCheckup();
            //panel5.BackColor = Color.FromArgb(200, Color.Black);
            //panel4.BackColor = Color.FromArgb(200, Color.LightCyan);
            
        }
        private string[] paths;
        private string[] files;
        bool istopPaneldrag = false;
        Point offset;
        public Music music_player;
        private OrionChatClient.ChatClient chat_client;
        private PersonalActivityReferences.LibraryStorage.UserStorage ONLINLE_USER;
        private PACheckUP.SystemCheckup checkup_system;
        int index_holder;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.files = openFileDialog1.SafeFileNames;
                this.paths = openFileDialog1.FileNames;
                for (int i = 0; i < this.files.Length; i++)
                {
                    this.music_list.Items.Add(files[i]);
                    music_player.setPLaylist(paths[i]);
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toggleplay_Click(object sender, EventArgs e)
        {
            if (music_player.isPlaying())
            {
                music_player.togglePLaying();
                toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Play-35 (1).png");
                this.music_title.Text = music_player.nowPlaying();
                this.music_time.Text = music_player.getTimes();
                this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD-100.png");
            }
            else if (music_player.isPaused())
            {
                music_player.togglePLaying();
                toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                this.music_title.Text = music_player.nowPlaying();
                this.music_time.Text = music_player.getTimes();
                this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
            }
            else if (music_player.isStoped())
            {
                try
                {
                    music_player.player(index_holder);
                    music_player.togglePLaying();
                    toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                    this.music_title.Text = music_player.nowPlaying();
                    this.music_time.Text = music_player.getTimes();
                    this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
                }
                catch
                {
                    MessageBox.Show("There's no Music to Play");
                }
            }
        }

        private void music_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index_holder = music_list.SelectedIndex;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            music_player.stop();
            toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Play-35 (1).png");
            this.music_title.Text = music_player.nowPlaying();
            this.music_time.Text = music_player.getTimes();
            this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD-100.png");
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (music_player.isPaused() || music_player.isStoped())
                {
                    music_list.SelectedIndex = index_holder + 1;
                    music_player.player(index_holder);
                    music_player.togglePLaying();
                    toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                    this.music_title.Text = music_player.nowPlaying();
                    this.music_time.Text = music_player.getTimes();
                    this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
                }
                else if (music_player.isPlaying())
                {
                    music_player.stop();
                    music_list.SelectedIndex = index_holder + 1;
                    music_player.player(index_holder);
                    music_player.togglePLaying();
                    toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                    this.music_title.Text = music_player.nowPlaying();
                    this.music_time.Text = music_player.getTimes();
                    this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
                }
            }
            catch
            {
                MessageBox.Show("This is the last music / There's no music to play");
            }
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (music_player.isPaused() || music_player.isStoped())
                {
                    music_list.SelectedIndex = index_holder - 1;
                    music_player.player(index_holder);
                    music_player.togglePLaying();
                    toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                    this.music_title.Text = music_player.nowPlaying();
                    this.music_time.Text = music_player.getTimes();
                    this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
                }
                else if (music_player.isPlaying())
                {
                    music_player.stop();
                    music_list.SelectedIndex = index_holder - 1;
                    music_player.player(index_holder);
                    music_player.togglePLaying();
                    toggleplay.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "Pause-35 (1).png");
                    this.music_title.Text = music_player.nowPlaying();
                    this.music_time.Text = music_player.getTimes();
                    this.music_pic.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Icon\\" + "CD1-100.png");
                }
            }
            catch
            {
                MessageBox.Show("This is the first Music / There's no music to play");
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                chat_client.CON_TO_SERVER(this.server_field.Text);
                MessageBox.Show("Connected");
                System.Threading.Thread th = new System.Threading.Thread(Getmsg);
                th.Start();
            }
            catch
            {
                MessageBox.Show("Server maybe down / your server address is wrong");
            }
            //waitNewMessage.Enabled = true;
        }

        public void disconnectFromservver()
        {
            this.chat_client = null;
            this.Close();
            this.Dispose();
        }

        private void Getmsg()
        {
            //this.Invoke((MethodInvoker)(() => this.chat_box.Items.Add(chat_client.getBuffData())));
            /*
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Getmsg));
            }
            else
            {
                this.chat_box.Items.Add(chat_client.getBuffData());
            }
             * */
            while (true)
            {
                fillMsg(chat_client.getBuffData());
            }
        }

        private void fillMsg(string a)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate() {
                    //this.chat_box.Items.Add(a);
                    fillMsg(a);
                }));
            }
            else
            {
                this.chat_box.Items.Add(a);
            }
        }

        private void waitNewMessage_Tick(object sender, EventArgs e)
        {
            
        }

        private void send_chat_Click(object sender, EventArgs e)
        {
            try
            {
                chat_client.sendMessage(this.chat_field.Text);
                chat_box.Items.Add("You : " + this.chat_field.Text);
                this.chat_field.Clear();
            }
            catch
            {
                MessageBox.Show("Server maybe down / your server address is wrong");
            }
        }

        private void check_server_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkup_system.ConnectionTest(this.server_field.Text))
                {
                    MessageBox.Show("Connection to the server is Up");
                }
                else
                {
                    throw new Exception("Connection is down, check again");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

    }
}
