using Microsoft.EntityFrameworkCore;
using test_course.Entities;

namespace test_course.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
    }
}
