using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.DataAccess.DbContexts;
using Northwind.Infrastructure.Exceptions;
using System.Collections.Generic;
using System.Linq;
using Northwind.Infrastructure.Extensions;

namespace Northwind.DALEFCore
{
    #region SupplierDAL
    public class SupplierDAL : ISupplierDAL
    {
        private readonly NorthwindContext db;

        public SupplierDAL(NorthwindContext context)
        {
            db = context;
        }

        public List<Supplierdto> Fetch()
        {
            var result = from s in db.Suppliers
                         select new Supplierdto
                         {
                             SupplierID = s.SupplierID,
                             CompanyName = s.CompanyName,
                             ContactName = s.ContactName,
                             ContactTitle = s.ContactTitle,
                             Address = s.Address,
                             City = s.City,
                             Region = s.Region,
                             PostalCode = s.PostalCode,
                             Country = s.Country,
                             Phone = s.Phone,
                             Fax = s.Fax,
                             HomePage = s.HomePage,
                             LastChanged = s.LastChanged
                         };
            return result.ToList();
        }

        public List<Supplierdto> Fetch(string nameFilter)
        {
            var result = from s in db.Suppliers
                         where s.CompanyName.Contains(nameFilter)
                         select new Supplierdto
                         {
                             SupplierID = s.SupplierID,
                             CompanyName = s.CompanyName,
                             ContactName = s.ContactName,
                             ContactTitle = s.ContactTitle,
                             Address = s.Address,
                             City = s.City,
                             Region = s.Region,
                             PostalCode = s.PostalCode,
                             Country = s.Country,
                             Phone = s.Phone,
                             Fax = s.Fax,
                             HomePage = s.HomePage,
                             LastChanged = s.LastChanged
                         };
            return result.ToList();
        }

        public Supplierdto Fetch(int id)
        {
            var result = (from s in db.Suppliers
                          where s.SupplierID == id
                          select new Supplierdto
                          {
                              SupplierID = s.SupplierID,
                              CompanyName = s.CompanyName,
                              ContactName = s.ContactName,
                              ContactTitle = s.ContactTitle,
                              Address = s.Address,
                              City = s.City,
                              Region = s.Region,
                              PostalCode = s.PostalCode,
                              Country = s.Country,
                              Phone = s.Phone,
                              Fax = s.Fax,
                              HomePage = s.HomePage,
                              LastChanged = s.LastChanged
                          }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("Supplier");
            return result;
        }

        public bool Exists(int id)
        {
            var result = (from s in db.Suppliers
                          where s.SupplierID == id
                          select s.SupplierID).Count() > 0;
            return result;
        }

        public void Insert(Supplierdto item)
        {
            var newItem = new Supplier
            {
                CompanyName = item.CompanyName,
                ContactName = item.ContactName,
                ContactTitle = item.ContactTitle,
                Address = item.Address,
                City = item.City,
                Region = item.Region,
                PostalCode = item.PostalCode,
                Country = item.Country,
                Phone = item.Phone,
                Fax = item.Fax,
                HomePage = item.HomePage
            };

            db.Suppliers.Add(newItem);
            db.SaveChanges();
            item.SupplierID = newItem.SupplierID;
            item.LastChanged = newItem.LastChanged;
        }

        public void Update(Supplierdto item)
        {
            var data = (from s in db.Suppliers
                        where s.SupplierID == item.SupplierID
                        select s).FirstOrDefault();
            if (data == null)
                throw new DataNotFoundException("Supplier");
            if (!data.LastChanged.Matches(item.LastChanged))
                throw new ConcurrencyException("Supplier");

            data.CompanyName = item.CompanyName;
            data.ContactName = item.ContactName;
            data.ContactTitle = item.ContactTitle;
            data.Address = item.Address;
            data.City = item.City;
            data.Region = item.Region;
            data.PostalCode = item.PostalCode;
            data.Country = item.Country;
            data.Phone = item.Phone;
            data.Fax = item.Fax;
            data.HomePage = item.HomePage;
         
            var count = db.SaveChanges();
            item.LastChanged = data.LastChanged;
        }

        public void Delete(int id)
        {
            var data = (from s in db.Suppliers
                        where s.SupplierID == id
                        select s).FirstOrDefault();
            if (data != null)
            {
                db.Suppliers.Remove(data);
                db.SaveChanges();
            }
        }
    }
    #endregion
}
