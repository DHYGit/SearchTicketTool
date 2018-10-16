using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchTicket.Model
{
    class PicCode
    {
        public string validateMessagesShowId { get; set; }
        public bool status { get; set; }

        public Data data { get; set; }

        public string[] messages { get; set; }

        public object validateMessages { get; set; }
    }
    public class Data
    {
        public string result { get; set; }
        public string msg { get; set; }

        public string otherMsg { get; set; }

        public string loginCheck { get; set; }
    }
    public class My12306 {
        public string NoCompleteOrderUrl;//未完成订单
        public string CompletedOrderUrl;//已完成订单
        public string MyInsuranceUrl;//我的保险
        public string ShowUserInfoUrl;//查看个人信息
        public string UserSecurityUrl;//账户安全
        public string sjhyUrl;//手机核验
        public string PassengersUrl;//常用联系人
        public string AddressUrl;//车票快递地址

        public string qxyyUrl;//重点旅客预约
        public string LostitemsUrl;//遗失物品查找
        public string ServiceQuery;//温馨服务查询
        

        public string login_user;//用户名

        public string login_outUrl;//退出

        public string LeftTicketUrl;//车票预订

        public string LcQueryUrl;//接续换乘
        public string tlcxUrl;//铁路畅行
        public string excaterUrl;//餐饮特产

        public string TrainInfoUrl;//车次查询
        public string TicketPriceUrl;//票价查询

        public string PublicPrice;//公布票价查询
        public string czxxUrl;//车站车次查询
        public string zzzcxUrl;//中转查询
        public string zwdchUrl;//正晚点查询
        public string AgencySellTicketUrl;//代售点查询
        public string HelpInfoUrl;//信息服务

        public string TimeInfo;//时间信息
    }
}
