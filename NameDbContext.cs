using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace NameDB;

public class NameDbContext : DbContext
{
    public DbSet<NameModel> NameModels { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(Utilities.GetConnectionString(), ServerVersion.AutoDetect(Utilities.GetConnectionString()));
    }
}

