using BlazorDatabaseDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDatabaseDemo.Data
{
    public class AppDBContext:DbContext
    {
        public IConfiguration iconfig { get; set; }
        public AppDBContext(IConfiguration config)
        {
            iconfig = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(iconfig.GetConnectionString("DatabaseConnection"));
        }
        public DbSet<Student> Students { get; set; }
    }
}
