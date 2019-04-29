using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWCertificate
    {
        [JsonProperty("text")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string ExternalUrl { get; set; }

        [JsonProperty("image")]
        public TLHOWPicture[] Pictures { get; set; }
    }
}
