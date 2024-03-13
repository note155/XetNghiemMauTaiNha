using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomchatController : ControllerBase
    {
        private readonly IRoomchat _RCRepository;
        public RoomchatController(IRoomchat RCRepository)
        {
            this._RCRepository = RCRepository;
        }

        [HttpPost("Add-Roomchat")]
        public async Task<ActionResult<roomchat>> AddNewAsync(roomchat user)
        {
            var newstudent = await _RCRepository.addAsync(user);

            return Ok(newstudent);
        }

        [HttpGet("All-Roomchatbyiduser/{id}")]
        public async Task<ActionResult<List<roomchat>>> GetAllbyiduserAsync(int id)
        {
            var users = await _RCRepository.getallbyidAsync(id);
            return Ok(users);
        }

        [HttpGet("Single-Roomchat/{id}")]
        public async Task<ActionResult<roomchat>> GetSingleStudentAsync(int id)
        {
            var student = await _RCRepository.getbyidAsync(id);

            return Ok(student);
        }
    }
}
