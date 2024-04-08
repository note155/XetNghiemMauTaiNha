using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<List<Khoa>>> GetAllKhoaAsync()
        {
            var khoas = await _KhoaRepository.getallAsync();
            return Ok(khoas);
        }

        [HttpGet("Single-Khoa/{id}")]
        public async Task<ActionResult<Khoa>> GetSingleKhoaAsync(int id)
        {
            var khoa = await _KhoaRepository.getbyid(id);
            if (khoa == null)
            {
                return NotFound();
            }
            return Ok(khoa);
        }

        [HttpPost("Add-Khoa")]
        public async Task<ActionResult<Khoa>> AddNewKhoaAsync(Khoa khoa)
        {
            var newKhoa = await _KhoaRepository.addAsync(khoa);
            return Ok(newKhoa);
        }

        [HttpDelete("Delete-Khoa/{id}")]
        public async Task<ActionResult<Khoa>> DeleteKhoaAsync(int id)
        {
            var deletedKhoa = await _KhoaRepository.deleteAsync(id);
            if (deletedKhoa == null)
            {
                return NotFound();
            }
            return Ok(deletedKhoa);
        }

        [HttpPost("Update-Khoa")]
        public async Task<ActionResult<Khoa>> UpdateKhoaAsync(Khoa khoa)
        {
            var updatedKhoa = await _KhoaRepository.updateAsync(khoa);
            return Ok(updatedKhoa);
        }
    }
}
