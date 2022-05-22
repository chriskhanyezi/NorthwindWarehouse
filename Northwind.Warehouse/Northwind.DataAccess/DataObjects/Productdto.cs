using System;

namespace Northwind.DataAccess.DataObjects
{
    public class Productdto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Int32? SupplierID { get; set; }
        public Int32? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public byte[] LastChanged { get; set; }
    }
}
