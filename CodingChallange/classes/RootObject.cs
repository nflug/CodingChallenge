using Newtonsoft.Json;
using System.Collections.Generic;

namespace CodingChallange.classes
{
    public class RootObject
    {
        [JsonProperty("hardware")]
        public List<Hardware> Hardware { get; set; }
        [JsonProperty("trucks")]
        public List<Truck> Trucks { get; set; }
    }
}
