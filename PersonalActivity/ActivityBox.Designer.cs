namespace PersonalActivity
{
    partial class ActivityBox
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
            this.activity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activity
            // 
            this.activity.AutoSize = true;
            this.activity.BackColor = System.Drawing.Color.Transparent;
            this.activity.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activity.Location = new System.Drawing.Point(16, 5);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(67, 26);
            this.activity.TabIndex = 0;
            this.activity.Text = "label1";
            // 
            // ActivityBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.activity);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ActivityBox";
            this.Size = new System.Drawing.Size(332, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activity;
    }
}
