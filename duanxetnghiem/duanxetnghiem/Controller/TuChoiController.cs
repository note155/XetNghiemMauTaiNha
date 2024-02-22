using duanxetnghiem.Data.Model;
using duanxetnghiem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuChoiController : ControllerBase
    {
        private readonly ITuChoi _TuChoiRepository;
        public TuChoiController(ITuChoi TuChoiRepository)
        {
            this._TuChoiRepository = TuChoiRepository;
        }

        [HttpGet("All-TuChoi")]
        public async Task<ActionResult<List<TuChoi>>> GetAllBacSiAsync()
        {
            var users = await _TuChoiRepository.getallAsync();
            return Ok(users);
        }

        [HttpPost("Add-TuChoi")]
        public async Task<ActionResult<BacSi>> AddNewBacSiAsync(TuChoi user)
        {
            var newstudent = await _TuChoiRepository.addAsync(user);

            return Ok(newstudent);

        }
    }
}
