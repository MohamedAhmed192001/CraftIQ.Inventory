using CraftIQ.Inventory.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CraftIQ.Inventory.Infrastructure
{
    public static class InfrastructureRegisterations
    {
        public static void AddInventoryDbContext(this IServiceCollection services, string inventoryConnectionString) =>
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(inventoryConnectionString, 
                b => b.MigrationsAssembly("CraftIQ.Inventory.Infrastructure")));
    }
}
