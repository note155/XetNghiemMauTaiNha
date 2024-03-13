using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongController : ControllerBase
    {
        private readonly IPhong _PhongRepository;
        public PhongController(IPhong PhongRepository)
        {
            this._PhongRepository = PhongRepository;
        }
        [HttpGet("All-Phong")]
        public async Task<ActionResult<List<Phong>>> GetAllStudentsAsync()
        {
            var users = await _PhongRepository.getallAsync();
            return Ok(users);
        }
    }
}
