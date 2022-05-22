namespace Northwind.DataAccess.DataObjects
{
    public class Categorydto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public byte[] LastChanged { get; set; }
    }
}
