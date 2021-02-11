using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Si2020ApiCore.Models
{
    public class UserInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("claims")]
        public Dictionary<string, string> Claims { get; set; }
    }
}
