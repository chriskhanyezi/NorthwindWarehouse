using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataAccessInterface
{
    public interface ISupplierDAL
    {
        List<Supplierdto> Fetch();
        List<Supplierdto> Fetch(string nameFilter);
        Supplierdto Fetch(int id);
        bool Exists(int id);
        void Insert(Supplierdto item);
        void Update(Supplierdto item);
        void Delete(int id);
    }
}
