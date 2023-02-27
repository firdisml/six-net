using AutoMapper;
using six_net.Controllers;
using six_net.DataTransferObjects;
using six_net.Models;

namespace six_net
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<AddContestDTO,ContestModel>();
            CreateMap<ContestModel,AddContestDTO>();
            CreateMap<AddContestDTO,GetAllContestDTO>();
        }

    }
}
