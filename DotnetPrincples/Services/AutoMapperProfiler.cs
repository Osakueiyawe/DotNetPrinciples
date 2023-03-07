using AutoMapper;
using DotnetPrincples.Models;

namespace DotnetPrincples.Services
{
    public class AutoMapperProfiler:Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<SampleReturnA, SampleReturnB>()
                .ForMember(dest => dest.pupil, action => action.MapFrom(src => src.newAddition.Substring(0,3)));
        }
    }
}
