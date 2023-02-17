using System;
using System.Collections.Generic;
using System.Drawing;

namespace CalendarWinform
{
    public class PlanItem
    {
        private DateTime jobTime;
        private string jobName;

        //Lưu tời gian bằng Point cho dễ xử lí
        private Point fromTime, toTime;

        //status: done,missed,doing,coming
        private string status;
        public string JobName { get => jobName; set => jobName = value; }
        public Point FromTime { get => fromTime; set => fromTime = value; }
        public Point ToTime { get => toTime; set => toTime = value; }
        public string Status { get => status; set => status = value; }
        public DateTime JobTime { get => jobTime; set => jobTime = value; }

        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };
    }

    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}
