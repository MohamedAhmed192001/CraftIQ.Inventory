using huzcodes.Persistence.Implementations.EfRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Infrastructure.Data
{
    public class InventoryRepsitory<TEntity> : HuzcodesRepository<TEntity> where TEntity : class
    {
        public InventoryRepsitory(AppDbContext dbContext): base(dbContext) { }




    }
}
