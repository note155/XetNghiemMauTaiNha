using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChisoController : ControllerBase
    {
        private readonly IChiso _ChisoRepository;
        public ChisoController(IChiso ChisoRepository)
        {
            this._ChisoRepository = ChisoRepository;
        }

        [HttpGet("All-Chiso")]
        public async Task<ActionResult<List<Chiso>>> GetAllChisoAsync()
        {
            var users = await _ChisoRepository.getallAsync();
            return Ok(users);
        }
    }
}
