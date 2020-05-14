using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCosmos.Models
{
    public class Legend
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "legendname")]
        public string legendname { get; set; }

        [JsonProperty(PropertyName = "invention")]
        public string invention { get; set; }
    }
}
