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
				if (gioHangs == null || gioHangs.Count == 0)
				{
					return NotFound($"No GioHang found for user with ID = {iduser}");
				}

				return Ok(gioHangs);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving GioHangs");
			}
		}
	}
}
