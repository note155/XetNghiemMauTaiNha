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

        public async Task<List<roomchat>> getallbyidAsync(int id)
        {
            var gioHangs = await _context.Roomchats.Where(g => g.userid == id).ToListAsync();
            return gioHangs;
        }

        public async Task<roomchat> getbyidAsync(int id)
        {
            return await _context.Roomchats.FindAsync(id);
        }
    }
}
