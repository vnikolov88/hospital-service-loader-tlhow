using Newtonsoft.Json;

namespace HospitalService.Loader.TLHOW.Models
{
    public class TLHOWDepartment
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

        [JsonProperty("Workingtime")]
        public string WorktimeMessageHtml { get; set; }

        [JsonProperty("Desc")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("Certificates")]
        public TLHOWCertificate[] Certificates { get; set; }

        [JsonProperty("FA")]
        public string DepartmentClassification { get; set; }

        [JsonProperty("chief_doctors")]
        public TLHOWDoctor[] Doctors { get; set; }
    }
}
