using System;
using System.Security.Claims;
using Csla;

namespace Northwind.Business.Logic.Security
{
    public static class PTPrincipal
    {
        public static event Action NewUser;

        public static bool Login(string username, string password)
        {
            try
            {
                var credentials = DataPortal.Create<Credentials>(username, password);
                var validator = DataPortal.Fetch<CredentialValidator>(credentials);

                if (validator.Verified)
                {
                    var principal = validator.GetPrincipal();
                    ApplicationContext.User = principal;
                    NewUser?.Invoke();

                    return true;
                }
                return false;
            }
            catch
            {
                //Logout();
                return false;
            }
        }

        public static void Logout()
        {
            Csla.ApplicationContext.User = new ClaimsPrincipal(new ClaimsIdentity());
            NewUser?.Invoke();
        }
    }
}
