using System.ComponentModel.DataAnnotations;

namespace WarehouseAdminAPI.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }

        [Required (ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact Name is required")]
        public string ContactName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact Title is required")]
        public string ContactTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Region is required")]
        public string Region { get; set; } = string.Empty;

        [Required(ErrorMessage = "PostalCode is required")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Fax is required")]
        public string Fax { get; set; } = string.Empty;

        [Required(ErrorMessage = "HomePage is required")]
        public string HomePage { get; set; } = string.Empty;
    }
}
