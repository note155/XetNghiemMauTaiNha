using duanxetnghiem.Data.Model;
using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class MauServices : IMau
    {
        private readonly HttpClient _httpClient;
        public MauServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<Mau> addAsync(Mau mau)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Mau/Add-Mau", mau);
            var respone = await newstudent.Content.ReadFromJsonAsync<Mau>();
            return respone;
        }

        public async Task<List<Mau>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Mau/All-Mau");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Mau>>();
            return respone;
        }

        public async Task<Mau> getbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync($"api/Mau/Single-Mau/{Id}");
            var respone = await onestudent.Content.ReadFromJsonAsync<Mau>();
            return respone;
        }

        public async Task<Mau> updateAsync(Mau mau)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Mau/Update-Mau", mau);
            var respone = await newstudent.Content.ReadFromJsonAsync<Mau>();
            return respone;
        }
    }
}
