using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class ChisoRepository : IChiso
    {
        private readonly ApplicationDbContext _context;

        public ChisoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Chiso>> getallAsync()
        {
            return await _context.chisos.ToListAsync();
        }
    }
}
