using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyVega.Controllers.Resources;
using MyVega.Models;

namespace MyVega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();

            //API Resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features
                    .Select(id => new VehicleFeature { FeatureId = id })));
            //FOR EACH int WE NEED TO CREATE A NEW VehicleFeature object
        }
    }
}