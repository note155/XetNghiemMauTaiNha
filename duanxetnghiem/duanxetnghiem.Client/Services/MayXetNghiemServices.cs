using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class MayXetNghiemServices :IMayXetNghiem
    {
        private readonly HttpClient _httpClient;
        public MayXetNghiemServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<MayXetNghiem>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/MayXetNghiem/All-MayXN");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<MayXetNghiem>>();
            return respone;
        }
    }
}
