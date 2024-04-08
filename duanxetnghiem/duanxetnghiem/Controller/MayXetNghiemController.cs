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
    public class MayXetNghiemController : ControllerBase
    {
        private readonly IMayXetNghiem _MXNRepository;

        public MayXetNghiemController(IMayXetNghiem MXNRepository)
        {
            this._MXNRepository = MXNRepository;
        }

        [HttpGet("All-MayXN")]
        public async Task<ActionResult<List<MayXetNghiem>>> GetAllMayXetNghiemAsync()
        {
            var mayXNs = await _MXNRepository.getallAsync();
            return Ok(mayXNs);
        }

        [HttpGet("Single-MayXN/{id}")]
        public async Task<ActionResult<MayXetNghiem>> GetSingleMayXetNghiemAsync(int id)
        {
            var mayXN = await _MXNRepository.getbyid(id);
            if (mayXN == null)
            {
                return NotFound();
            }
            return Ok(mayXN);
        }

        [HttpPost("Add-MayXN")]
        public async Task<ActionResult<MayXetNghiem>> AddNewMayXetNghiemAsync(MayXetNghiem mayXN)
        {
            var newMayXN = await _MXNRepository.addAsync(mayXN);
            return Ok(newMayXN);
        }

        [HttpDelete("Delete-MayXN/{id}")]
        public async Task<ActionResult<MayXetNghiem>> DeleteMayXetNghiemAsync(int id)
        {
            var deletedMayXN = await _MXNRepository.deleteAsync(id);
            if (deletedMayXN == null)
            {
                return NotFound();
            }
            return Ok(deletedMayXN);
        }

        [HttpPost("Update-MayXN")]
        public async Task<ActionResult<MayXetNghiem>> UpdateMayXetNghiemAsync(MayXetNghiem mayXN)
        {
            var updatedMayXN = await _MXNRepository.updateAsync(mayXN);
            return Ok(updatedMayXN);
        }
    }
}
