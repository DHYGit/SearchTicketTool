using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SearchTicketTool
{
    public partial class Form1 : Form
    {
        string GetAllTrainInfoUrl = "https://kyfw.12306.cn/otn/resources/js/query/train_list.js?scriptVersion=1.0";
        string GetAllStationUrl = "https://kyfw.12306.cn/otn/resources/js/framework/station_name.js";
        string SearchTicketUrl = "https://kyfw.12306.cn/otn/leftTicket/query";
        string key = "";
        string search_result = "";
        string[] interface_array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", 
                                       "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        Dictionary<string, string> StaionInfoDic = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            //获取所有车站名称
            string AllStationInfo = HttpGetFun(GetAllStationUrl);
            string[] stationArray = AllStationInfo.Split('@');
            for (int i = 1; i < stationArray.Length; i++) 
            {
                string station_name = stationArray[i].Split('|')[1];
                string station_enc = stationArray[i].Split('|')[2];
                this.comboBox_StartStation.Items.Add(station_name);
                this.comboBox_EndStation.Items.Add(station_name);
                this.StaionInfoDic.Add(station_name, station_enc);
            }
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
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
                    this.search_result = HttpGetFun(url);
                    Console.WriteLine(search_result);
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
                search_result = HttpGetFun(url);
                Console.WriteLine(search_result);
            }
        }

        string HttpGetFun(string url) 
        {
            string retString = "";
            try
            {
                //创建请求
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //GET请求
                request.Method = "GET";
                request.ReadWriteTimeout = 5000;
                request.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                //返回内容
                retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
            }
            catch (Exception ex){
                retString = ex.Message;
            }
            return retString;
        }
    }
}
