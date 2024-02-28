using duanxetnghiem.Data.Model;
using System.Net.Http;
using Shared.ketnoi;
using Shared.Model;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{

    public class TuChoiServices : ITuChoi
    {
        private readonly HttpClient _httpClient;
        public TuChoiServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<TuChoi> addAsync(TuChoi tuchoi)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/TuChoi/Add-TuChoi", tuchoi);
            var respone = await newstudent.Content.ReadFromJsonAsync<TuChoi>();
            return respone;
        }

        public async Task<List<TuChoi>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/TuChoi/All-TuChoi");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<TuChoi>>();
            return respone;
        }

        public async Task<TuChoi> getbyidAsync(int iddon)
        {
            var response = await _httpClient.GetAsync($"api/TuChoi/Single-TC/{iddon}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<TuChoi>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }
    }
}
