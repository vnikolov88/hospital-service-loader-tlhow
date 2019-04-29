using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWHospital
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

        [JsonProperty("Department")]
        public TLHOWDepartment[] Departments { get; set; }
    }
}
