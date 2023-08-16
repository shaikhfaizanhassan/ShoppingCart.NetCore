using System.ComponentModel.DataAnnotations;

namespace Shopping_cart.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
