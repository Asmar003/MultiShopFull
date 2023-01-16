using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
