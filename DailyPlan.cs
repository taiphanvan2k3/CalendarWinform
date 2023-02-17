using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalendarWinform
{
    public partial class DailyPlan : Form
    {
        private PlanData data;
        private DateTime date;
        public DailyPlan(DateTime date, PlanData data)
        {
            InitializeComponent();
            dateTimePicker1.Value = date;
            this.Data = data;
            this.Date = date;
            ShowJobByDate(Date);
        }

        public DateTime Date { get => date; set => date = value; }
        public PlanData Data { get => data; set => data = value; }

        private void menuAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { JobTime = dateTimePicker1.Value };
            data.Items.Add(item);
            AddJob(item);
        }

        private List<PlanItem> GetJobByDate(DateTime date)
        {
            return data.Items.Where(item => item.JobTime.Year == date.Year
                                    && item.JobTime.Month == date.Month
                                    && item.JobTime.Day == date.Day).ToList();
        }
        private void ShowJobByDate(DateTime date)
        {
            if (Data != null && Data.Items != null)
            {
                List<PlanItem> ds = GetJobByDate(date);
                foreach (PlanItem item in ds)
                {
                    AddJob(item);
                }
            }
        }

        private void AddJob(PlanItem item)
        {
            UserControlJob job = new UserControlJob(item);
            //Cho event Deleted trỏ đến phương thức Job_Deleted
            job.Deleted += Job_Deleted;
            flowLayoutPanel.Controls.Add(job);
        }

        private void Job_Deleted(object sender, EventArgs e)
        {
            //Khi click vào button Deleted trên UserControl thì sẽ kiểm tra điều kiện
            //event có khác null hay không, nếu khác thì event sẽ gọi đến phương thức mà nó
            //trỏ đến, trong trường hợp này thì phương thức mà nó trỏ đến là Job_Deleted ở lớp DailyPlan
            UserControlJob src = sender as UserControlJob;
            PlanItem job = src.Job;

            flowLayoutPanel.Controls.Remove(src);

            //Xoá job trong PlanData
            data.Items.Remove(job);
        }

        private void buttonYesterday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void buttonTomorow_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void menuToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
