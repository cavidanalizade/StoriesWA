using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class AppDBC:DbContext
    {
        public AppDBC(DbContextOptions<AppDBC> options):base(options)
        {
            
        }
        public DbSet<Image> Images { get; set; }

    }
}
