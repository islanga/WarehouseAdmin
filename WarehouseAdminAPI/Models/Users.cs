using System.ComponentModel.DataAnnotations;

namespace WarehouseAdminAPI.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
