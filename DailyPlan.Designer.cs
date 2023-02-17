namespace CalendarWinform
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTomorow = new System.Windows.Forms.Button();
            this.buttonYesterday = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.buttonTomorow);
            this.panel1.Controls.Add(this.buttonYesterday);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.flowLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(10, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 480);
            this.panel1.TabIndex = 0;
            // 
            // buttonTomorow
            // 
            this.buttonTomorow.Location = new System.Drawing.Point(820, 4);
            this.buttonTomorow.Name = "buttonTomorow";
            this.buttonTomorow.Size = new System.Drawing.Size(87, 27);
            this.buttonTomorow.TabIndex = 3;
            this.buttonTomorow.Text = "Ngày mai";
            this.buttonTomorow.UseVisualStyleBackColor = true;
            this.buttonTomorow.Click += new System.EventHandler(this.buttonTomorow_Click);
            // 
            // buttonYesterday
            // 
            this.buttonYesterday.Location = new System.Drawing.Point(12, 9);
            this.buttonYesterday.Name = "buttonYesterday";
            this.buttonYesterday.Size = new System.Drawing.Size(87, 27);
            this.buttonYesterday.TabIndex = 2;
            this.buttonYesterday.Text = "Hôm qua";
            this.buttonYesterday.UseVisualStyleBackColor = true;
            this.buttonYesterday.Click += new System.EventHandler(this.buttonYesterday_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 40);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(906, 432);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddJob,
            this.menuToday});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddJob
            // 
            this.menuAddJob.Name = "menuAddJob";
            this.menuAddJob.Size = new System.Drawing.Size(90, 24);
            this.menuAddJob.Text = "Thêm việc";
            this.menuAddJob.Click += new System.EventHandler(this.menuAddJob_Click);
            // 
            // menuToday
            // 
            this.menuToday.Name = "menuToday";
            this.menuToday.Size = new System.Drawing.Size(83, 24);
            this.menuToday.Text = "Hôm nay";
            this.menuToday.Click += new System.EventHandler(this.menuToday_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(943, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyPlan";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddJob;
        private System.Windows.Forms.ToolStripMenuItem menuToday;
        private System.Windows.Forms.Button buttonTomorow;
        private System.Windows.Forms.Button buttonYesterday;
    }
}