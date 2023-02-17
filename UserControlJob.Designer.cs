namespace CalendarWinform
{
    partial class UserControlJob
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
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.textBoxJobName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericFromMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericFromHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericToMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericToHours = new System.Windows.Forms.NumericUpDown();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromHours)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericToHours)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(19, 13);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDone.TabIndex = 0;
            this.checkBoxDone.UseVisualStyleBackColor = true;
            this.checkBoxDone.CheckedChanged += new System.EventHandler(this.checkBoxDone_CheckedChanged);
            // 
            // textBoxJobName
            // 
            this.textBoxJobName.Location = new System.Drawing.Point(54, 11);
            this.textBoxJobName.Name = "textBoxJobName";
            this.textBoxJobName.Size = new System.Drawing.Size(186, 22);
            this.textBoxJobName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericFromMinutes);
            this.panel1.Controls.Add(this.numericFromHours);
            this.panel1.Location = new System.Drawing.Point(278, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 33);
            this.panel1.TabIndex = 2;
            // 
            // numericFromMinutes
            // 
            this.numericFromMinutes.Location = new System.Drawing.Point(63, 6);
            this.numericFromMinutes.Name = "numericFromMinutes";
            this.numericFromMinutes.Size = new System.Drawing.Size(40, 22);
            this.numericFromMinutes.TabIndex = 1;
            // 
            // numericFromHours
            // 
            this.numericFromHours.Location = new System.Drawing.Point(12, 5);
            this.numericFromHours.Name = "numericFromHours";
            this.numericFromHours.Size = new System.Drawing.Size(40, 22);
            this.numericFromHours.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericToMinutes);
            this.panel2.Controls.Add(this.numericToHours);
            this.panel2.Location = new System.Drawing.Point(457, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 33);
            this.panel2.TabIndex = 3;
            // 
            // numericToMinutes
            // 
            this.numericToMinutes.Location = new System.Drawing.Point(63, 4);
            this.numericToMinutes.Name = "numericToMinutes";
            this.numericToMinutes.Size = new System.Drawing.Size(40, 22);
            this.numericToMinutes.TabIndex = 1;
            // 
            // numericToHours
            // 
            this.numericToHours.Location = new System.Drawing.Point(12, 5);
            this.numericToHours.Name = "numericToHours";
            this.numericToHours.Size = new System.Drawing.Size(45, 22);
            this.numericToHours.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "COMING",
            "DOING",
            "DONE",
            "MISSED"});
            this.comboBoxStatus.Location = new System.Drawing.Point(581, 10);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(710, 11);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(795, 11);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UserControlJob
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxJobName);
            this.Controls.Add(this.checkBoxDone);
            this.Name = "UserControlJob";
            this.Size = new System.Drawing.Size(883, 46);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericFromMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromHours)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericToMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericToHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.TextBox textBoxJobName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericFromMinutes;
        private System.Windows.Forms.NumericUpDown numericFromHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericToMinutes;
        private System.Windows.Forms.NumericUpDown numericToHours;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}
