using System.Net.Http.Json;
using duanxetnghiem.Client.Pages.User.DichVu_user;
using GoogleMapsComponents.Maps;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class TuvanServices : ITuvan
    {
        private readonly HttpClient _httpClient;
        public TuvanServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<Tuvan> addAsync(Tuvan tuvan)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Tuvan/Add-Tuvan", tuvan);
            var respone = await newstudent.Content.ReadFromJsonAsync<Tuvan>();
            return respone;
        }

        public async Task<List<Tuvan>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Tuvan/All-Tuvan");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Tuvan>>();
            return respone;
        }

        public async Task<Tuvan> getbyidAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Tuvan/Single-TV/{id}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<Tuvan>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }

        public async Task<gmailTV> guiemail(gmailTV gm)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Tuvan/gui-TVemail", gm);
            var respone = await newstudent.Content.ReadFromJsonAsync<gmailTV>();
            return respone;
        }

        public async Task<Tuvan> updateAsync(Tuvan tuvan)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Tuvan/Update-Tuvan", tuvan);
            var respone = await newstudent.Content.ReadFromJsonAsync<Tuvan>();
            return respone;
        }
    }
}
