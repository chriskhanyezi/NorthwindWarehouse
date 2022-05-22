﻿using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.DataAccess.DbContexts;
using Northwind.Infrastructure.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.DALEFCore
{
    #region RoleDal
    public class RoleDal : IRoleDal
    {
        private readonly NorthwindContext db;

        public RoleDal(NorthwindContext context)
        {
            db = context;
        }

        public List<Roledto> Fetch()
        {
            var result = from r in db.Roles
                         select new Roledto { Id = r.Id, Name = r.Name, LastChanged = r.LastChanged };
            return result.ToList();
        }

        public Roledto Fetch(int id)
        {
            var result = (from r in db.Roles
                          where r.Id == id
                          select new Roledto { Id = r.Id, Name = r.Name, LastChanged = r.LastChanged }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("Roledto");
            return result;
        }

        public void Insert(Roledto item)
        {
            var newItem = new Role
            {
                Name = item.Name
            };
            db.Roles.Add(newItem);
            db.SaveChanges();
            item.Id = newItem.Id;
            item.LastChanged = newItem.LastChanged;
        }

        public void Update(Roledto item)
        {
            var data = (from r in db.Roles
                        where r.Id == item.Id
                        select r).FirstOrDefault();
            if (data == null)
                throw new DataNotFoundException("Role");
            if (!(data.LastChanged ==item.LastChanged))
                throw new ConcurrencyException("Role");

            data.Name = item.Name;
            var count = db.SaveChanges();
            if (count == 0)
                throw new UpdateFailureException("Role");
            item.LastChanged = data.LastChanged;
        }

        public void Delete(int id)
        {
            var data = (from r in db.Roles
                        where r.Id == id
                        select r).FirstOrDefault();
            if (data != null)
            {
                db.Roles.Remove(data);
                db.SaveChanges();
            }
        }

        #endregion
    }
}
