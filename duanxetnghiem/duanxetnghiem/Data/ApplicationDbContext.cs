using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.Model;


namespace duanxetnghiem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        internal object user;

        public DbSet<User> Users { get; set; }
        public DbSet<BacSi> BacSis { get; set; }
        public DbSet<GoiXetNghiem> GoiXetNghiems { get; set; }
        public DbSet<DonXetNghiem> DonXetNghiems { get; set; }
        public DbSet<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }
        public DbSet<TuChoi> TuChois { get; set; }
		public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<ThanhToan> thanhToans { get; set; }
        public DbSet<DXNandGXN> DXNandGXNs { get; set; }
        public object User { get; internal set; }
    }

}
