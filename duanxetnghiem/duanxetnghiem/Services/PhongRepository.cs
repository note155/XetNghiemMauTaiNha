using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace duanxetnghiem.Services
{
    public class PhongRepository : IPhong
    {
        private readonly ApplicationDbContext _context;

        public PhongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Phong> addAsync(Phong phong)
        {
            if (phong == null)
                throw new ArgumentNullException(nameof(phong));

            var newPhong = _context.Phongs.Add(phong).Entity;
            await _context.SaveChangesAsync();

            return newPhong;
        }

        public async Task<Phong> deleteAsync(int id)
        {
            var phongToDelete = await _context.Phongs.FindAsync(id);
            if (phongToDelete != null)
            {
                _context.Phongs.Remove(phongToDelete);
                await _context.SaveChangesAsync();
                return phongToDelete;
            }
            return null;
        }

        public async Task<List<Phong>> getallAsync()
        {
            return await _context.Phongs.ToListAsync();
        }

        public async Task<Phong> getbyid(int id)
        {
            return await _context.Phongs.FindAsync(id);
        }

        public async Task<Phong> updateAsync(Phong phong)
        {
            if (phong == null)
                throw new ArgumentNullException(nameof(phong));

            var updatedPhong = _context.Phongs.Update(phong).Entity;
            await _context.SaveChangesAsync();

            return updatedPhong;
        }
    }
}
