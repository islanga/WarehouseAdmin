using System.ComponentModel.DataAnnotations;

namespace WarehouseAdmin.Models
{
    public class Categories
    {
        //        public int CategoryID { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category Name is required field")]
        public string CategoryName { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required field")]
        public string Description { get; set; } = string.Empty;
    }
}
