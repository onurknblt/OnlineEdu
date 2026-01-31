using AutoMapper;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Mapping
{
    public class SubscriberMapping: Profile
    {
        public SubscriberMapping() 
        {
            CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();
        }
    }
}
