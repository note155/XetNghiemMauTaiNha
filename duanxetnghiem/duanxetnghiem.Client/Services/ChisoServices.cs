using duanxetnghiem.Data.Model;
using System.Net.Http;
using Shared.ketnoi;
using Shared.Model;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class ChisoServices : IChiso
    {
        private readonly HttpClient _httpClient;
        public ChisoServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<Chiso>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Chiso/All-Chiso");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Chiso>>();
            return respone;
        }
    }
}
