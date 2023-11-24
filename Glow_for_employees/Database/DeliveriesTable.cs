using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees
{
    public partial class DeliveriesTable
    {
        public ulong DeliveryId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public uint ProductCount { get; set; }
        public double DeliveryPrice { get; set; }
        public string Supplier { get; set; }
        public DateTime Arrival { get; set; }
        public string ContactData { get; set; }
    }
}
