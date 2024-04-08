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
    public class PhongController : ControllerBase
    {
        private readonly IPhong _PhongRepository;

        public PhongController(IPhong PhongRepository)
        {
            this._PhongRepository = PhongRepository;
        }

        [HttpGet("All-Phong")]
        public async Task<ActionResult<List<Phong>>> GetAllPhongAsync()
        {
            var phongs = await _PhongRepository.getallAsync();
            return Ok(phongs);
        }

        [HttpGet("Single-Phong/{id}")]
        public async Task<ActionResult<Phong>> GetSinglePhongAsync(int id)
        {
            var phong = await _PhongRepository.getbyid(id);
            if (phong == null)
            {
                return NotFound();
            }
            return Ok(phong);
        }

        [HttpPost("Add-Phong")]
        public async Task<ActionResult<Phong>> AddNewPhongAsync(Phong phong)
        {
            var newPhong = await _PhongRepository.addAsync(phong);
            return Ok(newPhong);
        }

        [HttpDelete("Delete-Phong/{id}")]
        public async Task<ActionResult<Phong>> DeletePhongAsync(int id)
        {
            var deletedPhong = await _PhongRepository.deleteAsync(id);
            if (deletedPhong == null)
            {
                return NotFound();
            }
            return Ok(deletedPhong);
        }

        [HttpPost("Update-Phong")]
        public async Task<ActionResult<Phong>> UpdatePhongAsync(Phong phong)
        {
            var updatedPhong = await _PhongRepository.updateAsync(phong);
            return Ok(updatedPhong);
        }
    }
}
