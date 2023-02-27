using six_net.DataTransferObjects;
using six_net.Responses;

namespace six_net.Interfaces
{
    public interface ContestInterface
    {
        Task<ContestResponse<List<GetAllContestDTO>>> GetAll();
        Task<ContestResponse<GetAllContestDTO>> AddContest(AddContestDTO contest);
    }
}
