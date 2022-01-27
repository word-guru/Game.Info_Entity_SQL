using Microsoft.EntityFrameworkCore;
using Game.Model;

namespace Game.DB.Lib
{
    public class GamesDB:DbContext
    {
        public DbSet<Games> TableGames { get; set; }

        public GamesDB()
        {
            Database.EnsureCreated();
        }
        private static string GetConnectionString(string path)
        {
            return File.ReadAllText(path);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString("connection_to_db.txt"));
        }
    }
}