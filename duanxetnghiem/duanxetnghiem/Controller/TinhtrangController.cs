using duanxetnghiem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhtrangController : ControllerBase
    {
        private readonly ITinhtrang _TinhTrangRepository;
        public TinhtrangController(ITinhtrang TinhTrangRepository)
        {
            this._TinhTrangRepository = TinhTrangRepository;
        }

        [HttpPost("Add-Tinhtrang")]
        public async Task<ActionResult<Tinhtrang>> AddNewBacSiAsync(Tinhtrang user)
        {
            var newstudent = await _TinhTrangRepository.addAsync(user);

            return Ok(newstudent);

        }
        [HttpGet("Single-Tinhtrang/{id}")]
        public async Task<ActionResult<List<Tinhtrang>>> GetSingleStudentAsync(int id)
        {
            var student = await _TinhTrangRepository.getbyidAsync(id);

            return Ok(student);
        }
    }
}
