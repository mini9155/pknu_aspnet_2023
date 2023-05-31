using BookReport.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReport.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Story> Stories { get; set; } // 이 줄이 있어야지 Mysql에 데이터가 생성이 된다고 한다
    }
}