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

        public Task<roomchat> addAsync(roomchat roomchat)
        {
            throw new NotImplementedException();
        }

        public Task<List<roomchat>> getallbyidAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<roomchat> getbyidAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
