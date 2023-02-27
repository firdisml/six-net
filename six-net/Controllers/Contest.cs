using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using six_net.DataTransferObjects;
using six_net.Interfaces;
using six_net.Responses;

namespace six_net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contest : ControllerBase
    {
        private readonly ContestInterface service;
        public Contest(ContestInterface service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<ActionResult<ContestResponse<GetAllContestDTO>>> AddContest(AddContestDTO character)
        {
            return Ok(await service.AddContest(character));
        }

    }
}
