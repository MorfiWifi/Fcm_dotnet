using FCM_notifyer.mdoels;
using Newtonsoft.Json.Linq;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCM_notifyer.network
{
    public interface  FcmInterFaceApi
    {
        // auth : key=your_api_key
        [Post("/fcm/send")]
        [Headers("Accept: application/json")]
        Task<JObject> post_message (Data data , [Header("Authorization")] string authorization);
    }
}
