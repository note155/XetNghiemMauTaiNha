using duanxetnghiem.Data.Model;
using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class KhoaServices :IKhoa
    {
        private readonly HttpClient _httpClient;
        public KhoaServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<Khoa>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Khoa/All-Khoa");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Khoa>>();
            return respone;
        }
    }
}
