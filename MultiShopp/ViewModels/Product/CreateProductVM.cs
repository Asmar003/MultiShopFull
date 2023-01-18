using MultiShopp.Models;

namespace MultiShopp.ViewModels.Product
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public int CostPrice { get; set; }
    }
}
