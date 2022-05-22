using Csla.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Northwind.DALADO.NET
{
    #region UserDAL
    public class UserADONetDAL : IUserDal
    {
        public IConfiguration Configuration { get; }
        public UserADONetDAL(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Userdto Fetch(string username, string password)
        {
            var _user = new Userdto
            {
                Username = username,
                Verified = VerifyUser(username, password),
                Roles = GetRoles(username)
            };

            return _user;
        }

        private bool VerifyUser(string username, string password) 
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("SecurityConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.UserLogin", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", String.IsNullOrEmpty(username) ? (object)DBNull.Value : username).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@pw", String.IsNullOrEmpty(password) ? (object)DBNull.Value : password).DbType = DbType.String;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            return username == dr.GetString("Username");
                        }
                    }
                }
            }
            return false;
        }
        private string[] GetRoles(string username)
        {
            List<string> _roles = new List<string>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("SecurityConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetUserRoles", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", String.IsNullOrEmpty(username) ? (object)DBNull.Value : username).DbType = DbType.String;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            string role = dr.GetString("Role");

                            if (!String.IsNullOrEmpty(role))
                            {
                                _roles.Add(role);
                            }
                        }
                    }
                }
            }

            if (_roles.Count() > 0)
            {
                return _roles.ToArray();
            }
            return null;
        }


        public Userdto Fetch(string username)
        {
            //var result = (from r in Users
            //              where r.Username == username
            //              select new Userdto { Username = r.Username, Roles = r.Roles }).FirstOrDefault();
            //if (result == null)
            //    throw new DataNotFoundException("User");
            //return result;
            return null;
        }

    }
    #endregion
}
