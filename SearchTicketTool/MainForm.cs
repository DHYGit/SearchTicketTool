using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using SearchTicketTool.ProTool;
using Newtonsoft.Json;
using SearchTicket.Model;

namespace SearchTicketTool
{
    public partial class MainForm : Form
    {
        string GetCaptchaUrl = "https://kyfw.12306.cn/passport/captcha/captcha-image?login_site=E&module=login&rand=sjrand";//获取验证码接口
        string GetAllTrainInfoUrl = "https://kyfw.12306.cn/otn/resources/js/query/train_list.js?scriptVersion=1.0";//所有的车次信息
        string GetAllStationUrl = "https://kyfw.12306.cn/otn/resources/js/framework/station_name.js";//所有站信息
        string SearchTicketUrl = "https://kyfw.12306.cn/otn/leftTicket/query";//查询车票
        string key = "";
        string search_result = "";
        string[] interface_array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", 
                                       "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        Dictionary<string, string> StaionInfoDic = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
            this.tableLayoutPanel_Result.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel_Result, true, null);
            this.httpTool = new HttpDataResponseTool();
            
            //获取所有车站名称
            string AllStationInfo = this.httpTool.HttpGetFun(GetAllStationUrl);  
            string[] stationArray = AllStationInfo.Split('@');
            for (int i = 1; i < stationArray.Length; i++) 
            {
                string station_name = stationArray[i].Split('|')[1];
                string station_enc = stationArray[i].Split('|')[2];
                this.comboBox_StartStation.Items.Add(station_name);
                this.comboBox_EndStation.Items.Add(station_name);
                this.StaionInfoDic.Add(station_name, station_enc);
            }
            this.my12306 = new My12306();
            this.ListenTask = new Task(ListenFun);
            this.ListenTask.Start();
            //Task task = new Task(GetAllTrainInfoFun);
            //task.Start();
        }
        private void ListenFun() 
        {
            while (true) {
                if (this.login_status == false && this.button_Login.Text == "退出") {
                    if (this.button_Login.InvokeRequired) {
                        this.button_Login.BeginInvoke(new EventHandler(delegate {
                            this.button_Login.Text = "登录";
                        }));
                    }
                }
                if (this.login_status == true && this.button_Login.Text == "登录")
                {
                    if (this.button_Login.InvokeRequired)
                    {
                        this.button_Login.BeginInvoke(new EventHandler(delegate
                        {
                            this.button_Login.Text = "退出";
                        }));
                    }
                }
                Thread.Sleep(1000);
            }
        }
        private void GetAllTrainInfoFun() {
            string AllTrainInfo = this.httpTool.HttpGetFun(GetAllTrainInfoUrl);
            
            Console.WriteLine(AllTrainInfo);
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (this.login_status == false) {
                MessageBox.Show("请先登录");
                return;
            }
            if (this.comboBox_StartStation.SelectedIndex == -1) {
                MessageBox.Show("请选择始发站");
                return;
            }
            if (this.comboBox_EndStation.SelectedIndex == -1)
            {
                MessageBox.Show("请选择终点站");
                return;
            }
            string start_enc = this.StaionInfoDic[this.comboBox_StartStation.SelectedItem.ToString()];
            string end_enc = this.StaionInfoDic[this.comboBox_EndStation.SelectedItem.ToString()];
            string date = this.dateTimePicker_Date.Text;
            if (key == "")
            {
                for (int i = 0; i < interface_array.Length; i++)
                {
                    string url = "";
                    Console.WriteLine(interface_array[i]);
                    url += SearchTicketUrl + interface_array[i] + "?leftTicketDTO.train_date=" + date;
                    url += "&leftTicketDTO.from_station=" + start_enc;
                    url += "&leftTicketDTO.to_station=" + end_enc;
                    url += "&purpose_codes=ADULT";
                    Console.WriteLine(url);
                    this.search_result = this.httpTool.HttpGetFun(url);
                    //Console.WriteLine(search_result);
                    if (search_result.Contains("data"))
                    {
                        key = interface_array[i];
                        break;
                    }
                }
            }
            else {
                string url = "";
                url += SearchTicketUrl + key + "?leftTicketDTO.train_date=" + date;
                url += "&leftTicketDTO.from_station=" + start_enc;
                url += "&leftTicketDTO.to_station=" + end_enc;
                url += "&purpose_codes=ADULT";
                Console.WriteLine(url);
                search_result = this.httpTool.HttpGetFun(url);
                Console.WriteLine(search_result);
            }
            if (this.search_result.Contains("data"))
            {
                List<TrainInfo> TrainInfoList = this.AnalysisSearchResult(this.search_result);
                foreach(TrainInfo train_info in TrainInfoList)
                {
                    //动态增加一行
                    this.tableLayoutPanel_Result.RowCount++;
                    this.tableLayoutPanel_Result.Height = this.tableLayoutPanel_Result.RowCount * 40;
                    this.tableLayoutPanel_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
                    this.tableLayoutPanel_Result.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    //车次
                    Label label_TrainNum = new Label();
                    label_TrainNum.Text = train_info.train_num;
                    label_TrainNum.AutoSize = true;
                    label_TrainNum.Size = this.label_TrainNum.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_TrainNum, 0, this.tableLayoutPanel_Result.RowCount - 1);

                    //发站
                    Label label_StartStation = new Label();
                    label_StartStation.Text = train_info.start_station + "\n" + train_info.start_time;
                    label_StartStation.AutoSize = true;
                    label_StartStation.Size = this.label_SourceStation.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_StartStation, 1, this.tableLayoutPanel_Result.RowCount - 1);
                    //到站
                    Label label_DstStation = new Label();
                    label_DstStation.Text = train_info.dst_station + "\n" + train_info.dst_time;
                    label_DstStation.AutoSize = true;
                    label_DstStation.Size = this.label_DstStation.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_DstStation, 2, this.tableLayoutPanel_Result.RowCount - 1);
                    //历时
                    Label label_SpendTime = new Label();
                    label_SpendTime.Text = train_info.spend_time;
                    label_SpendTime.AutoSize = true;
                    label_SpendTime.Size = this.label_SpendTime.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_SpendTime, 3, this.tableLayoutPanel_Result.RowCount - 1);
                    //商务座特等座
                    Label label_BusinessClass = new Label();
                    label_BusinessClass.Text = train_info.business_class;
                    label_BusinessClass.AutoSize = true;
                    label_BusinessClass.Size = this.label_BusinessClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_BusinessClass, 4, this.tableLayoutPanel_Result.RowCount - 1);
                    //一等座
                    Label label_FirstClass = new Label();
                    label_FirstClass.Text = train_info.first_class;
                    label_FirstClass.AutoSize = true;
                    label_FirstClass.Size = this.label_FirstClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_FirstClass, 5, this.tableLayoutPanel_Result.RowCount - 1);
                    //二等座
                    Label label_SecondClass = new Label();
                    label_SecondClass.Text = train_info.second_class;
                    label_SecondClass.AutoSize = true;
                    label_SecondClass.Size = this.label_SecondClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_SecondClass, 6, this.tableLayoutPanel_Result.RowCount - 1);
                    //高级软座
                    Label label_AdvancedSoftSleeper = new Label();
                    label_AdvancedSoftSleeper.Text = train_info.advanced_soft_sleeper;
                    label_AdvancedSoftSleeper.AutoSize = true;
                    label_AdvancedSoftSleeper.Size = this.label_AdvancedSoftSleeper.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_AdvancedSoftSleeper, 7, this.tableLayoutPanel_Result.RowCount - 1);
                    //软卧
                    Label label_SoftSleeper = new Label();
                    label_SoftSleeper.Text = train_info.soft_sleeper;
                    label_SoftSleeper.AutoSize = true;
                    label_SoftSleeper.Size = this.label_SoftSleeper.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_SoftSleeper, 8, this.tableLayoutPanel_Result.RowCount - 1);
                    //动卧
                    Label label_StillSleeper = new Label();
                    label_StillSleeper.Text = train_info.still_sleeper;
                    label_StillSleeper.AutoSize = true;
                    label_StillSleeper.Size = this.label_StillSleeper.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_StillSleeper, 9, this.tableLayoutPanel_Result.RowCount - 1);
                    //硬卧
                    Label label_HardSleeper = new Label();
                    label_HardSleeper.Text = train_info.hard_sleeper;
                    label_HardSleeper.AutoSize = true;
                    label_HardSleeper.Size = this.label_HardSleeper.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_HardSleeper, 10, this.tableLayoutPanel_Result.RowCount - 1);
                    //软座
                    Label label_SoftClass = new Label();
                    label_SoftClass.Text = train_info.soft_class;
                    label_SoftClass.AutoSize = true;
                    label_SoftClass.Size = this.label_SoftClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_SoftClass, 11, this.tableLayoutPanel_Result.RowCount - 1);
                    //硬座
                    Label label_HardClass = new Label();
                    label_HardClass.Text = train_info.hard_class;
                    label_HardClass.AutoSize = true;
                    label_HardClass.Size = this.label_HardClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_HardClass, 12, this.tableLayoutPanel_Result.RowCount - 1);
                    //无座
                    Label label_NoClass = new Label();
                    label_NoClass.Text = train_info.hard_class;
                    label_NoClass.AutoSize = true;
                    label_NoClass.Size = this.label_NoClass.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_NoClass, 13, this.tableLayoutPanel_Result.RowCount - 1);
                    //其他
                    Label label_Else = new Label();
                    label_Else.Text = train_info.others;
                    label_Else.AutoSize = true;
                    label_Else.Size = this.label_Else.Size;
                    this.tableLayoutPanel_Result.Controls.Add(label_Else, 14, this.tableLayoutPanel_Result.RowCount - 1);
                    //购票
                    Button button = new Button();
                    button.Text = "预订";
                    button.BackColor = Color.Blue;
                    button.Size = this.label_Remark.Size;
                    button.AutoSize = true;
                    this.tableLayoutPanel_Result.Controls.Add(button, 15, this.tableLayoutPanel_Result.RowCount - 1);
                }
            }
            else {
                MessageBox.Show("没有查到结果");
            }
        }

        private List<TrainInfo> AnalysisSearchResult(string result) {
            List<TrainInfo> TrainInfoList = new List<TrainInfo>();
            SearchResult search_result = JsonConvert.DeserializeObject<SearchResult>(result);
            if (search_result != null) 
            {
                for (int i = 0; i < search_result.data.result.Length; i++)
                {
                    TrainInfo train_info = new TrainInfo();
                    train_info.train_num = search_result.data.result[i].Split('|')[3];
                    string start_enc = search_result.data.result[i].Split('|')[6];//始发站
                    string dst_enc = search_result.data.result[i].Split('|')[7];//到站
                    foreach(string key in this.StaionInfoDic.Keys)
                    {
                        if (this.StaionInfoDic[key] == start_enc) {
                            train_info.start_station = key;
                        }
                        if (this.StaionInfoDic[key] == dst_enc) {
                            train_info.dst_station = key;
                        }
                    }
                    train_info.start_time = search_result.data.result[i].Split('|')[8];//起始时间
                    train_info.dst_time = search_result.data.result[i].Split('|')[9];//到站时间
                    train_info.spend_time = search_result.data.result[i].Split('|')[10];//历时
                    string status = search_result.data.result[i].Split('|')[11];
                    if (status == "N")
                    {
                        train_info.status = false;
                    }
                    else if(status == "Y")
                    {
                        train_info.status = true;
                    }
                    train_info.date = search_result.data.result[i].Split('|')[13];//日期
                    train_info.advanced_soft_sleeper = search_result.data.result[i].Split('|')[21];//高级软卧
                    train_info.soft_class = search_result.data.result[i].Split('|')[24];//软座
                    train_info.still_sleeper = search_result.data.result[i].Split('|')[33];//动卧
                    train_info.business_class = search_result.data.result[i].Split('|')[32];//商务座
                    train_info.first_class = search_result.data.result[i].Split('|')[31];//一等座
                    train_info.second_class = search_result.data.result[i].Split('|')[30];//二等座
                    train_info.soft_sleeper = search_result.data.result[i].Split('|')[23];//软卧
                    train_info.no_class = search_result.data.result[i].Split('|')[26];//无座
                    train_info.hard_sleeper = search_result.data.result[i].Split('|')[28];//硬卧
                    train_info.hard_class = search_result.data.result[i].Split('|')[29];//硬座
                    TrainInfoList.Add(train_info);
                    Console.WriteLine("车次"+train_info.train_num + "发站:" + train_info.start_station + "到站:" + train_info.dst_station);
                }
            }
            return TrainInfoList;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (this.button_Login.Text == "登录")
            {
                Login login = new Login();
                login.main_form = this;
                this.IsEnableForm(false);
                login.Show();
            }
            else {
                this.label_LogInfo.Text = "";
                this.login_status = false;
            }
        }

        public void IsEnableForm(bool flag)
        {
            if (flag == false)
            {//disable
                this.button_Login.Enabled = false;
                this.button_Search.Enabled = false;
                this.dateTimePicker_Date.Enabled = false;
                this.comboBox_StartStation.Enabled = false;
                this.comboBox_EndStation.Enabled = false;
                this.panel_Result.Enabled = false;
            }
            else {
                this.button_Login.Enabled = true;
                this.button_Search.Enabled = true;
                this.dateTimePicker_Date.Enabled = true;
                this.comboBox_StartStation.Enabled = true;
                this.comboBox_EndStation.Enabled = true;
                this.panel_Result.Enabled = true;
            }
        }
        
    }
}
