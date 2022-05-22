using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.DataAccess.DbContexts;
using Northwind.Infrastructure.Exceptions;
using System.Collections.Generic;
using System.Linq;
using Northwind.Infrastructure.Extensions;

namespace Northwind.DALEFCore
{
    #region CategoryDAL

    public class CategoryDAL : ICategoryDAL
    {
        private readonly NorthwindContext db;

        public CategoryDAL(NorthwindContext context)
        {
            db = context;
        }

        public List<Categorydto> Fetch()
        {
            var result = from c in db.Categories
                         select new Categorydto
                         {
                             CategoryID = c.CategoryID,
                             CategoryName = c.CategoryName,
                             Description = c.Description,
                             Picture = c.Picture,
                             LastChanged = c.LastChanged
                         };
            return result.ToList();
        }

        public List<Categorydto> Fetch(string nameFilter)
        {
            var result = from c in db.Categories
                         where c.CategoryName.Contains(nameFilter)
                         select new Categorydto
                         {
                             CategoryID = c.CategoryID,
                             CategoryName = c.CategoryName,
                             Description = c.Description,
                             Picture = c.Picture,
                             LastChanged = c.LastChanged
                         };
            return result.ToList();
        }

        public Categorydto Fetch(int id)
        {
            var result = (from c in db.Categories
                          where c.CategoryID == id
                          select new Categorydto
                          {
                              CategoryID = c.CategoryID,
                              CategoryName = c.CategoryName,
                              Description = c.Description,
                              Picture = c.Picture,
                              LastChanged = c.LastChanged
                          }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("Category");
            return result;
        }

        public bool Exists(int id)
        {
            var result = (from c in db.Categories
                          where c.CategoryID == id
                          select c.CategoryID).Count() > 0;
            return result;
        }

        public void Insert(Categorydto item)
        {
            var newItem = new Category
            {
                CategoryName = item.CategoryName,
                Description = item.Description,
                Picture = item.Picture
            };
            db.Categories.Add(newItem);
            db.SaveChanges();
            item.CategoryID = newItem.CategoryID;
            item.LastChanged = newItem.LastChanged;
        }

        public void Update(Categorydto item)
        {
            var data = (from c in db.Categories
                        where c.CategoryID == item.CategoryID
                        select c).FirstOrDefault();
            if (data == null)
                throw new DataNotFoundException("Category");
            if (!data.LastChanged.Matches(item.LastChanged))
                throw new ConcurrencyException("Category");

            data.CategoryName = item.CategoryName;
            data.Description = item.Description;
            data.Picture = item.Picture;
            var count = db.SaveChanges();
            item.LastChanged = data.LastChanged;
        }

        public void Delete(int id)
        {
            var data = (from c in db.Categories
                        where c.CategoryID == id
                        select c).FirstOrDefault();
            if (data != null)
            {
                db.Categories.Remove(data);
                db.SaveChanges();
            }
        }
    }
    #endregion
}
