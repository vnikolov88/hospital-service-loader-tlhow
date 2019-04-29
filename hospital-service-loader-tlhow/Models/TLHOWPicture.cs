using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWPicture
    {
        [JsonProperty("thumb")]
        public string Thumbnail { get; set; }

        [JsonProperty("xs")]
        public string SizeXS { get; set; }

        [JsonProperty("s")]
        public string SizeS { get; set; }

        [JsonProperty("m")]
        public string SizeM { get; set; }

        [JsonProperty("l")]
        public string SizeL { get; set; }

        [JsonProperty("xl")]
        public string SizeXL { get; set; }
    }
}
