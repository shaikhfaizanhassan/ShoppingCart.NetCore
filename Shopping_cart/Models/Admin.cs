using System.ComponentModel.DataAnnotations;

namespace Shopping_cart.Models
{
    public class Admin
    {
        [Key]
        public int AId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
