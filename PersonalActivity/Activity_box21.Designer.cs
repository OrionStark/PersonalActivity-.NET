namespace PersonalActivity
{
    partial class Activity_box21
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tanggal = new System.Windows.Forms.Label();
            this.what_to_do = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tanggal.Location = new System.Drawing.Point(5, 3);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(52, 15);
            this.tanggal.TabIndex = 0;
            this.tanggal.Text = "tanggal";
            // 
            // what_to_do
            // 
            this.what_to_do.AutoSize = true;
            this.what_to_do.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.what_to_do.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.what_to_do.Location = new System.Drawing.Point(84, 25);
            this.what_to_do.Name = "what_to_do";
            this.what_to_do.Size = new System.Drawing.Size(117, 22);
            this.what_to_do.TabIndex = 1;
            this.what_to_do.Text = "What to do ";
            // 
            // Activity_box21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.what_to_do);
            this.Controls.Add(this.tanggal);
            this.Name = "Activity_box21";
            this.Size = new System.Drawing.Size(397, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label what_to_do;
    }
}
