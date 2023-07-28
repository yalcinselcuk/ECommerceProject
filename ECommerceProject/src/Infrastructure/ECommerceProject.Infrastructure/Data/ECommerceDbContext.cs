using ECommerceProject.Entities;
using ECommerceProject.Infrastructure.Data.DbSeedings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Infrastructure.Data
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());                                                                                                                                                              
        }
    }
}
