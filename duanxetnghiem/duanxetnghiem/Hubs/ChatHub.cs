using Microsoft.AspNetCore.SignalR;

namespace duanxetnghiem.Hubs
{
    public class ChatHub:Hub
    {
		public async Task SendMessage(string user, string message, int roomid)
		{
			await Clients.Group(roomid.ToString()).SendAsync("ReceiveMessage", user, message);
		}

		public async Task AddToRoom(string user, int roomid)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, roomid.ToString());
		}

	}
}
