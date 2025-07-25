using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities
{
    public class Order : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public int Status { get; set; }
        public int OrderType { get; set; }

        public DateTimeOffset ExpectedDeliveryDate { get; set; }
        public DateTimeOffset ReseivedDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
