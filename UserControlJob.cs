using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CalendarWinform
{
    public partial class UserControlJob : UserControl
    {
        private PlanItem job;

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public UserControlJob()
        {
            InitializeComponent();
        }
        public UserControlJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;
            showInfo(Job);
        }

        private void showInfo(PlanItem job)
        {
            textBoxJobName.Text = job.JobName;
            numericFromHours.Value = job.FromTime.X;
            numericFromMinutes.Value = job.FromTime.Y;
            numericToHours.Value = job.ToTime.X;
            numericToMinutes.Value = job.ToTime.Y;
            comboBoxStatus.DataSource = PlanItem.ListStatus;
            comboBoxStatus.SelectedItem = job.Status;
            if (comboBoxStatus.Text == "DONE")
                checkBoxDone.Checked = true;
            else checkBoxDone.Checked = false;
        }
        public PlanItem Job { get => job; set => job = value; }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedIndex >= 0)
            {
                if (comboBoxStatus.SelectedItem.ToString() == "DONE")
                {
                    this.BackColor = Color.LightGreen;
                    this.checkBoxDone.Checked = true;
                    lastStatusIsDone = true;
                }
                else if (comboBoxStatus.SelectedItem.ToString() == "DOING")
                {
                    this.BackColor = Color.Yellow;
                    //Phải set lastStatusIsDone nằm trên checkBoxDone.Checked = false vì việc thiết
                    //lập true/false cho checkbox sẽ thực hiện việc gọi event checkedChanged
                    lastStatusIsDone = false;
                    this.checkBoxDone.Checked = false;
                }
                else if (comboBoxStatus.SelectedItem.ToString() == "COMING")
                {  
                    this.BackColor = Color.LightCyan;
                    lastStatusIsDone = false;
                    this.checkBoxDone.Checked = false;
                }
                else
                {
                    this.BackColor = Color.Purple;
                    lastStatusIsDone = false;
                    this.checkBoxDone.Checked = false;
                }

            }
        }

        private bool lastStatusIsDone = false;
        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDone.Checked)
            {
                comboBoxStatus.SelectedItem = "DONE";
                lastStatusIsDone = true;
            }
            else if (lastStatusIsDone)
            {
                comboBoxStatus.SelectedItem = "DOING";
                lastStatusIsDone = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            job.JobName = textBoxJobName.Text;
            job.FromTime = new Point((int)numericFromHours.Value, (int)numericFromMinutes.Value);
            job.ToTime = new Point((int)numericToHours.Value, (int)numericToMinutes.Value);
            job.Status = comboBoxStatus.SelectedItem.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }
    }
}
