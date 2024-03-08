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
    public class MauController : ControllerBase
    {
        private readonly IMau _MauRepository;
        public MauController(IMau MauRepository)
        {
            this._MauRepository = MauRepository;
        }
        [HttpGet("All-Mau")]
        public async Task<ActionResult<List<Mau>>> GetAllStudentsAsync()
        {
            var users = await _MauRepository.getallAsync();
            return Ok(users);
        }
        [HttpGet("Single-Mau/{id}")]
        public async Task<ActionResult<Mau>> GetSingleStudentAsync(int id)
        {
            var student = await _MauRepository.getbyid(id);

            return Ok(student);
        }
        [HttpPost("Add-Mau")]
        public async Task<ActionResult<Mau>> AddNewBacSiAsync(Mau mau)
        {
            var newstudent = await _MauRepository.addAsync(mau);

            return Ok(newstudent);

        }
        [HttpPost("Update-Mau")]
        public async Task<ActionResult<Mau>> UpdateStudentAsync(Mau user)
        {
            var updatestudent = await _MauRepository.updateAsync(user);

            return Ok(updatestudent);
        }
    }
}
