using Microsoft.CodeAnalysis.CSharp.Syntax;
using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class ProductInformation:BaseEntity
    {
        public string Information { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
    }
}
