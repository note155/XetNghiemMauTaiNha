using duanxetnghiem.Client.Pages.Admin.GoiXetNghiem;
using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class DonXetNghiemRepository : IDonXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public DonXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<DonXetNghiem> addAsync(DonXetNghiem donXetNghiem)
        {
            if (donXetNghiem == null) return null;
            var newstudent = _context.DonXetNghiems.Add(donXetNghiem).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<DXNandGXN> addnew(DXNandGXN a)
        {
            if (a == null) return null;
            var newstudent = _context.DXNandGXNs.Add(a).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<DonXetNghiem> deleteAsync(int id)
        {
            var donXetNghiemToDelete = await _context.DonXetNghiems.FindAsync(id);
            if (donXetNghiemToDelete != null)
            {
                _context.DonXetNghiems.Remove(donXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return donXetNghiemToDelete;
            }
            return null;
        }

        public async Task<DXNandGXN> deletegxnAsync(int id)
        {
            var donXetNghiemToDelete = await _context.DXNandGXNs.FindAsync(id);
            if (donXetNghiemToDelete != null)
            {
                _context.DXNandGXNs.Remove(donXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return donXetNghiemToDelete;
            }
            return null;
        }

        public async Task<List<DonXetNghiem>> getallAsync()
        {
            return await _context.DonXetNghiems.ToListAsync();
        }

        public async Task<List<DonXetNghiem>> getallbyiduserAsync(int id)
        {
            var gioHangs = await _context.DonXetNghiems.Where(g => g.UserId == id).ToListAsync();
            return gioHangs;
        }

        public async Task<List<DXNandGXN>> getallGXNAsync(int idDXN)
        {
            var gioHangs = await _context.DXNandGXNs.Where(g => g.DonXetNghiemId == idDXN).ToListAsync();
            return gioHangs;
        }

        public async Task<DonXetNghiem> getbyid(int Id)
        {
            return await _context.DonXetNghiems.FindAsync(Id);
        }

        public async Task<DonXetNghiem> updateAsync(DonXetNghiem donXetNghiem)
        {
            if (donXetNghiem == null) return null;

            var updateuser = _context.DonXetNghiems.Update(donXetNghiem).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
    }
}
