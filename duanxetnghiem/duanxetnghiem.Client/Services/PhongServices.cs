using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class PhongServices : IPhong
    {
        private readonly HttpClient _httpClient;

        public PhongServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Phong> addAsync(Phong phong)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Phong/Add-Phong", phong);
            return await response.Content.ReadFromJsonAsync<Phong>();
        }

        public async Task<Phong> deleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Phong/Delete-Phong/{id}");
            return await response.Content.ReadFromJsonAsync<Phong>();
        }

        public async Task<List<Phong>> getallAsync()
        {
            var response = await _httpClient.GetAsync("api/Phong/All-Phong");
            return await response.Content.ReadFromJsonAsync<List<Phong>>();
        }

        public async Task<Phong> getbyid(int Id)
        {
            var response = await _httpClient.GetAsync($"api/Phong/Single-Phong/{Id}");
            return await response.Content.ReadFromJsonAsync<Phong>();
        }

        public async Task<Phong> updateAsync(Phong phong)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Phong/Update-Phong", phong);
            return await response.Content.ReadFromJsonAsync<Phong>();
        }
    }
}
