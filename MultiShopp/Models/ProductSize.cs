using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class ProductSize:BaseEntity
    {
        public int SizeId { get; set; }
        public Size Sizes { get; set; }
        public int ProductId {get; set; }
        public Product Products { get; set; }
    }
}
