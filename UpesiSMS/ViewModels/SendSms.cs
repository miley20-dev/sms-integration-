using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpesiSMS.ViewModels
{
   
    public class SendSms

    {
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }

    }


}
