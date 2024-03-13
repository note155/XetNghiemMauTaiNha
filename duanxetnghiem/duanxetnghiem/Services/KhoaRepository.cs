using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class KhoaRepository : IKhoa
    {
        private readonly ApplicationDbContext _context;

        public KhoaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Khoa>> getallAsync()
        {
            return await _context.Khoas.ToListAsync();
        }
    }
}
