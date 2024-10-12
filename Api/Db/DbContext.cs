using Microsoft.EntityFrameworkCore;
namespace Api.Models
{
  public partial class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
      AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }
    // Add DbSet properties for other entities as needed
  }
}