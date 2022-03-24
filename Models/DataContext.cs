using Microsoft.EntityFrameworkCore;

namespace Japanese_C_dang_iu.Models
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
  }
}