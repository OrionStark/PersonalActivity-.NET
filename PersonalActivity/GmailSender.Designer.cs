namespace PersonalActivity
{
    partial class GmailSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GmailSender));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnmz_btn = new System.Windows.Forms.PictureBox();
            this.cls_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.TextBox();
            this.send_box = new System.Windows.Forms.Button();
            this.msg_box = new System.Windows.Forms.Label();
            this.subject_box = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bodymessage = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sender_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnmz_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_btn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnmz_btn);
            this.panel1.Controls.Add(this.cls_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // mnmz_btn
            // 
            this.mnmz_btn.BackColor = System.Drawing.Color.Transparent;
            this.mnmz_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnmz_btn.BackgroundImage")));
            this.mnmz_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnmz_btn.Location = new System.Drawing.Point(834, 1);
            this.mnmz_btn.Name = "mnmz_btn";
            this.mnmz_btn.Size = new System.Drawing.Size(32, 31);
            this.mnmz_btn.TabIndex = 12;
            this.mnmz_btn.TabStop = false;
            this.mnmz_btn.Click += new System.EventHandler(this.mnmz_btn_Click);
            // 
            // cls_btn
            // 
            this.cls_btn.BackColor = System.Drawing.Color.Transparent;
            this.cls_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cls_btn.BackgroundImage")));
            this.cls_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cls_btn.Location = new System.Drawing.Point(870, 1);
            this.cls_btn.Name = "cls_btn";
            this.cls_btn.Size = new System.Drawing.Size(32, 31);
            this.cls_btn.TabIndex = 11;
            this.cls_btn.TabStop = false;
            this.cls_btn.Click += new System.EventHandler(this.cls_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.target);
            this.panel2.Controls.Add(this.send_box);
            this.panel2.Controls.Add(this.msg_box);
            this.panel2.Controls.Add(this.subject_box);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bodymessage);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.sender_box);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 433);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(401, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // target
            // 
            this.target.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target.Location = new System.Drawing.Point(404, 221);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(283, 29);
            this.target.TabIndex = 11;
            // 
            // send_box
            // 
            this.send_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send_box.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_box.Location = new System.Drawing.Point(223, 383);
            this.send_box.Name = "send_box";
            this.send_box.Size = new System.Drawing.Size(464, 35);
            this.send_box.TabIndex = 10;
            this.send_box.Text = "Send";
            this.send_box.UseVisualStyleBackColor = true;
            this.send_box.Click += new System.EventHandler(this.send_box_Click);
            // 
            // msg_box
            // 
            this.msg_box.AutoSize = true;
            this.msg_box.BackColor = System.Drawing.Color.Transparent;
            this.msg_box.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msg_box.Location = new System.Drawing.Point(220, 262);
            this.msg_box.Name = "msg_box";
            this.msg_box.Size = new System.Drawing.Size(78, 16);
            this.msg_box.TabIndex = 9;
            this.msg_box.Text = "Message";
            // 
            // subject_box
            // 
            this.subject_box.AutoSize = true;
            this.subject_box.BackColor = System.Drawing.Color.Transparent;
            this.subject_box.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subject_box.Location = new System.Drawing.Point(219, 204);
            this.subject_box.Name = "subject_box";
            this.subject_box.Size = new System.Drawing.Size(78, 16);
            this.subject_box.TabIndex = 8;
            this.subject_box.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(219, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(398, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 77);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bodymessage
            // 
            this.bodymessage.Location = new System.Drawing.Point(222, 281);
            this.bodymessage.Name = "bodymessage";
            this.bodymessage.Size = new System.Drawing.Size(465, 99);
            this.bodymessage.TabIndex = 4;
            this.bodymessage.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(222, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 29);
            this.textBox2.TabIndex = 3;
            // 
            // sender_box
            // 
            this.sender_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender_box.Location = new System.Drawing.Point(222, 167);
            this.sender_box.Name = "sender_box";
            this.sender_box.Size = new System.Drawing.Size(176, 29);
            this.sender_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(324, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gmail Sender";
            // 
            // GmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GmailSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GmailSender";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mnmz_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox bodymessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox sender_box;
        private System.Windows.Forms.Label subject_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msg_box;
        private System.Windows.Forms.Button send_box;
        private System.Windows.Forms.PictureBox mnmz_btn;
        private System.Windows.Forms.PictureBox cls_btn;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label2;
    }
}