using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brasileirao_API.Models
{
    public class TokenModel
    {
        [JsonProperty("registration_ids")]
        public List<string> Tokens { get; set; }

        [JsonProperty("content_available")]
        public string ContentAvailable { get; set; }

        [JsonProperty("notification")]
        public Notification NotificationPush { get; set; }

        [JsonProperty("data")]
        public Data DataPush { get; set; }

        public class Notification
        {
            [JsonProperty("title")]
            public string Title { get; set; }
            [JsonProperty("body")]
            public string Body { get; set; }
        }
        public class Data
        {
            [JsonProperty("extra")]
            public string Extra { get; set; }
        }
    }
}
