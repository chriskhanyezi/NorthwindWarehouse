using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataAccessInterface
{
    public interface IRoleDal
    {
        List<Roledto> Fetch();
        Roledto Fetch(int id);
        void Insert(Roledto item);
        void Update(Roledto item);
        void Delete(int id);
    }
}
