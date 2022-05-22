using Csla;
using Northwind.DataAccess.DataAccessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Products
{
    [Serializable()]
    public class ProductExistsCommand : CommandBase<ProductExistsCommand>
    {
        public ProductExistsCommand()
        { }

        public ProductExistsCommand(int id)
        {
            ProductID = id;
        }

        public static readonly PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
        public int ProductID
        {
            get { return ReadProperty(ProductIDProperty); }
            private set { LoadProperty(ProductIDProperty, value); }
        }

        public static readonly PropertyInfo<bool> ProductExistsProperty = RegisterProperty<bool>(c => c.ProductExists);
        public bool ProductExists
        {
            get { return ReadProperty(ProductExistsProperty); }
            private set { LoadProperty(ProductExistsProperty, value); }
        }

        [Execute]
        private void Execute([Inject] IProductDAL dal)
        {
            ProductExists = dal.Exists(ProductID);
        }
    }
}
