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
    public class ThanhToanController : ControllerBase
    {
        private readonly IThanhToan _ThanhToanRepository;
        public ThanhToanController(IThanhToan ThanhToanRepository)
        {
            this._ThanhToanRepository = ThanhToanRepository;
        }

        [HttpGet("All-TT")]
        public async Task<ActionResult<List<ThanhToan>>> GetAllStudentsAsync()
        {
            var users = await _ThanhToanRepository.getall();
            return Ok(users);
        }

        [HttpPost("Add-ThanhToan")]
        public async Task<ActionResult<ThanhToan>> AddthanhtoanAsync(ThanhToan user)
        {
            var newstudent = await _ThanhToanRepository.addAsync(user);

            return Ok(newstudent);
        }

        [HttpGet("Single-ThanhToanbyidDXN/{id}")]
        public async Task<ActionResult<ThanhToan>> GetSinglettAsync(int id)
        {
            var student = await _ThanhToanRepository.getbyidDXNAsync(id);

            return Ok(student);
        }

        [HttpPost("Update-ThanhToan")]
        public async Task<ActionResult<ThanhToan>> UpdatethanhtoanAsync(ThanhToan user)
        {
            var updatestudent = await _ThanhToanRepository.updateAsync(user);

            return Ok(updatestudent);
        }

        [HttpDelete("Delete-ThanhToan/{id}")]
        public async Task<ActionResult<ThanhToan>> DeleteThanhToanAsync(int id)
        {
            var deletestudent = await _ThanhToanRepository.deleteAsync(id);

            return Ok(deletestudent);
        }

        [HttpGet("All-ThanhToan/{id}")]
        public async Task<ActionResult<List<ThanhToan>>> GetAllThanhToanAsync(int id)
        {
            var users = await _ThanhToanRepository.getallAsync(id);
            return Ok(users);
        }
    }
}
