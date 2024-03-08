using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class MauRepository : IMau
    {
        private readonly ApplicationDbContext _context;

        public MauRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Mau> addAsync(Mau mau)
        {
            if (mau == null) return null;
            var newstudent = _context.Maus.Add(mau).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<List<Mau>> getallAsync()
        {
            return await _context.Maus.ToListAsync();
        }

        public async Task<Mau> getbyid(int Id)
        {
            var gioHangs = await _context.Maus.FirstOrDefaultAsync(g => g.DonXetNghiemId == Id);
            return gioHangs;
        }

        public async Task<Mau> updateAsync(Mau mau)
        {
            {
                if (mau == null) return null;

                var updatemau = _context.Maus.Update(mau).Entity;

                await _context.SaveChangesAsync();

                return updatemau;
            }
        }
    }
}
