using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWCompany
    {
        [JsonProperty("Iknummer")]
        public string GUID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Address")]
        public TLHOWAddress Address { get; set; }

        [JsonProperty("Sort")]
        public string SortOrder { get; set; }

        [JsonProperty("Picture")]
        public TLHOWPicture[] Pictures { get; set; }

        [JsonProperty("Hospital")]
        public TLHOWHospital[] Hospitals { get; set; }
    }
}
