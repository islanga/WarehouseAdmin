using System;

namespace WarehouseAdmin.Models
{
    public class Products
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        public string QuantityPerUnit { get; set; } = string.Empty;

        public decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }

        public Int16 UnitsOnOrder { get; set; }

        public Int16 ReorderLevel { get; set; }

        public Boolean Discontinued { get; set; }
    }
}
