
using Microsoft.Extensions.DependencyInjection;
using Northwind.DataAccess.DataAccessInterface;

namespace Northwind.DALADO.NET
{
    /// <summary>
    /// Configuration extension methods
    /// </summary>
    public static class ConfigurationExtensions
    {
        public static void AddADONetDAL(this IServiceCollection services)
        {
            services.AddTransient<ICategoryDAL, CategoryADONetDAL>();
            services.AddTransient<IProductDAL, ProductADONetDAL>();
            //services.AddTransient<IRoleDal, RoleDal>();
            services.AddTransient<ISupplierDAL, SupplierADONetDAL>();
            services.AddTransient<IUserDal, UserADONetDAL>();
        }
    }
}
