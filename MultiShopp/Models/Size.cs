using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
    }
}
