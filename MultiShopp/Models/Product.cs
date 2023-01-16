using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int SellPrice { get; set; }
        public int CostPrice { get; set; }
        public string Description { get; set; }
        public ICollection<Size> Sizes { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
