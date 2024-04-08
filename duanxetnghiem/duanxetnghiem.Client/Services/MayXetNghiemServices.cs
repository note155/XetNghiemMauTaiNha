using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class MayXetNghiemServices : IMayXetNghiem
    {
        private readonly HttpClient _httpClient;

        public MayXetNghiemServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MayXetNghiem> addAsync(MayXetNghiem may)
        {
            var response = await _httpClient.PostAsJsonAsync("api/MayXetNghiem/Add-MayXN", may);
            return await response.Content.ReadFromJsonAsync<MayXetNghiem>();
        }

        public async Task<MayXetNghiem> deleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/MayXetNghiem/Delete-MayXN/{id}");
            return await response.Content.ReadFromJsonAsync<MayXetNghiem>();
        }

        public async Task<List<MayXetNghiem>> getallAsync()
        {
            var response = await _httpClient.GetAsync("api/MayXetNghiem/All-MayXN");
            return await response.Content.ReadFromJsonAsync<List<MayXetNghiem>>();
        }

        public async Task<MayXetNghiem> getbyid(int Id)
        {
            var response = await _httpClient.GetAsync($"api/MayXetNghiem/Single-MayXN/{Id}");
            return await response.Content.ReadFromJsonAsync<MayXetNghiem>();
        }

        public async Task<MayXetNghiem> updateAsync(MayXetNghiem may)
        {
            var response = await _httpClient.PostAsJsonAsync("api/MayXetNghiem/Update-MayXN", may);
            return await response.Content.ReadFromJsonAsync<MayXetNghiem>();
        }
    }
}
