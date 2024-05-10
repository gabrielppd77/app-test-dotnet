using FirstApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.DataBase
{
  public class PgContext : DbContext
  {
    public DbSet<FirstModel> FirstModel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(@"Host=localhost:5432;Username=postgres;Password=1234567;Database=first-app");
      base.OnConfiguring(optionsBuilder);
    }
  }
};