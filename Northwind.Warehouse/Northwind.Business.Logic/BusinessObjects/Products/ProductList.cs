using Csla;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Products
{
    [Serializable()]
    public class ProductList : ReadOnlyListBase<ProductList, ProductInfo>
    {
        public void RemoveChild(int projectId)
        {
            var iro = IsReadOnly;
            IsReadOnly = false;
            try
            {
                var item = this.Where(r => r.Id == projectId).FirstOrDefault();
                if (item != null)
                {
                    var index = this.IndexOf(item);
                    Remove(item);
                }
            }
            finally
            {
                IsReadOnly = iro;
            }
        }

        public async static Task<ProductList> GetProductListAsync()
        {
            return await Csla.DataPortal.FetchAsync<ProductList>();
        }

        public static ProductList GetProductList()
        {
            return DataPortal.Fetch<ProductList>();
        }

        public static ProductList GetProductList(string name)
        {
            return DataPortal.Fetch<ProductList>(name);
        }

        [Fetch]
        private void Fetch([Inject] IProductDAL dal)
        {
            Fetch(null, dal);
        }

        [Fetch]
        private void Fetch(string name, [Inject] IProductDAL dal)
        {
            using (LoadListMode)
            {
                List<Productdto> list = null;
                if (name == null)
                    list = dal.Fetch();
                else
                    list = dal.Fetch(name);
                foreach (var item in list)
                    Add(DataPortal.FetchChild<ProductInfo>(item));
            }
        }
    }
}
