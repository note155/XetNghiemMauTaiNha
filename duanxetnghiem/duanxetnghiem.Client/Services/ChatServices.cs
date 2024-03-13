namespace duanxetnghiem.Client.Services
{
    public class ChatServices
    {
        private readonly HttpClient _httpClient;
        public ChatServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
    }
}
