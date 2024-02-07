using System.Net.Http.Json;
using duanxetnghiem.Data.Model;
using Shared.form;
using Shared.ketnoi;

namespace duanxetnghiem.Client.Services
{
    public class UserServices : IUser
    {
        private readonly HttpClient _httpClient;
        public UserServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<int> adduserAsync(User user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Add-User", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<int>();
            return respone;
        }
       
        public async Task<User> deleteuserAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Delete-User", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }

        public async Task<List<User>> getalluserAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Studen/All-User");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<User>>();
            return respone;
        }

        public async Task<User> getuserbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/Studen/Single-User");
            var respone = await onestudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }

        public async Task<int> IsUserExistsAsync(User user)
        {
            var allstudent = await _httpClient.PostAsJsonAsync("api/Studen/EmailExists", user);
            var respone = await allstudent.Content.ReadFromJsonAsync<int>();
            return respone;
        }

        public async Task<bool> login(loginform user)
        {
            var allstudent = await _httpClient.PostAsJsonAsync("api/Studen/login",user);
            var respone = await allstudent.Content.ReadFromJsonAsync<bool>();
            if (respone)
            {
               

            }
            return respone;
        }

        public async Task<User> updateuserAsync(User User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Update-User", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }
    }
}
