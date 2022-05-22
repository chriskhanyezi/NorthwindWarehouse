using Csla;
using Northwind.Business.Logic.BusinessObjects.Suppliers;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Suppliers
{
    [Serializable()]
    public class SupplierList : ReadOnlyListBase<SupplierList, SupplierInfo>
    {
        public void RemoveChild(int supplierId)
        {
            var iro = IsReadOnly;
            IsReadOnly = false;
            try
            {
                var item = this.Where(r => r.Id == supplierId).FirstOrDefault();
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

        public async static Task<SupplierList> GetSupplierListAsync()
        {
            return await DataPortal.FetchAsync<SupplierList>();
        }

        public static SupplierList GetSupplierList()
        {
            return DataPortal.Fetch<SupplierList>();
        }

        public static SupplierList GetSupplierList(string name)
        {
            return DataPortal.Fetch<SupplierList>(name);
        }

        [Fetch]
        private void Fetch([Inject] ISupplierDAL dal)
        {
            Fetch(null, dal);
        }

        [Fetch]
        private void Fetch(string name, [Inject] ISupplierDAL dal)
        {
            using (LoadListMode)
            {
                List<Supplierdto> list = new List<Supplierdto> { new Supplierdto { SupplierID = -1, CompanyName= "Select A Supplier"} };
                if (name == null)
                    list.AddRange(dal.Fetch());
                else
                    list.AddRange(dal.Fetch(name));
                foreach (var item in list)
                    Add(DataPortal.FetchChild<SupplierInfo>(item));
            }
        }
    }
}
