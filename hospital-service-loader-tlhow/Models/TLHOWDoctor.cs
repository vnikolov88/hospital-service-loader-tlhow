using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWDoctor
    {
        [JsonIgnore]
        public string GUID => $"{Salutation},{FirstName},{LastName}".GetHashCode().ToString();

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("Name")]
        public string LastName { get; set; }

        [JsonProperty("Title")]
        public string Salutation { get; set; }

        [JsonProperty("Address")]
        public TLHOWAddress Address { get; set; }

        [JsonProperty("Funktion")]
        public string Specialty { get; set; }

        [JsonProperty("Picture")]
        public TLHOWPicture[] Pictures { get; set; }

        [JsonProperty("CV")]
        public string CVUrl { get; set; }
    }
}
