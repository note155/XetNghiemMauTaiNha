using duanxetnghiem.Data.Model;
using duanxetnghiem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace duanxetnghiem.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class GioHangController : ControllerBase
	{
		private readonly IGioHang _GioHangRepository;

		public GioHangController(IGioHang GioHangRepository)
		{
			this._GioHangRepository = GioHangRepository;
		}

		[HttpPost("Add-GH")]
		public async Task<ActionResult<GioHang>> AddGioHangAsync(GioHang gioHang)
		{
			try
			{
				var newGioHang = await _GioHangRepository.addAsync(gioHang);
				return Ok(newGioHang);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error creating new GioHang");
			}
		}

		[HttpDelete("Delete-GH/{id}")]
		public async Task<ActionResult<GioHang>> DeleteGioHangAsync(int id)
		{
			try
			{
				var gioHangToDelete = await _GioHangRepository.deleteAsync(id);
				if (gioHangToDelete == null)
				{
					return NotFound($"GioHang with ID = {id} not found");
				}

				return Ok(gioHangToDelete);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting GioHang");
			}
		}

		[HttpGet("All-GH/{iduser}")]
		public async Task<ActionResult<List<GioHang>>> GetAllGioHangsByUserIdAsync(int iduser)
		{
			try
			{
				var gioHangs = await _GioHangRepository.getallAsyncbyiduser(iduser);
				return Ok(gioHangs);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving GioHangs");
			}
		}

        [HttpPost("Update-GH")]
        public async Task<ActionResult<GioHang>> UpdateBacSiAsync(GioHang user)
        {
            var updatestudent = await _GioHangRepository.updateAsync(user);

            return Ok(updatestudent);
        }

        [HttpGet("All-GHtrue/{iduser}")]
        public async Task<ActionResult<List<GioHang>>> GetAllGioHangistrue(int iduser)
        {
            try
            {
                var gioHangs = await _GioHangRepository.getallistrue(iduser);
                return Ok(gioHangs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving GioHangs");
            }
        }

        [HttpPost("Check-Existence/{Giohang}")]
        public async Task<ActionResult<bool>> CheckExistenceAsync(GioHang Giohang)
        {
            try
            {
                var exists = await _GioHangRepository.kiemtra(Giohang);
                return Ok(exists);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error checking existence");
            }
        }
    }
}
