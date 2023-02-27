using AutoMapper;
using six_net.Data;
using six_net.DataTransferObjects;
using six_net.Interfaces;
using six_net.Models;
using six_net.Responses;

namespace six_net.Services
{
    public class ContestService : ContestInterface
    {

        private readonly IMapper mapper;
        private readonly DataContext context;
        public ContestService(DataContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public async Task<ContestResponse<GetAllContestDTO>> AddContest(AddContestDTO contest)
        {
            var serviceResponse = new ContestResponse<GetAllContestDTO>();

            context.Contests.Add(mapper.Map<ContestModel>(contest));

            context.SaveChanges();

            serviceResponse.Data = mapper.Map<GetAllContestDTO>(contest);

            return serviceResponse;

        }

        public Task<ContestResponse<List<GetAllContestDTO>>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
