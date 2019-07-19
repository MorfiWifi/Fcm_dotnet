using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_notifyer.mdoels
{
    public class Data
    {
        public string key = ""; // will use in heder
        public bool data_mod = false; // eventually will be sent!
        public string to = ""; // usually /topic/general

        
        public JObject notification = null;//def
        public JObject data = null ;//def 



        public void build_notif(string title , string body)
        {
            string json_data = "{" +
                    "\"title\"" +":"+ "\"" + title + "\"" + "," +
                    "\"body\"" + ":" + "\"" + body + "\"" +
                    "}";
            notification = JsonConvert.DeserializeObject<JObject>(json_data);
        }

        public void build_data(string data_str)
        { 
          this.data = JsonConvert.DeserializeObject<JObject>(data_str);
        }

        //print to console for debug
        public void print()
        {
            Console.WriteLine("key=" + key);
            Console.WriteLine("data_mod=" + data_mod);
            Console.WriteLine("to=" + to);

            Console.WriteLine("notification=" + (notification == null ? "NULL" : notification.ToString()));
            Console.WriteLine("data=" + (data == null ? "NULL" : data.ToString()));
        }
    }
}
