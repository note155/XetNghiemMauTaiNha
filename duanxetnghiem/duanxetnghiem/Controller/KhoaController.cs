using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaController : ControllerBase
    {
        private readonly IKhoa _KhoaRepository;
        public KhoaController(IKhoa KhoaRepository)
        {
            this._KhoaRepository = KhoaRepository;
        }
        [HttpGet("All-Khoa")]
        public async Task<ActionResult<List<Khoa>>> GetAllStudentsAsync()
        {
            var users = await _KhoaRepository.getallAsync();
            return Ok(users);
        }
    }
}
