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

        [JsonProperty("Workingtime_hdl")]
        public string WorktimeMessageHeadline { get; set; }

        [JsonProperty("Workingtime")]
        public string WorktimeMessageHtml { get; set; }

        [JsonProperty("Zablink")]
        public string BookingUrl { get; set; }

        [JsonProperty("Deschdl")]
        public string DescriptionHeadline { get; set; }

        [JsonProperty("Desc")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("Deschdl2")]
        public string Description2Headline { get; set; }

        [JsonProperty("Desc2")]
        public string Description2Html { get; set; }

        [JsonProperty("Deschdl3")]
        public string Description3Headline { get; set; }

        [JsonProperty("Desc3")]
        public string Description3Html { get; set; }

        [JsonProperty("Deschdl4")]
        public string Description4Headline { get; set; }

        [JsonProperty("Desc4")]
        public string Description4Html { get; set; }

        [JsonProperty("Certificates")]
        public TLHOWCertificate[] Certificates { get; set; }

        [JsonProperty("FA")]
        public string DepartmentClassification { get; set; }

        [JsonProperty("type")]
        public TLHOWDepartmentType Type { get; set; }

        [JsonProperty("chief_doctors")]
        public TLHOWDoctor[] Doctors { get; set; }

        [JsonProperty("HdlApp")]
        public string PersonalHeadline { get; set; }
    }
}
