using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class TinhgtrangRepository : ITinhtrang
    {
        private readonly ApplicationDbContext _context;

        public TinhgtrangRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tinhtrang> addAsync(Tinhtrang tinhtrang)
        {
            if (tinhtrang == null) return null;
            var newstudent = _context.Tinhtrangs.Add(tinhtrang).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<List<Tinhtrang>> getbyidAsync(int iddon)
        {
            return await _context.Tinhtrangs.Where(g => g.DonXetNghiemId == iddon).ToListAsync();
        }
    }
}
