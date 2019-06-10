using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWAddress
    {
        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("Place")]
        public string City { get; set; }

        [JsonProperty("Postcode")]
        public string Postcode { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("StreetNr")]
        public string StreetNr { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("fblink")]
        public string FBUrl { get; set; }

        [JsonProperty("twlink")]
        public string TWUrl { get; set; }

        [JsonProperty("dataprivacylink")]
        public string DataPrivacyUrl { get; set; }

        [JsonProperty("imprintlink")]
        public string ImprintUrl { get; set; }

        [JsonProperty("slink")]
        public string JobsUrl { get; set; }

        [JsonProperty("rsslink")]
        public string NewsUrl { get; set; }

        [JsonProperty("eventlink")]
        public string EventsUrl { get; set; }
    }
}
