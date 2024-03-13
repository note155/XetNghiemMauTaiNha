using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class MayXetNghiemRepository : IMayXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public MayXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<MayXetNghiem>> getallAsync()
        {
            return await _context.Mayxetnghiems.ToListAsync();
        }
    }
}
