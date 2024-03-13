using System.Net.Http.Json;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class ChatServices : IChat
    {
        private readonly HttpClient _httpClient;
        public ChatServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<Chat> addAsync(Chat chat)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Chat/Add-Chat", chat);
            var respone = await newstudent.Content.ReadFromJsonAsync<Chat>();
            return respone;
        }

        public async Task<List<Chat>> getallbyidroomAsync(int id)
        {
            var allstudent = await _httpClient.GetAsync($"api/Chat/All-Chatbyidroom/{id}");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<Chat>>();
            return respone;
        }
    }
}
