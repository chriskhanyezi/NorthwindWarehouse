using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataObjects
{
    public class Userdto
    {
        public string Username { get; set; }
        public string[] Roles { get; set; }
        public bool Verified { get; set; }
    }
}
