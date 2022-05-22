using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataAccessInterface
{
    public interface IProductDAL
    {
        List<Productdto> Fetch();
        List<Productdto> Fetch(string nameFilter);
        Productdto Fetch(int id);
        bool Exists(int id);
        void Insert(Productdto item);
        void Update(Productdto item);
        void Delete(int id);
    }
}
