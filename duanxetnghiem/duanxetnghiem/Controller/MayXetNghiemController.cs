using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MayXetNghiemController : ControllerBase
    {
        private readonly IMayXetNghiem _MXNRepository;
        public MayXetNghiemController(IMayXetNghiem MXNRepository)
        {
            this._MXNRepository = MXNRepository;
        }
        [HttpGet("All-MayXN")]
        public async Task<ActionResult<List<MayXetNghiem>>> GetAllStudentsAsync()
        {
            var users = await _MXNRepository.getallAsync();
            return Ok(users);
        }
    }
}
