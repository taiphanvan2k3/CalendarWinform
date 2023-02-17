using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarWinform
{
    //Lưu đối tượng xuống file xml nên cần có Serializable
    [Serializable]
    public class PlanData
    {
        private bool isNotify;
        private int timeForNotify;

        //Class này lưu tất cả sự kiện của tất cả các ngày bằng
        //1 List các PlanItem
        private List<PlanItem> items;

        public List<PlanItem> Items { get => items; set => items = value; }
        public bool IsNotify { get => isNotify; set => isNotify = value; }
        public int TimeForNotify { get => timeForNotify; set => timeForNotify = value; }
    }
}
