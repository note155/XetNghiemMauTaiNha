using duanxetnghiem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuvanController : ControllerBase
    {
        private readonly ITuvan _TuvanRepository;
        public TuvanController(ITuvan TuvanRepository)
        {
            this._TuvanRepository = TuvanRepository;
        }
        [HttpGet("Single-TV/{id}")]
        public async Task<ActionResult<Tuvan>> GetSingleStudentAsync(int id)
        {
            var student = await _TuvanRepository.getbyidAsync(id);

            return Ok(student);
        }
        [HttpPost("Add-Tuvan")]
        public async Task<ActionResult<Tuvan>> AddNewBacSiAsync(Tuvan user)
        {
            var newstudent = await _TuvanRepository.addAsync(user);

            return Ok(newstudent);

        }
        [HttpGet("All-Tuvan")]
        public async Task<ActionResult<List<Tuvan>>> GetAllBacSiAsync()
        {
            var users = await _TuvanRepository.getallAsync();
            return Ok(users);
        }
        [HttpPost("Update-Tuvan")]
        public async Task<ActionResult<Tuvan>> UpdatethanhtoanAsync(Tuvan user)
        {
            var updatestudent = await _TuvanRepository.updateAsync(user);

            return Ok(updatestudent);
        }
        [HttpPost("gui-TVemail")]
        public async Task<IActionResult> guiKQEmail([FromBody] gmailTV gm)
        {
            var newStudent = await _TuvanRepository.guiemail(gm);
            return Ok(newStudent);
        }
    }
}
