using Bolt.Model;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace Bolt.Dal
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Itt kell majd neked átírni a gép IP címét meg a felhasználónév-jelszó párost
            optionsBuilder.UseSqlServer("Server=152.66.176.212,1433; Database=BoltDB; User ID=sa; password=Password123");
        }

        public DbSet<Aru> Arucikkek { get; set; }
    }
}
