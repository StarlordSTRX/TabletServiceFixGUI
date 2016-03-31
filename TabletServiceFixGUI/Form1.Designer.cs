namespace TabletServiceFixGUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StatusColon = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.lbl_settings = new System.Windows.Forms.LinkLabel();
            this.credits = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // StatusColon
            // 
            this.StatusColon.AutoSize = true;
            this.StatusColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusColon.Location = new System.Drawing.Point(8, 13);
            this.StatusColon.Name = "StatusColon";
            this.StatusColon.Size = new System.Drawing.Size(76, 20);
            this.StatusColon.TabIndex = 0;
            this.StatusColon.Text = "STATUS:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Gray;
            this.status.Location = new System.Drawing.Point(79, 6);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(66, 30);
            this.status.TabIndex = 1;
            this.status.Text = "IDLE";
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(13, 86);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(201, 25);
            this.restart.TabIndex = 2;
            this.restart.Text = "Restart Tablet Service";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Service to restart:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 4;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 2000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Location = new System.Drawing.Point(12, 118);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(45, 13);
            this.lbl_settings.TabIndex = 5;
            this.lbl_settings.TabStop = true;
            this.lbl_settings.Text = "Settings";
            this.lbl_settings.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_settings_LinkClicked);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(179, 118);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(35, 13);
            this.credits.TabIndex = 6;
            this.credits.TabStop = true;
            this.credits.Text = "About";
            this.credits.VisitedLinkColor = System.Drawing.Color.Blue;
            this.credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credits_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 139);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.status);
            this.Controls.Add(this.StatusColon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablet Service Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusColon;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.LinkLabel lbl_settings;
        private System.Windows.Forms.LinkLabel credits;
    }
}

