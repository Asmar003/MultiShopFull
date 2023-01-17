using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Discount:BaseEntity
    {
        public string Name { get; set; }
        public double Percent { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
