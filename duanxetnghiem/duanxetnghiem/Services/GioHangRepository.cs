using System.Linq;
using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
	public class GioHangRepository : IGioHang
	{
		private readonly ApplicationDbContext _context;

		public GioHangRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<GioHang> addAsync(GioHang Giohang)
		{
			if (Giohang == null) return null;
			var newGioHang = _context.GioHangs.Add(Giohang).Entity;
			await _context.SaveChangesAsync();
			return newGioHang;
		}
        public async Task<GioHang> updateAsync(GioHang Giohang)
        {
            if (Giohang == null) return null;

            var updateuser = _context.GioHangs.Update(Giohang).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
        public async Task<GioHang> deleteAsync(int id)
		{
			var gioHangToDelete = await _context.GioHangs.FindAsync(id);
			if (gioHangToDelete == null) return null;
			_context.GioHangs.Remove(gioHangToDelete);
			await _context.SaveChangesAsync();
			return gioHangToDelete;
		}

		public async Task<List<GioHang>> getallAsyncbyiduser(int iduser)
		{
			var gioHangs = await _context.GioHangs.Where(g => g.UserId == iduser).ToListAsync();
			return gioHangs;
		}

        public async Task<List<GioHang>> getallistrue(int iduser)
        {
            var gioHangs = await _context.GioHangs
                                        .Where(g => g.UserId == iduser && (g.IsSelected == true || g.IsSelected == null))
                                        .ToListAsync();
            return gioHangs;
        }

        public async Task<bool> kiemtra(GioHang Giohang)
        {
            var exists = await _context.GioHangs.AnyAsync(g => g.GoiXetNghiemId == Giohang.GoiXetNghiemId && g.UserId == Giohang.UserId);
            return exists;
        }
    }
}
