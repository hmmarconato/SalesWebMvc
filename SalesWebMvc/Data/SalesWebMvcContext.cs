using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using System.Reflection.Metadata;

namespace SalesWebMvc.Data
{
    
    
    
    
    public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().Property(a => a.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<SalesRecord>().Property(b => b.Id).UseIdentityAlwaysColumn();
            modelBuilder.Entity<Department>().Property(c => c.Id).UseIdentityAlwaysColumn();
        }

    }

}
