using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsPrimay { get; set; }
    }
}
