using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataAccessInterface
{
    public interface ICategoryDAL
    {
        List<Categorydto> Fetch();
        List<Categorydto> Fetch(string nameFilter);
        Categorydto Fetch(int id);
        bool Exists(int id);
        void Insert(Categorydto item);
        void Update(Categorydto item);
        void Delete(int id);
    }
}
