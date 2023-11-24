using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees
{
    public class QuotationsTable
    {
        public string QuoteName { get; set; }
        public double QoutePrice { get; set; }
        public double MaxPrice { get; set; }
        public double MinPrice { get; set; }
        public double Dif { get; set; }
        public double DifPercent { get; set; }
        public uint QuoteCount { get; set; }
        public TimeOnly Time { get; set; }
    }
}
