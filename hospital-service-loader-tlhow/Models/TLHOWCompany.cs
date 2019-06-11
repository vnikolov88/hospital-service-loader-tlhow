using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWCompany
    {
        [JsonProperty("Iknummer")]
        public string GUID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Desc")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("Address")]
        public TLHOWAddress Address { get; set; }

        [JsonProperty("Sort")]
        public string SortOrder { get; set; }

        [JsonProperty("Picture")]
        public TLHOWPicture[] Pictures { get; set; }

        [JsonProperty("Hospital")]
        public TLHOWHospital[] Hospitals { get; set; }

        [JsonProperty("MVZ")]
        public TLHOWHospital[] MedicalCenters { get; set; }

        [JsonProperty("Certificates")]
        public TLHOWCertificate[] Certificates { get; set; }

        [JsonProperty("Personal")]
        public TLHOWDoctor[] Personal { get; set; }
    }
}
