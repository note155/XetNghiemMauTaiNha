using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{

    public class ChatRepository : IChat
    {
        private readonly ApplicationDbContext _context;

        public ChatRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Chat> addAsync(Chat chat)
        {
            if (chat == null) return null;
            var newstudent = _context.Chats.Add(chat).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<List<Chat>> getallbyidroomAsync(int id)
        {
            var gioHangs = await _context.Chats.Where(g => g.roomchatid == id).ToListAsync();
            return gioHangs;
        }
    }
}
