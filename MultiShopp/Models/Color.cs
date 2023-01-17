using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
