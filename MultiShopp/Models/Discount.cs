using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Discount:BaseEntity
    {
        public string Name { get; set; }
        public int DiscountPrice { get; set; }
        public ICollection<ProductInformation> ProductInformations { get;set; }
    }
}
