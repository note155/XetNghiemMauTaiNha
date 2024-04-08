using duanxetnghiem.Data.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class KhoaServices : IKhoa
    {
        private readonly HttpClient _httpClient;

        public KhoaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Khoa> addAsync(Khoa khoa)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Khoa/Add-Khoa", khoa);
            return await response.Content.ReadFromJsonAsync<Khoa>();
        }

        public async Task<Khoa> deleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Khoa/Delete-Khoa/{id}");
            return await response.Content.ReadFromJsonAsync<Khoa>();
        }

        public async Task<List<Khoa>> getallAsync()
        {
            var response = await _httpClient.GetAsync("api/Khoa/All-Khoa");
            return await response.Content.ReadFromJsonAsync<List<Khoa>>();
        }

        public async Task<Khoa> getbyid(int Id)
        {
            var response = await _httpClient.GetAsync($"api/Khoa/Single-Khoa/{Id}");
            return await response.Content.ReadFromJsonAsync<Khoa>();
        }

        public async Task<Khoa> updateAsync(Khoa khoa)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Khoa/Update-Khoa", khoa);
            return await response.Content.ReadFromJsonAsync<Khoa>();
        }
    }
}
