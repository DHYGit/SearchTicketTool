﻿using System;
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

namespace SearchTicketTool
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
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
            //Task task = new Task(GetAllTrainInfoFun);
            //task.Start();
        }
        private void GetAllTrainInfoFun() {
            string AllTrainInfo = this.httpTool.HttpGetFun(GetAllTrainInfoUrl);
            
            Console.WriteLine(AllTrainInfo);
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
            }
            else {
                MessageBox.Show("没有查到结果");
            }
        }

        private List<TrainInfo> AnalysisSearchResult(string result) {
            List<TrainInfo> TrainInfoList = new List<TrainInfo>();
            SearchResult search_result = JavaScriptConvert.DeserializeObject<SearchResult>(result);
            if (search_result != null) 
            {
                for (int i = 0; i < search_result.data.result.Length; i++)
                {
                    TrainInfo train_info = new TrainInfo();
                    train_info.train_num = search_result.data.result[i].Split('|')[3];
                    string start_enc = search_result.data.result[i].Split('|')[6];
                    string dst_enc = search_result.data.result[i].Split('|')[7];
                    foreach(string key in this.StaionInfoDic.Keys)
                    {
                        if (this.StaionInfoDic[key] == start_enc) {
                            train_info.start_station = key;
                        }
                        if (this.StaionInfoDic[key] == dst_enc) {
                            train_info.dst_station = key;
                        }
                    }
                    train_info.start_time = search_result.data.result[i].Split('|')[8];
                    train_info.dst_time = search_result.data.result[i].Split('|')[9];
                    train_info.spend_time = search_result.data.result[i].Split('|')[10];
                    string status = search_result.data.result[i].Split('|')[11];
                    if (status == "N")
                    {
                        train_info.status = false;
                    }
                    else if(status == "Y")
                    {
                        train_info.status = true;
                    }
                    train_info.date = search_result.data.result[i].Split('|')[13];
                    train_info.business_class = search_result.data.result[i].Split('|')[32];//商务座
                    train_info.first_class = search_result.data.result[i].Split('|')[31];//一等座
                    train_info.second_class = search_result.data.result[i].Split('|')[30];//二等座
                    train_info.soft_sleeper = search_result.data.result[i].Split('|')[23];//软卧
                    train_info.no_class = search_result.data.result[i].Split('|')[26];//无座
                    train_info.hard_sleeper = search_result.data.result[i].Split('|')[28];//硬卧
                    train_info.hard_class = search_result.data.result[i].Split('|')[29];//硬座

                    //Console.WriteLine(search_result.data.result[i]);
                    Console.WriteLine("车次"+train_info.train_num + "发站:" + train_info.start_station + "到站:" + train_info.dst_station);
                }
            }
            return TrainInfoList;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {

        }

    }
}
