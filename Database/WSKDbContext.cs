using BlazorServerSide.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSide.Database
{
    public class WSKDbContext : DbContext
    {
        public WSKDbContext(DbContextOptions<WSKDbContext> options) : base(options)
        { }

        public DbSet<WSK> WSKs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<WSK>().HasData(
            //    new WSK(1954, null, null, null, null, 1, 40),
            //    new WSK(1955, 173, 1288, 42515, 57831, 40, 3166),
            //    new WSK(1956, 2326, 17882, 70799, 115144, 3167, 10279),
            //    new WSK(1957,18103,45445,113357,178145),
            //    new WSK(1958,40514,83532,171137,236338,44670,80671),
            //    new WSK(1959,84194,126763,192369,251375,80672,122763,0,71860),
            //    new WSK(1960,132985,212064,null,null,122764,170764));
        }
    }
}
