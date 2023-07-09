using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }

        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
