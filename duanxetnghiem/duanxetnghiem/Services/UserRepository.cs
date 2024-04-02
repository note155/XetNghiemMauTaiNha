using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.form;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> adduserAsync(User user)
        {
            if (user == null) return -1; // hoặc giá trị đặc biệt để biểu thị lỗi

            var newuser = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();

            return newuser.Id;
        }

        public async Task<User> deleteuserAsync(int id)
        {
            var user = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (user == null) return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<List<User>> getalluserAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> getuserbyid(int Id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<User> updateuserAsync(User updatedUser)
        {

            if (updatedUser == null) return null;

            var updateuser = _context.Users.Update(updatedUser).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
        public async Task<int> IsUserExistsAsync(User user)
        {
            if (user == null) return -1;

            var existingUser = await _context.Users.FirstOrDefaultAsync(x =>
                x.Email == user.Email
                && x.Hoten == user.Hoten
                && x.SDT == user.SDT
                && x.Diachi == user.Diachi
                && x.Ngaysinh == user.Ngaysinh
                && x.Gioitinh == user.Gioitinh
            );
            return existingUser?.Id ?? -1;
        }

        public async Task<User> getuserbyemail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(b => b.Email == email);
        }

        public async Task<List<User>> getalluserbyemailAsync(string email)
        {
            var gioHangs = await _context.Users.Where(g => g.Email == email).ToListAsync();
            return gioHangs;
        }
    }
}
