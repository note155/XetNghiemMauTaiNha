using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class TinhtrangServices : ITinhtrang
    {
        private readonly HttpClient _httpClient;
        public TinhtrangServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<Tinhtrang> addAsync(Tinhtrang tinhtrang)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Tinhtrang/Add-Tinhtrang", tinhtrang);
            var respone = await newstudent.Content.ReadFromJsonAsync<Tinhtrang>();
            return respone;
        }

        public async Task<List<Tinhtrang>> getbyidAsync(int iddon)
        {
            var response = await _httpClient.GetAsync($"api/Tinhtrang/Single-Tinhtrang/{iddon}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<List<Tinhtrang>>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }
    }
}
