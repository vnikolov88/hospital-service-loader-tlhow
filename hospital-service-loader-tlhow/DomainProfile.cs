﻿using AutoMapper;

namespace HospitalService.Loader.TLHOW
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Models.TLHOWCompany, Contracts.V2.Company>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.GUID, o => o.MapFrom(s => s.GUID))
                .ForMember(d => d.Hospitals, o => o.MapFrom(s => s.Hospitals))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Pictures, o => o.MapFrom(s => s.Pictures))
                .ForMember(d => d.SortOrder, o => o.MapFrom(s => s.SortOrder));

            CreateMap<Models.TLHOWAddress, Contracts.V2.Address>()
                .ForMember(d => d.City, o => o.MapFrom(s => s.City))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.Fax, o => o.MapFrom(s => s.Fax))
                .ForMember(d => d.Latitude, o => o.MapFrom(s => s.Latitude))
                .ForMember(d => d.Longitude, o => o.MapFrom(s => s.Longitude))
                .ForMember(d => d.Phone, o => o.MapFrom(s => s.Phone))
                .ForMember(d => d.Postcode, o => o.MapFrom(s => s.Postcode))
                .ForMember(d => d.Street, o => o.MapFrom(s => s.Street))
                .ForMember(d => d.StreetNr, o => o.MapFrom(s => s.StreetNr))
                .ForMember(d => d.Url, o => o.MapFrom(s => s.Url));

            // Note: the current host of TLHOW is not properly setup for CORS, we do this as a workaround
            CreateMap<Models.TLHOWPicture, Contracts.V2.Picture>()
                .ForMember(d => d.SizeL, o => o.MapFrom(s => s.SizeL.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")))
                .ForMember(d => d.SizeM, o => o.MapFrom(s => s.SizeM.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")))
                .ForMember(d => d.SizeS, o => o.MapFrom(s => s.SizeS.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")))
                .ForMember(d => d.SizeXL, o => o.MapFrom(s => s.SizeXL.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")))
                .ForMember(d => d.SizeXS, o => o.MapFrom(s => s.SizeXS.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")))
                .ForMember(d => d.Thumbnail, o => o.MapFrom(s => s.Thumbnail.Replace("https://tlhow.cms.prelaunchweb.de", "https://www.tlhow.com")));

            CreateMap<Models.TLHOWDoctor, Contracts.V2.Doctor>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.CVUrl, o => o.MapFrom(s => s.CVUrl))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.GUID, o => o.MapFrom(s => s.GUID))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Pictures, o => o.MapFrom(s => s.Pictures))
                .ForMember(d => d.Salutation, o => o.MapFrom(s => s.Salutation))
                .ForMember(d => d.Specialty, o => o.MapFrom(s => s.Specialty));

            CreateMap<Models.TLHOWHospital, Contracts.V2.Hospital>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.Departments, o => o.MapFrom(s => s.Departments))
                .ForMember(d => d.GUID, o => o.MapFrom(s => s.GUID))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Pictures, o => o.MapFrom(s => s.Pictures))
                .ForMember(d => d.SortOrder, o => o.MapFrom(s => s.SortOrder));

            CreateMap<Models.TLHOWDepartment, Contracts.V2.Department>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.Certificates, o => o.MapFrom(s => s.Certificates))
                .ForMember(d => d.DepartmentClassification, o => o.MapFrom(s => s.DepartmentClassification))
                .ForMember(d => d.DescriptionHtml, o => o.MapFrom(s => s.DescriptionHtml))
                .ForMember(d => d.Doctors, o => o.MapFrom(s => s.Doctors))
                .ForMember(d => d.GUID, o => o.MapFrom(s => s.GUID))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Pictures, o => o.MapFrom(s => s.Pictures))
                .ForMember(d => d.SortOrder, o => o.MapFrom(s => s.SortOrder))
                .ForMember(d => d.WorktimeMessageHtml, o => o.MapFrom(s => s.WorktimeMessageHtml));

            CreateMap<Models.TLHOWCertificate, Contracts.V2.Certificate>()
                .ForMember(d => d.ExternalUrl, o => o.MapFrom(s => s.ExternalUrl))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Pictures, o => o.MapFrom(s => s.Pictures));
        }
    }
}
