using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees.Database
{
    internal class StorageTable
    {
        public ulong ProductId { get; set; }
        public string ProductName { get; set; }
        public ulong Article { get; set; }
        public string Color { get; set; }
        public uint ProductCount { get; set; }
        public double ProductPrice { get; set; }
        public string Supplier { get; set; }
        public DateTime Arrival { get; set; }
    }
}
