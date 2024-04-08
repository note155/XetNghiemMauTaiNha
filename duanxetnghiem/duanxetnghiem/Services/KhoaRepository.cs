using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace duanxetnghiem.Services
{
    public class KhoaRepository : IKhoa
    {
        private readonly ApplicationDbContext _context;

        public KhoaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Khoa> addAsync(Khoa khoa)
        {
            if (khoa == null)
                throw new ArgumentNullException(nameof(khoa));

            var newKhoa = _context.Khoas.Add(khoa).Entity;
            await _context.SaveChangesAsync();

            return newKhoa;
        }

        public async Task<Khoa> deleteAsync(int id)
        {
            var khoaToDelete = await _context.Khoas.FindAsync(id);
            if (khoaToDelete != null)
            {
                _context.Khoas.Remove(khoaToDelete);
                await _context.SaveChangesAsync();
                return khoaToDelete;
            }
            return null;
        }

        public async Task<List<Khoa>> getallAsync()
        {
            return await _context.Khoas.ToListAsync();
        }

        public async Task<Khoa> getbyid(int id)
        {
            return await _context.Khoas.FindAsync(id);
        }

        public async Task<Khoa> updateAsync(Khoa khoa)
        {
            if (khoa == null)
                throw new ArgumentNullException(nameof(khoa));

            var updatedKhoa = _context.Khoas.Update(khoa).Entity;
            await _context.SaveChangesAsync();

            return updatedKhoa;
        }
    }
}
