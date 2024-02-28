using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace duanxetnghiem.Services
{
    public class ThanhToanRepository : IThanhToan
    {
        private readonly ApplicationDbContext _context;

        public ThanhToanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ThanhToan> addAsync(ThanhToan thanhToan)
        {
            if (thanhToan == null) return null;
            var newThanhToan = _context.thanhToans.Add(thanhToan).Entity;
            await _context.SaveChangesAsync();
            return newThanhToan;
        }

        public async Task<ThanhToan> deleteAsync(int id)
        {
            var thanhToan = await _context.thanhToans.FindAsync(id);
            if (thanhToan == null) return null;

            _context.thanhToans.Remove(thanhToan);
            await _context.SaveChangesAsync();

            return thanhToan;
        }

        public async Task<List<ThanhToan>> getallAsync(int id)
        {
            var thanhToans = await _context.thanhToans.Where(t => t.UserId == id).ToListAsync();
            return thanhToans;
        }

        public async Task<ThanhToan> getbyidDXNAsync(int id)
        {
            return await _context.thanhToans.FirstOrDefaultAsync(t => t.DonXetNghiemId == id);
        }


        public async Task<ThanhToan> updateAsync(ThanhToan thanhToan)
        {
            if (thanhToan == null) return null;

            var updateuser = _context.thanhToans.Update(thanhToan).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
    }
}
