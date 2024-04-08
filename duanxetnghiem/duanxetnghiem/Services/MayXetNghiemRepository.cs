using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace duanxetnghiem.Services
{
    public class MayXetNghiemRepository : IMayXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public MayXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MayXetNghiem> addAsync(MayXetNghiem may)
        {
            if (may == null)
                throw new ArgumentNullException(nameof(may));

            var newMay = _context.Mayxetnghiems.Add(may).Entity;
            await _context.SaveChangesAsync();

            return newMay;
        }

        public async Task<MayXetNghiem> deleteAsync(int id)
        {
            var mayToDelete = await _context.Mayxetnghiems.FindAsync(id);
            if (mayToDelete != null)
            {
                _context.Mayxetnghiems.Remove(mayToDelete);
                await _context.SaveChangesAsync();
                return mayToDelete;
            }
            return null;
        }

        public async Task<List<MayXetNghiem>> getallAsync()
        {
            return await _context.Mayxetnghiems.ToListAsync();
        }

        public async Task<MayXetNghiem> getbyid(int id)
        {
            return await _context.Mayxetnghiems.FindAsync(id);
        }

        public async Task<MayXetNghiem> updateAsync(MayXetNghiem may)
        {
            if (may == null)
                throw new ArgumentNullException(nameof(may));

            var updatedMay = _context.Mayxetnghiems.Update(may).Entity;
            await _context.SaveChangesAsync();

            return updatedMay;
        }
    }
}
