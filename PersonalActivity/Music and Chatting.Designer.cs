namespace PersonalActivity
{
    partial class Music_and_Chatting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_and_Chatting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.connect_btn = new System.Windows.Forms.Button();
            this.server_field = new System.Windows.Forms.TextBox();
            this.send_chat = new System.Windows.Forms.Button();
            this.chat_field = new System.Windows.Forms.TextBox();
            this.chat_box = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.music_time = new System.Windows.Forms.Label();
            this.music_title = new System.Windows.Forms.Label();
            this.stop_btn = new System.Windows.Forms.PictureBox();
            this.music_list = new System.Windows.Forms.ComboBox();
            this.toggleplay = new System.Windows.Forms.PictureBox();
            this.music_pic = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.PictureBox();
            this.previous_btn = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.waitNewMessage = new System.Windows.Forms.Timer(this.components);
            this.check_server = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_btn.BackgroundImage")));
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize_btn.Location = new System.Drawing.Point(910, 1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 26);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btn.BackgroundImage")));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_btn.Location = new System.Drawing.Point(945, 1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 26);
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(589, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 434);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.check_server);
            this.panel4.Controls.Add(this.connect_btn);
            this.panel4.Controls.Add(this.server_field);
            this.panel4.Controls.Add(this.send_chat);
            this.panel4.Controls.Add(this.chat_field);
            this.panel4.Controls.Add(this.chat_box);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 434);
            this.panel4.TabIndex = 0;
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.connect_btn.Location = new System.Drawing.Point(168, 4);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(65, 20);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // server_field
            // 
            this.server_field.Location = new System.Drawing.Point(6, 4);
            this.server_field.Name = "server_field";
            this.server_field.Size = new System.Drawing.Size(156, 20);
            this.server_field.TabIndex = 3;
            // 
            // send_chat
            // 
            this.send_chat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.send_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_chat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.send_chat.Location = new System.Drawing.Point(309, 385);
            this.send_chat.Name = "send_chat";
            this.send_chat.Size = new System.Drawing.Size(79, 26);
            this.send_chat.TabIndex = 2;
            this.send_chat.Text = "Send";
            this.send_chat.UseVisualStyleBackColor = false;
            this.send_chat.Click += new System.EventHandler(this.send_chat_Click);
            // 
            // chat_field
            // 
            this.chat_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_field.Location = new System.Drawing.Point(3, 385);
            this.chat_field.Name = "chat_field";
            this.chat_field.Size = new System.Drawing.Size(306, 26);
            this.chat_field.TabIndex = 1;
            // 
            // chat_box
            // 
            this.chat_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat_box.FormattingEnabled = true;
            this.chat_box.Location = new System.Drawing.Point(3, 32);
            this.chat_box.Name = "chat_box";
            this.chat_box.Size = new System.Drawing.Size(384, 351);
            this.chat_box.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.music_time);
            this.panel3.Controls.Add(this.music_title);
            this.panel3.Controls.Add(this.stop_btn);
            this.panel3.Controls.Add(this.music_list);
            this.panel3.Controls.Add(this.toggleplay);
            this.panel3.Controls.Add(this.music_pic);
            this.panel3.Controls.Add(this.next_btn);
            this.panel3.Controls.Add(this.previous_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 434);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(246, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // music_time
            // 
            this.music_time.AutoSize = true;
            this.music_time.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.music_time.Location = new System.Drawing.Point(270, 296);
            this.music_time.Name = "music_time";
            this.music_time.Size = new System.Drawing.Size(53, 18);
            this.music_time.TabIndex = 11;
            this.music_time.Text = "00:00";
            // 
            // music_title
            // 
            this.music_title.AutoSize = true;
            this.music_title.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.music_title.Location = new System.Drawing.Point(9, 410);
            this.music_title.Name = "music_title";
            this.music_title.Size = new System.Drawing.Size(96, 18);
            this.music_title.TabIndex = 10;
            this.music_title.Text = "Now Playing";
            // 
            // stop_btn
            // 
            this.stop_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop_btn.BackgroundImage")));
            this.stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stop_btn.Location = new System.Drawing.Point(345, 248);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(39, 36);
            this.stop_btn.TabIndex = 8;
            this.stop_btn.TabStop = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // music_list
            // 
            this.music_list.BackColor = System.Drawing.Color.Snow;
            this.music_list.DropDownHeight = 100;
            this.music_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music_list.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_list.FormattingEnabled = true;
            this.music_list.IntegralHeight = false;
            this.music_list.Location = new System.Drawing.Point(3, 6);
            this.music_list.Name = "music_list";
            this.music_list.Size = new System.Drawing.Size(580, 24);
            this.music_list.TabIndex = 0;
            this.music_list.SelectedIndexChanged += new System.EventHandler(this.music_list_SelectedIndexChanged);
            // 
            // toggleplay
            // 
            this.toggleplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleplay.BackgroundImage")));
            this.toggleplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleplay.Location = new System.Drawing.Point(255, 248);
            this.toggleplay.Name = "toggleplay";
            this.toggleplay.Size = new System.Drawing.Size(39, 36);
            this.toggleplay.TabIndex = 9;
            this.toggleplay.TabStop = false;
            this.toggleplay.Click += new System.EventHandler(this.toggleplay_Click);
            // 
            // music_pic
            // 
            this.music_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music_pic.BackgroundImage")));
            this.music_pic.Location = new System.Drawing.Point(249, 145);
            this.music_pic.Name = "music_pic";
            this.music_pic.Size = new System.Drawing.Size(99, 97);
            this.music_pic.TabIndex = 5;
            this.music_pic.TabStop = false;
            // 
            // next_btn
            // 
            this.next_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_btn.BackgroundImage")));
            this.next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.next_btn.Location = new System.Drawing.Point(300, 248);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(39, 36);
            this.next_btn.TabIndex = 7;
            this.next_btn.TabStop = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // previous_btn
            // 
            this.previous_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous_btn.BackgroundImage")));
            this.previous_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previous_btn.Location = new System.Drawing.Point(210, 248);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(39, 36);
            this.previous_btn.TabIndex = 6;
            this.previous_btn.TabStop = false;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // waitNewMessage
            // 
            this.waitNewMessage.Interval = 1000;
            this.waitNewMessage.Tick += new System.EventHandler(this.waitNewMessage_Tick);
            // 
            // check_server
            // 
            this.check_server.BackColor = System.Drawing.Color.DarkViolet;
            this.check_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_server.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check_server.Location = new System.Drawing.Point(247, 4);
            this.check_server.Name = "check_server";
            this.check_server.Size = new System.Drawing.Size(65, 20);
            this.check_server.TabIndex = 5;
            this.check_server.Text = "Check Server";
            this.check_server.UseVisualStyleBackColor = false;
            this.check_server.Click += new System.EventHandler(this.check_server_Click);
            // 
            // Music_and_Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Music_and_Chatting";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music_and_Chatting";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox chat_box;
        private System.Windows.Forms.TextBox chat_field;
        private System.Windows.Forms.Button send_chat;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox server_field;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox stop_btn;
        private System.Windows.Forms.ComboBox music_list;
        private System.Windows.Forms.PictureBox toggleplay;
        private System.Windows.Forms.PictureBox music_pic;
        private System.Windows.Forms.PictureBox next_btn;
        private System.Windows.Forms.PictureBox previous_btn;
        private System.Windows.Forms.Label music_time;
        private System.Windows.Forms.Label music_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer waitNewMessage;
        private System.Windows.Forms.Button check_server;
    }
}