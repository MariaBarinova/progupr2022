
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Praktica;

public class ApplicationContext : DbContext
{


    public DbSet<Client>? Client { get; set; }
    public DbSet<Contract>? Contracts { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("json1.json");
        var config = builder.Build();
        string connectionString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
    
}