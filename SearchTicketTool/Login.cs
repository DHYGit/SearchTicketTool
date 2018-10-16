using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SearchTicketTool.ProTool;
using SearchTicket.Model;
using Newtonsoft.Json;


namespace SearchTicketTool
{
    public partial class Login : Form
    {

        public MainForm main_form;
        
        private HttpHelper http = new HttpHelper();
        private string url_login = "https://kyfw.12306.cn/otn/login/init";
        /// <summary>
        /// 图片0.6倍 最上面的高35px不算
        /// </summary>
        private string url_code = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=login&rand=sjrand&";
        /// <summary>
        /// 验证码验证接口
        /// </summary>
        private string url_code_post = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
        /// <summary>
        /// 帐号和密码验证POST
        /// </summary>
        private string url_login_auth = "https://kyfw.12306.cn/otn/login/loginAysnSuggest";
        /// <summary>
        /// 我的12306
        /// </summary>
        private string my_12306 = "https://kyfw.12306.cn/otn/index/initMy12306";

        private List<string> pointcode = new List<string>();
        public Login()
        {
            InitializeComponent();
            try
            {
                ResponseModel respone = http.HttpVisit(url_login);
                ChangeCode();
                //Random rand = new Random();
                //ResponseModel img = http.HttpVisit(url_code + rand.ToString(), false, null, 1);
                //piccode.Image = Image.FromStream(img.Stream);
                //piccode.ImageLocation = url_code;
            }
            catch (Exception ex)
            {
                //
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_form.IsEnableForm(true);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (this.textBox_User.Text == "") {
                MessageBox.Show("请填写用户名");
                return;
            }
            if (this.textBox_Password.Text == "") {
                MessageBox.Show("请输入密码");
                return;
            }
            if (pointcode.Count == 0) {
                MessageBox.Show("请勾选验证码");
                return;
            }
            string username = this.textBox_User.Text.Trim();
            string password = this.textBox_Password.Text.Trim();
            string code = string.Join(",", pointcode);
            //MessageBox.Show(code);
            try
            {
                ResponseModel respone = http.HttpVisit(url_code_post, true, "randCode=" + code + "&rand=sjrand");
                PicCode picjson = JsonConvert.DeserializeObject<PicCode>(respone.Html);
                if (picjson.data.result.Equals("1") && picjson.data.msg.Equals("TRUE"))
                {
                    //MessageBox.Show("验证码成功!");
                    string post = string.Format("loginUserDTO.user_name={0}&userDTO.password={1}&randCode={2}", username, password, code);
                    ResponseModel respone_login = http.HttpVisit(url_login_auth, true, post);
                    PicCode auth = JsonConvert.DeserializeObject<PicCode>(respone_login.Html);
                    if (auth.messages.Count() == 0 && auth.data.loginCheck.Equals("Y"))
                    {
                        //登录成功! 
                        this.main_form.login_status = true;
                        ResponseModel respone_my = http.HttpVisit(my_12306);
                        string[] responseArray = respone_my.Html.Split('\n');
                        
                        foreach (string str in responseArray) {
                            if (str.Contains("dd_4_NonComOrder")) //未完成订单
                            {
                                this.main_form.my12306.NoCompleteOrderUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                            }
                            if (str.Contains("dd_4_comOrder")) //已完成订单
                            {
                                this.main_form.my12306.CompletedOrderUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                            }
                            if (str.Contains("link_4_ticketInfo"))//我的保险
                            {
                                this.main_form.my12306.MyInsuranceUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                            }
                            if (str.Contains("dd_4_showMyInfor")) //查看个人信息
                            {
                                this.main_form.my12306.ShowUserInfoUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                            }
                            if (str.Contains("dd_4_showSafe")) //账号安全
                            {
                                this.main_form.my12306.UserSecurityUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.UserSecurityUrl);
                            }
                            if (str.Contains("dd_4_sjhy"))//手机核验
                            {
                                this.main_form.my12306.sjhyUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.sjhyUrl);
                            }
                            if (str.Contains("dd_4_passengerIns")) //常用联系人
                            {
                                this.main_form.my12306.PassengersUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.PassengersUrl);
                            }
                            if (str.Contains("dd_4_address"))//车票快递地址
                            {
                                this.main_form.my12306.AddressUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.AddressUrl);
                            }
                            if (str.Contains("dd_4_qxyy")) //重点旅客预约
                            {
                                this.main_form.my12306.qxyyUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.qxyyUrl);
                            }
                            if (str.Contains("dd_4_lostitems")) //遗失物品查找
                            {
                                this.main_form.my12306.LostitemsUrl = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.LostitemsUrl);
                            }
                            if (str.Contains("dd_4_serviceQuery")) 
                            {
                                this.main_form.my12306.ServiceQuery = "https://kyfw.12306.cn/otn/" + str.Split(' ')[2].Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.ServiceQuery);
                            }
                            if (str.Contains("退出")) 
                            {
                                this.main_form.my12306.login_outUrl = "https://kyfw.12306.cn" +  str.Split('"')[3];
                                Console.WriteLine(this.main_form.my12306.login_outUrl);
                            }
                            if (str.Contains("selectYuding")) //车票预订
                            {
                                this.main_form.my12306.LeftTicketUrl = "https://kyfw.12306.cn" + str.Split('"')[3];
                                Console.WriteLine("车票预订:" + this.main_form.my12306.LeftTicketUrl);
                            }
                            if (str.Contains("接续换乘")) 
                            {
                                this.main_form.my12306.LcQueryUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.LcQueryUrl);
                            }
                            if (str.Contains("铁路畅行")) 
                            {
                                this.main_form.my12306.tlcxUrl = str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.tlcxUrl);
                            }
                            if (str.Contains("餐饮?特产")) {
                                this.main_form.my12306.excaterUrl = str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.excaterUrl);
                            }
                            if (str.Contains(">车次查询"))
                            {
                                this.main_form.my12306.TrainInfoUrl = "https://kyfw.12306.cn" + str.Split('"')[5];
                                Console.WriteLine(this.main_form.my12306.TrainInfoUrl);
                            }
                            if (str.Contains(">票价查询")) 
                            {
                                this.main_form.my12306.TicketPriceUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.TicketPriceUrl);
                            }
                            if (str.Contains("公布票价查询")) 
                            {
                                this.main_form.my12306.PublicPrice = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.PublicPrice);
                            }
                            if (str.Contains("车站车次查询")) 
                            {
                                this.main_form.my12306.czxxUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.czxxUrl);
                            }
                            if (str.Contains("中转查询")) 
                            {
                                this.main_form.my12306.zzzcxUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.zzzcxUrl);
                            }
                            if (str.Contains("正晚点查询")) 
                            {
                                this.main_form.my12306.zwdchUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.zwdchUrl);
                            }
                            if (str.Contains("代售点查询")) 
                            {
                                this.main_form.my12306.AgencySellTicketUrl = "https://kyfw.12306.cn" + str.Split('"')[1];
                                Console.WriteLine(this.main_form.my12306.AgencySellTicketUrl);
                            }
                            if (str.Contains("selectHelp"))
                            {
                                this.main_form.my12306.HelpInfoUrl = "https://kyfw.12306.cn" + str.Split('"')[3];
                                Console.WriteLine(this.main_form.my12306.HelpInfoUrl);
                            }
                            if (str.Contains("login_user")) {//用户名
                                this.main_form.my12306.login_user = str.Split('<')[str.Split('<').Length - 2].Split('>')[1];
                            }
                            if (str.Contains("好！"))//时间状态信息
                            {
                                this.main_form.my12306.TimeInfo = str.Split('<')[0];
                            }
                        }
                        this.main_form.label_LogInfo.Text = this.main_form.my12306.login_user + this.main_form.my12306.TimeInfo;
                        //Console.WriteLine(respone_my.Html);
                        MessageBox.Show("登录成功");
                        this.Close();
                    }
                    else
                    {
                        this.main_form.login_status = false;
                        ChangeCode();
                    }
                }
                else
                {
                    this.main_form.login_status = false;
                    ChangeCode();
                }
            }
            catch(Exception ex) {
                this.main_form.login_status = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeCode()
        {
            try
            {
                Random rand = new Random();
                ResponseModel img = http.HttpVisit(url_code + rand.ToString(), false, null, 1);
                this.pictureBox_Verification.Image = Image.FromStream(img.Stream);
                pointcode.Clear();
                //piccode.ImageLocation = url_code;
            }
            catch (Exception ex)
            {
                //
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox_Verification_Click(object sender, EventArgs e)
        {
            Point mx = this.pictureBox_Verification.PointToClient(MousePosition);
            Pen p = Pens.Black;//声明一个画笔
            Graphics g = this.pictureBox_Verification.CreateGraphics();
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, this.Width / 2), new Point(this.Height, this.Width / 2), Color.FromArgb(50, 50, 100), Color.FromArgb(50, 50, 200));//LinearGradientBrush是要System.Drawing.Drawing2D;命名控件下的，可以是填充颜色渐变 
            Rectangle r = new Rectangle(mx.X, mx.Y, 10, 10);//标识圆的大小
            //g.DrawEllipse(Pens.Red, mx.X, mx.Y, 10, 10);
            g.DrawEllipse(p, r);
            g.FillEllipse(b, r);
            g.Dispose();
            Point ratmx = new Point() { X = (int)(mx.X / 0.6), Y = (int)(mx.Y / 0.6 - 35) };
            pointcode.Add(((int)(mx.X)).ToString());
            pointcode.Add(((int)(mx.Y - 35)).ToString());
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            ChangeCode();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_ShowPassword.Checked)
            {
                this.textBox_Password.PasswordChar = new char();
            }
            else
            {
                this.textBox_Password.PasswordChar = '*';
            }
        }
    }
}
