using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.DataAccess.DbContexts;
using Northwind.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Infrastructure.Extensions;

namespace Northwind.DALEFCore
{
    #region ProductDAL
    public class ProductDAL : IProductDAL
    {
        private readonly NorthwindContext db;

        public ProductDAL(NorthwindContext context)
        {
            db = context;
        }

        public List<Productdto> Fetch()
        {
            var result = from p in db.Products
                         select new Productdto
                         {
                             ProductID = p.ProductID,
                             ProductName = p.ProductName,
                             SupplierID = p.SupplierID,
                             CategoryID = p.CategoryID,
                             QuantityPerUnit = p.QuantityPerUnit,
                             UnitPrice = p.UnitPrice,
                             UnitsInStock = p.UnitsInStock,
                             UnitsOnOrder = p.UnitsOnOrder,
                             ReorderLevel = p.ReorderLevel,
                             Discontinued = p.Discontinued,
                             LastChanged = p.LastChanged
                         };
            return result.ToList();
        }

        public List<Productdto> Fetch(string nameFilter)
        {
            var result = from p in db.Products
                         where p.ProductName.Contains(nameFilter)
                         select new Productdto
                         {
                             ProductID = p.ProductID,
                             ProductName = p.ProductName,
                             SupplierID = p.SupplierID,
                             CategoryID = p.CategoryID,
                             QuantityPerUnit = p.QuantityPerUnit,
                             UnitPrice = p.UnitPrice,
                             UnitsInStock = p.UnitsInStock,
                             UnitsOnOrder = p.UnitsOnOrder,
                             ReorderLevel = p.ReorderLevel,
                             Discontinued = p.Discontinued,
                             LastChanged = p.LastChanged
                         };
            return result.ToList();
        }

        public Productdto Fetch(int id)
        {
            var result = (from p in db.Products
                          where p.ProductID == id
                          select new Productdto
                          {
                              ProductID = p.ProductID,
                              ProductName = p.ProductName,
                              SupplierID = p.SupplierID,
                              CategoryID = p.CategoryID,
                              QuantityPerUnit = p.QuantityPerUnit,
                              UnitPrice = p.UnitPrice,
                              UnitsInStock = p.UnitsInStock,
                              UnitsOnOrder = p.UnitsOnOrder,
                              ReorderLevel = p.ReorderLevel,
                              Discontinued = p.Discontinued,
                              LastChanged = p.LastChanged
                          }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("Product");
            return result;
        }

        public bool Exists(int id)
        {
            var result = (from p in db.Products
                          where p.ProductID == id
                          select p.ProductID).Count() > 0;
            return result;
        }

        public void Insert(Productdto item)
        {
            var newItem = new Product
            {
                ProductName = item.ProductName,
                SupplierID = item.SupplierID,
                CategoryID = item.CategoryID,
                QuantityPerUnit = item.QuantityPerUnit,
                UnitPrice = item.UnitPrice,
                UnitsInStock = item.UnitsInStock,
                UnitsOnOrder = item.UnitsOnOrder,
                ReorderLevel = item.ReorderLevel,
                Discontinued = item.Discontinued
            };

            db.Products.Add(newItem);
            db.SaveChanges();
            item.ProductID = newItem.ProductID;
            item.LastChanged = newItem.LastChanged;
        }

        public void Update(Productdto item)
        {
            var data = (from p in db.Products
                        where p.ProductID == item.ProductID
                        select p).FirstOrDefault();
            if (data == null)
                throw new DataNotFoundException("Product");
            if (!data.LastChanged.Matches(item.LastChanged))
                throw new ConcurrencyException("Product");

            data.ProductName = item.ProductName;
            data.SupplierID = item.SupplierID;
            data.CategoryID = item.CategoryID;
            data.QuantityPerUnit = item.QuantityPerUnit;
            data.UnitPrice = item.UnitPrice;
            data.UnitsInStock = item.UnitsInStock;
            data.UnitsOnOrder = item.UnitsOnOrder;
            data.ReorderLevel = item.ReorderLevel;
            data.Discontinued = item.Discontinued;

            var count = db.SaveChanges();
            item.LastChanged = data.LastChanged;
        }

        public void Delete(int id)
        {
            var data = (from p in db.Products
                        where p.ProductID == id
                        select p).FirstOrDefault();
            if (data != null)
            {
                db.Products.Remove(data);
                db.SaveChanges();
            }
        }
    }
    #endregion
}
