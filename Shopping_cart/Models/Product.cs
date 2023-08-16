using System.ComponentModel.DataAnnotations;

namespace Shopping_cart.Models
{
    public class Product
    {
        [Key]
        public int PID { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public string PDesc { get; set; }
        //Foreign Key

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //Foreign Key
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public string ImagePath { get; set; }
    }
}
