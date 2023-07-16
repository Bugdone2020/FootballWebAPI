using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Client> Clients { get; set; }

        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
