using FCM_notifyer.mdoels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_notifyer.network
{
    public class RequestHandler
    {
        public static async Task<string> post_notif(Data data , string auth)
        {
            var fcm_api = RefitService.get_instance();
            var json_respons = await fcm_api.post_message(data ,auth );
            Console.WriteLine(json_respons.ToString());
            return json_respons.ToString();
        }
    }
}
