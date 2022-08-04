using System.ComponentModel.DataAnnotations;

namespace WarehouseAdminAPI.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Supplier ID is required")]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Quantity Per Unit is required")]
        public string QuantityPerUnit { get; set; } = string.Empty;

        [Required(ErrorMessage = "Unit Price is required")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Units In Stock is required")]
        public int UnitsInStock { get; set; }

        [Required(ErrorMessage = "Units On Order is required")]
        public int UnitsOnOrder { get; set; }

        [Required(ErrorMessage = "Reorder Level is required")]
        public int ReorderLevel { get; set; }

        [Required(ErrorMessage = "Discontinued is required")]
        public int Discontinued { get; set; }
    }
}
