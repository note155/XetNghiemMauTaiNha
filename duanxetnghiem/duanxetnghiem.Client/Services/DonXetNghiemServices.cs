﻿using duanxetnghiem.Data.Model;
using Shared.ketnoi;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class DonXetNghiemServices :IDonXetNghiem
    {
        private readonly HttpClient _httpClient;
        public DonXetNghiemServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<DonXetNghiem> addAsync(DonXetNghiem DonXetNghiem)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DonXetNghiem/Add-DXN", DonXetNghiem);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }

        public async Task<DonXetNghiem> deleteAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DonXetNghiem/Delete-DXN", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }

        public async Task<List<DonXetNghiem>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/DonXetNghiem/All-DXN");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<DonXetNghiem>>();
            return respone;
        }

        public async Task<DonXetNghiem> getbyid(int Id)
        {
            var response = await _httpClient.GetAsync($"api/DonXetNghiem/Single-DXN/{Id}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<DonXetNghiem>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }

        public async Task<DonXetNghiem> updateAsync(DonXetNghiem DonXetNghiem)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DonXetNghiem/Update-DXN", DonXetNghiem);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }
    }
}
