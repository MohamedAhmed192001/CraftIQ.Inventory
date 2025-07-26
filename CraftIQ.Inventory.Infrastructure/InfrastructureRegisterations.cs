using CraftIQ.Inventory.Infrastructure.Data;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CraftIQ.Inventory.Infrastructure
{
    public static class InfrastructureRegisterations
    {
        public static void AddInventoryDbContext(this IServiceCollection services, string inventoryConnectionString) =>
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(inventoryConnectionString, 
                b => b.MigrationsAssembly("CraftlQ.Inventory.API")));

        public static void AddInfrastructureRegisterations(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(InventoryRepsitory<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(InventoryRepsitory<>));
        }
    }
}
