using System;
using Microsoft.EntityFrameworkCore;

namespace MainProgram
{
    public class DevContext : DbContext
    {
        public DbSet<Dev> Dev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DB/Dev.db");
        }
    }
}
