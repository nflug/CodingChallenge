using Newtonsoft.Json;

namespace CodingChallenge.classes
{
    public class Hardware
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        ///     Returns Amount * Weight
        /// </summary>
        /// <returns>
        ///     int | Amount * Weight
        /// </returns>
        public int GetRealWeight()
        {
            return Weight * Amount;
        }
    }
}
