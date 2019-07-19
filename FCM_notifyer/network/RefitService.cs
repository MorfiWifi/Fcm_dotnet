using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_notifyer.network
{
    public static class RefitService
    {
        const string base_url = "https://fcm.googleapis.com/";

        public static FcmInterFaceApi get_instance()
        {
            return RestService.For<FcmInterFaceApi>(base_url);
        }
    }
}
