using duanxetnghiem.Data.Model;
using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class ThanhToanServices : IThanhToan
    {
        private readonly HttpClient _httpClient;
        public ThanhToanServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<ThanhToan> addAsync(ThanhToan thanhToan)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/ThanhToan/Add-ThanhToan", thanhToan);
            var respone = await newstudent.Content.ReadFromJsonAsync<ThanhToan>();
            return respone;
        }

        public async Task<ThanhToan> deleteAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/ThanhToan/Delete-ThanhToan", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<ThanhToan>();
            return respone;
        }

        public async Task<List<ThanhToan>> getallAsync(int id)
        {
            var allstudent = await _httpClient.GetAsync($"api/ThanhToan/All-ThanhToan/{id}");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<ThanhToan>>();
            return respone;
        }

        public async Task<ThanhToan> getbyidDXNAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/ThanhToan/Single-ThanhToanbyidDXN/{id}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<ThanhToan>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }

        public async Task<ThanhToan> updateAsync(ThanhToan thanhToan)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/ThanhToan/Update-ThanhToan", thanhToan);
            var respone = await newstudent.Content.ReadFromJsonAsync<ThanhToan>();
            return respone;
        }
    }
}
