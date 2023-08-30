using System.Text.Json.Serialization;

namespace Listner
{
    public class Person
    {
        [JsonPropertyName("SAP-NAME")]
        public string Name { get; set; }
        [JsonPropertyName("SAP-LNAME")]
        public string LastName { get; set; }
        [JsonPropertyName("SAP-GENDER")]
        public string GENDER { get; set; }
    }
}
