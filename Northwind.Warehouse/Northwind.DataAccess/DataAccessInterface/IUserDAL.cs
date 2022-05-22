using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.DataAccessInterface
{
    public interface IUserDal
    {
        Userdto Fetch(string username, string password);
        Userdto Fetch(string username);
    }
}
