using ASPNET02_WepApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET02_WepApp.Data
{
   public class ApplicationDbContext : DbContext
   {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       {
       }

       public DbSet<Board> Boards { get; set; }
   }
}
