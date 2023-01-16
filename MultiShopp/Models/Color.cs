using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
