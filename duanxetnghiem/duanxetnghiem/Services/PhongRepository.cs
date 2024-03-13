using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class PhongRepository : IPhong
    {
        private readonly ApplicationDbContext _context;

        public PhongRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Phong>> getallAsync()
        {
            return await _context.Phongs.ToListAsync();
        }
    }
}
