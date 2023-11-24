using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees.Database
{
    internal class UsersTable
    {
        public string Role { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
