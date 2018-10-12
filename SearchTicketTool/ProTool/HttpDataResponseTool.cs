using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace SearchTicketTool.ProTool
{
    public class HttpDataResponseTool
    {
        public string HttpGetFun(string url)
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
            catch (Exception ex)
            {
                retString = ex.Message;
            }
            return retString;
        }
    }
}
