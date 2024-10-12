using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configuration
{
  public static class ServiceConfigs
  {
    public static void AddCustomServices(this IServiceCollection services, string connectionString)
    {
      services.AddDbContext<ApplicationDbContext>(options =>
          options.UseNpgsql(connectionString));

      // Register other services here as needed
      services.AddControllers();
    }
  }
}