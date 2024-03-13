using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChat _ChatRepository;
        public ChatController(IChat ChatRepository)
        {
            this._ChatRepository = ChatRepository;
        }
        [HttpPost("Add-Chat")]
        public async Task<ActionResult<Chat>> AddNewAsync(Chat user)
        {
            var newstudent = await _ChatRepository.addAsync(user);

            return Ok(newstudent);
        }
        [HttpGet("All-Chatbyidroom/{id}")]
        public async Task<ActionResult<List<Chat>>> GetAllbyiduserAsync(int id)
        {
            var users = await _ChatRepository.getallbyidroomAsync(id);
            return Ok(users);
        }
    }
}
