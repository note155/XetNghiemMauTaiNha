using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
	public class GioHangServices : IGioHang
	{
		private readonly HttpClient _httpClient;
		public GioHangServices(HttpClient httpClient)
		{
			this._httpClient = httpClient;
		}
		public async Task<GioHang> addAsync(GioHang gioHang)
		{
			try
			{
				var response = await _httpClient.PostAsJsonAsync("api/GioHang/Add-GH", gioHang);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<GioHang>();
			}
			catch (Exception ex)
			{
				throw new Exception("Error adding GioHang", ex);
			}
		}

		public async Task<GioHang> deleteAsync(int id)
		{
			try
			{
				var response = await _httpClient.DeleteAsync($"api/GioHang/Delete-GH/{id}");
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<GioHang>();
			}
			catch (Exception ex)
			{
				throw new Exception("Error deleting GioHang", ex);
			}
		}

		public async Task<List<GioHang>> getallAsyncbyiduser(int iduser)
		{
			try
			{
				var response = await _httpClient.GetAsync($"api/GioHang/All-GH/{iduser}");
				var a= await response.Content.ReadFromJsonAsync<List<GioHang>>();
				if (a != null) return a;
				else return null;
			}
			catch (Exception ex)
			{
				throw new Exception("Error getting GioHangs by UserId", ex);
			}
		}
	}
}
