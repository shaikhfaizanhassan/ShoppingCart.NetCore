namespace Shopping_cart.Models.ImageModel
{
    public class CreateImageModel
    {
        public int PID { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public string PDesc { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public IFormFile ImagePath { get; set; }
    }
}
