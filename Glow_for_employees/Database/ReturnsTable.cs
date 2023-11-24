using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees.Database
{
    internal class ReturnsTable
    {
        public ulong ReturnId { get; set; }
        public string ReturnSender { get; set; }
        public ulong Article { get; set; }
        public uint ProductCount { get; set; }
        public DateOnly OrderDate { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnStatus { get; set; }
    }
}
