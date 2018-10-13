using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTicketTool.ProTool
{
    public class TrainInfo
    {
        public string train_num;//车次
        public string start_station;//发站
        public string dst_station;//到站
        public string start_time;//发站时间
        public string dst_time;//到站时间
        public string spend_time;//历时
        public string business_class;//商务座
        public string first_class;//一等座
        public string second_class;//二等座
        public string advanced_soft_sleeper;//高级软卧
        public string soft_sleeper;//软卧
        public string still_sleeper;//动卧
        public string hard_sleeper;//硬卧
        public string soft_class;//软座
        public string hard_class;//硬座
        public string no_class;//无座
        public string others;//其他
        public bool status;//是否可预订
        public string date;//出发日期
    }
    
}
