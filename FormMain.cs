using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CalendarWinform
{
    public partial class FormMain : Form
    {
        //Chứa danh sách các sự kiện cho từng ngày
        private PlanData planData;
        private Button[,] matrix;

        //Khi tạo file thì nó sẽ tạo ra file trong thư mục bin\debug
        private string filePath = "data.xml";
        public FormMain()
        {
            InitializeComponent();
            LoadMatrixButton();
            try
            {
                planData = DeserializeFromXML(filePath) as PlanData;
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                SetDefaultData();
            }

        }

        private void SetDefaultData()
        {
            //Mặc định thôi
            planData = new PlanData();
            planData.Items = new List<PlanItem>();

            planData.Items.Add(new PlanItem()
            {
                JobTime = DateTime.Now,
                JobName = "Test",
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });

            planData.Items.Add(new PlanItem()
            {
                JobTime = DateTime.Now,
                JobName = "Test thử nè",
                FromTime = new Point(8, 0),
                ToTime = new Point(9, 0),
                Status = PlanItem.ListStatus[(int)EPlanItem.DONE]
            });
        }
        private void LoadMatrixButton()
        {
            matrix = new Button[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = new Button();
                    matrix[i, j].Click += button_Click;
                    matrix[i, j].Size = new Size(90, panelDate.Height / 6 - 5);
                    matrix[i, j].FlatStyle = FlatStyle.Flat;
                    matrix[i, j].FlatAppearance.BorderSize = 0;
                    matrix[i, j].TextAlign = ContentAlignment.TopRight;
                    matrix[i, j].BackColor = Color.White;
                    panelDate.Controls.Add(matrix[i, j]);
                }
            }
            addNumberToMatrixByDate(dateTimePicker1.Value);
        }

        private int GetDayOfMonth(int month, int year)
        {
            int[] days = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                days[2] = 29;
            return days[month];
        }

        private int GetIndexOfDayOfWeek(DayOfWeek d)
        {
            if (d == DayOfWeek.Monday)
                return 0;
            if (d == DayOfWeek.Tuesday)
                return 1;
            if (d == DayOfWeek.Wednesday)
                return 2;
            if (d == DayOfWeek.Thursday)
                return 3;
            if (d == DayOfWeek.Friday)
                return 4;
            if (d == DayOfWeek.Saturday)
                return 5;
            return 6;
        }
        private void addNumberToMatrixByDate(DateTime d)
        {
            //Lấy ra ngày đầu tiên của tháng để bắt đầu điền các ngày còn lại trong tháng
            DateTime firstDayOfMonth = new DateTime(d.Year, d.Month, 1);
            int maxDayInMonth = GetDayOfMonth(d.Month, d.Year);

            int previousMonth = d.Month - 1;
            int maxDayInPreviousMonth = 30;
            if (previousMonth >= 1)
                maxDayInPreviousMonth = GetDayOfMonth(previousMonth, d.Year);
            else
            {
                previousMonth = 12;
                maxDayInPreviousMonth = GetDayOfMonth(previousMonth, d.Year - 1);
            }

            int j = GetIndexOfDayOfWeek(firstDayOfMonth.DayOfWeek);
            int temp = j - 1;
            while (temp >= 0)
            {
                matrix[0, temp].Text = maxDayInPreviousMonth + "";
                matrix[0, temp].BackColor = Color.White;
                matrix[0, temp].ForeColor = Color.Gray;
                maxDayInPreviousMonth--;
                temp--;
            }
            int i = 0;
            int currDay = 1;
            for (; currDay <= maxDayInMonth; currDay++)
            {
                if (j <= 6)
                {
                    matrix[i, j].Text = currDay + "";
                    matrix[i, j].BackColor = Color.Gray;
                    matrix[i, j].ForeColor = Color.White;
                    if (currDay == DateTime.Now.Day && d.Month == DateTime.Now.Month && d.Year == DateTime.Now.Year)
                    {
                        matrix[i, j].BackColor = Color.Cyan;
                    }

                    DateTime selectedDate = dateTimePicker1.Value;
                    if (currDay == selectedDate.Day)
                    {
                        matrix[i, j].BackColor = Color.GreenYellow;
                    }
                }
                j++;
                if (j > 6)
                {
                    i++;
                    j = 0;
                }
            }

            currDay = 1;
            while (i < 6 && j <= 6)
            {
                matrix[i, j].Text = currDay + "";
                matrix[i, j].ForeColor = Color.Gray;
                matrix[i, j].BackColor = Color.White;
                currDay++;
                j++;
                if (j == 7)
                {
                    j = 0;
                    i++;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            addNumberToMatrixByDate(dateTimePicker1.Value);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.White)
                return;
            int day = Convert.ToInt32((sender as Button).Text);
            DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, day);
            DailyPlan dailyPlan = new DailyPlan(date, planData);
            dailyPlan.ShowDialog();
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xsr = new XmlSerializer(typeof(PlanData));
                object res = xsr.Deserialize(fs);
                fs.Close();
                return res;
            }
            catch (Exception)
            {
                //try catch để khi Deserialize mà vô tình quăng ra lỗi thì vẫn đóng file lại được
                fs.Close();
                throw new Exception();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(planData, filePath);
        }

        private int notifyTime = 1;
        private int AppTime = 0;
        private void timerNotify_Tick(object sender, EventArgs e)
        {
            AppTime++;
            if (AppTime < notifyTime)
                return;
            if (planData == null || planData.Items == null)
                return;
            int n = planData.Items.Count(i => MyHelper.compareDateTime(i.JobTime, DateTime.Now));
            notify.ShowBalloonTip(5000, "Lịch công việc ", "Hôm nay có " + n + " công việc", ToolTipIcon.Info);
            AppTime = 0;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            notifyTime = (int)numericUpDown.Value;
        }

        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            timerNotify.Enabled = checkBoxNotify.Checked;
            if (!checkBoxNotify.Checked)
                numericUpDown.Enabled = false;
            else
            { 
                numericUpDown.Enabled = true;
            }
            
        }
    }
}
