using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


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
        public object User { get; internal set; }
    }

}
