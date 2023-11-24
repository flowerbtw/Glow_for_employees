using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees.Database
{
    internal class OrdersTable
    {
        public ulong OrderId { get; set; }
        public string Customer { get; set; }
        public ulong Article { get; set; }
        public uint ProductCount { get; set; }
        public double OrderPrice { get; set; }
        public string OrderMessage { get; set; }
        public DateOnly OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
