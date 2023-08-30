using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventListners.Messages
{
    public class Person
    {
        [JsonProperty("SAP-NAME")] 
        public string Name { get; set; }
        [JsonProperty("SAP-LNAME")]
        public string LastName { get; set; }
        [JsonProperty("SAP-GENDER")]
        public string GENDER { get; set; }
    }
}
