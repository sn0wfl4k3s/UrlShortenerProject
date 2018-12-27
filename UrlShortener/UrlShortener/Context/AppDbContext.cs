using Microsoft.EntityFrameworkCore;
using UrlShortener.Models;

namespace UrlShortener.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt) { }

        public DbSet<URL> URLs { get; set; }
    }
}
