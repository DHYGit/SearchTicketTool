using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SearchTicketTool.ProTool
{
    public class SearchResult
    {
        public Data data;
        public int httpstatus;
        public string messages;
        public bool status;
    }
    public class Data 
    {
        public string flag;
        public Dictionary<string, string> map;
        public string[] result;
    }

    
}
