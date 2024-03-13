using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class PhongServices : IPhong
    {
        private readonly HttpClient _httpClient;
        public PhongServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<Phong>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Phong/All-Phong");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Phong>>();
            return respone;
        }
    }
}
