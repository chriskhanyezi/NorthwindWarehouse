using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataObjects
{
    public class Roledto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] LastChanged { get; set; }
    }
}
