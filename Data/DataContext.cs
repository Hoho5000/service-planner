using Microsoft.EntityFrameworkCore;
using ServicePlanner.Data.Music;
using ServicePlanner.Data.Service;

namespace ServicePlanner.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Service.Service> Services { get; set; }

        private string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "data.db");

            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().ToTable("Songs");
            modelBuilder.Entity<GeneralServiceItem>().ToTable("GeneralServiceItems");
        }
    }
}
