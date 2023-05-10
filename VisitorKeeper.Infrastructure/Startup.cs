using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VisitorKeeper.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace VisitorKeeper.Infrastructure;
public static class Startup
{
    public static IServiceCollection AddVisitorKeeperInfrastructure(this IServiceCollection services)
    {        
        services.AddDbContext<DefaultDbContext>((serv, opt) =>
        {
            string connectionString = serv.GetRequiredService<IConfiguration>().GetConnectionString("Default")!;
            opt.UseSqlServer(connectionString);
        });

        return services;
    }
}
