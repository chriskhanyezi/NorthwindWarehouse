using Csla;
using Northwind.DataAccess.DataAccessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Suppliers
{
    [Serializable()]
    public class SupplierExistsCommand : CommandBase<SupplierExistsCommand>
    {
        public SupplierExistsCommand()
        { }

        public SupplierExistsCommand(int id)
        {
            SupplierID = id;
        }

        public static readonly PropertyInfo<int> SupplierIDProperty = RegisterProperty<int>(c => c.SupplierID);
        public int SupplierID
        {
            get { return ReadProperty(SupplierIDProperty); }
            private set { LoadProperty(SupplierIDProperty, value); }
        }

        public static readonly PropertyInfo<bool> SupplierExistsProperty = RegisterProperty<bool>(c => c.SupplierExists);
        public bool SupplierExists
        {
            get { return ReadProperty(SupplierExistsProperty); }
            private set { LoadProperty(SupplierExistsProperty, value); }
        }

        [Execute]
        private void Execute([Inject] ISupplierDAL dal)
        {
            SupplierExists = dal.Exists(SupplierID);
        }
    }
}
