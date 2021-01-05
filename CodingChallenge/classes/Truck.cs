using Newtonsoft.Json;
using System.Collections.Generic;

namespace CodingChallenge.classes
{
    public class Truck
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("max_weight")]
        public int MaxWeight { get; set; }
        [JsonProperty("driver_weight")]
        public List<int> DriverWeight { get; set; }
    }
}