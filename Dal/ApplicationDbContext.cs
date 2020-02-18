using Bolt.Model;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace Bolt.Dal
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions options) : base(options)
        { }

        public DbSet<Aru> Arucikkek { get; set; }
    }
}
