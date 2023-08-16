using System.ComponentModel.DataAnnotations;

namespace Shopping_cart.Models
{
    public class Brand
    {
        [Key]
        public int BId { get; set; }
        public string BName { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
