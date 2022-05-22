using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.DataAccess.DbContexts;
using Northwind.Infrastructure.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.DALEFCore
{
    #region UserDAL
    public class UserDal : IUserDal
    {
      private static readonly List<UserData> Users = new List<UserData>
      {
        new UserData { Username = "manager", Password = "manager", Roles = new string[] { "WarehouseManager" }},
        new UserData { Username = "admin", Password = "admin", Roles = new string[] { "Administrator" }}
      };

        public Userdto Fetch(string username, string password)
        {
            var result = (from r in Users
                          where r.Username == username && r.Password == password
                          select new Userdto { Username = r.Username, Roles = r.Roles }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("User");
            return result;
        }

        public Userdto Fetch(string username)
        {
            var result = (from r in Users
                          where r.Username == username
                          select new Userdto { Username = r.Username, Roles = r.Roles }).FirstOrDefault();
            if (result == null)
                throw new DataNotFoundException("User");
            return result;
        }
    }
    #endregion
}
