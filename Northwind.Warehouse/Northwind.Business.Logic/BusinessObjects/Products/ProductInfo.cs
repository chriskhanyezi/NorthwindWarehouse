using Csla;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Products
{
    [Serializable()]
    public class ProductInfo : ReadOnlyBase<ProductInfo>
    {
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        [Display(Name = "Product id")]
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        [Display(Name = "Product name")]
        public string Name
        {
            get { return GetProperty(NameProperty); }
            private set { LoadProperty(NameProperty, value); }
        }

        public void SetName(ProductEdit item)
        {
            Name = item.ProductName;
            OnPropertyChanged(NameProperty);
        }

        public override string ToString()
        {
            return Name;
        }

        [FetchChild]
        private void Fetch(Productdto item)
        {
            Id = item.ProductID;
            Name = item.ProductName;
        }
}
}
