using System.Net.Http.Json;
using duanxetnghiem.Client.Pages.User.DichVu_user;
using duanxetnghiem.Data.Model;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class RoomchatServices :IRoomchat
    {
        private readonly HttpClient _httpClient;
        public RoomchatServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<roomchat> addAsync(roomchat roomchat)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Roomchat/Add-Roomchat", roomchat);
            var respone = await newstudent.Content.ReadFromJsonAsync<roomchat>();
            return respone;
        }

		public async Task<List<roomchat>> getallAsync()
		{
			var allstudent = await _httpClient.GetAsync("api/Roomchat/All-Roomchat");
			var respone = await allstudent.Content.ReadFromJsonAsync<List<roomchat>>();
			return respone;
		}

		public async Task<List<roomchat>> getallbyidAsync(int id)
        {
            var allstudent = await _httpClient.GetAsync($"api/Roomchat/All-Roomchatbyiduser/{id}");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<roomchat>>();
            return respone;
        }

        public async Task<int> getallbyidbsAsync(int id)
        {
            var allstudent = await _httpClient.GetAsync($"api/Roomchat/All-Roomchatbyidbs/{id}");
            var respone = await allstudent.Content.ReadFromJsonAsync<int>();
            return respone;
        }

        public async Task<roomchat> getbyidAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Roomchat/Single-Roomchat/{id}");
            if (response.IsSuccessStatusCode)
            {
                var respone = await response.Content.ReadFromJsonAsync<roomchat>();
                return respone;
            }
            else
            {
                // Xử lý khi không thành công, ví dụ: trả về null hoặc throw exception
                return null;
            }
        }

		public async Task<roomchat> updateAsync(roomchat roomchat)
		{
			var newstudent = await _httpClient.PostAsJsonAsync("api/Roomchat/Update-Roomchat", roomchat);
			var respone = await newstudent.Content.ReadFromJsonAsync<roomchat>();
			return respone;
		}
	}
}
