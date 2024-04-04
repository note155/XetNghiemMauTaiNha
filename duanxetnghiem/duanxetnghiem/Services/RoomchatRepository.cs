using duanxetnghiem.Client.Pages.User.DichVu_user;
using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class RoomchatRepository : IRoomchat
    {
        private readonly ApplicationDbContext _context;

        public RoomchatRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<roomchat> addAsync(roomchat roomchat)
        {
            if (roomchat == null) return null;
            var newstudent = _context.Roomchats.Add(roomchat).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

		public async Task<List<roomchat>> getallAsync()
		{
			return await _context.Roomchats.ToListAsync();
		}

		public async Task<List<roomchat>> getallbyidAsync(int id)
        {
            var gioHangs = await _context.Roomchats.Where(g => g.userid == id).ToListAsync();
            return gioHangs;
        }

        public async Task<int> getallbyidbsAsync(int id)
        {
            var count = await _context.Chats
                .Join(_context.Roomchats,
                    c => c.roomchatid,
                    r => r.Id,
                    (c, r) => new { Chat = c, Roomchat = r })
                .Where(x => x.Chat.trangthai == 1 && x.Roomchat.idbs == id)
                .Select(x => x.Roomchat.Id)
                .Distinct()
                .CountAsync();

            return count;
        }

        public async Task<roomchat> getbyidAsync(int id)
        {
            return await _context.Roomchats.FindAsync(id);
        }

		public async Task<roomchat> updateAsync(roomchat roomchat)
		{
			if (roomchat == null) return null;

			var updateuser = _context.Roomchats.Update(roomchat).Entity;

			await _context.SaveChangesAsync();

			return updateuser;
		}
	}
}
