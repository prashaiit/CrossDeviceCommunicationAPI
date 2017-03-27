using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CrossDeviceCommunicationAPI.Models
{
    public class TriggerValue
    {
        [JsonProperty("value")]
        public string trigger;
    }
}