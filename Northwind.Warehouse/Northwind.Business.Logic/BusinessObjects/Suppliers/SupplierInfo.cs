using Csla;
using Northwind.Business.Logic.Suppliers;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.BusinessObjects.Suppliers
{
    [Serializable()]
    public class SupplierInfo : ReadOnlyBase<SupplierInfo>
    {
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        [Display(Name = "Supplier id")]
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        [Display(Name = "Supplier name")]
        public string Name
        {
            get { return GetProperty(NameProperty); }
            private set { LoadProperty(NameProperty, value); }
        }

        public void SetName(SupplierEdit item)
        {
            Name = item.CompanyName;
            OnPropertyChanged(NameProperty);
        }

        public override string ToString()
        {
            return Name;
        }

        [FetchChild]
        private void Fetch(Supplierdto item)
        {
            Id = item.SupplierID;
            Name = item.CompanyName;
        }
}
}
