using CW19.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepositoryEF.CW19.Db
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext):base(dbContext)
        {
            
        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
