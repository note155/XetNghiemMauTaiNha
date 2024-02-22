using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class TuChoiRepository : ITuChoi
    {
        private readonly ApplicationDbContext _context;

        public TuChoiRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TuChoi> addAsync(TuChoi tuchoi)
        {
            if (tuchoi == null) return null;
            var newstudent = _context.TuChois.Add(tuchoi).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<List<TuChoi>> getallAsync()
        {
            return await _context.TuChois.ToListAsync();
        }
    }
}
