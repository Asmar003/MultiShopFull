using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public int CostPrice { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public int DiscountId { get; set; }
        public int ProductInformationId { get; set; }
        public ProductInformation ProductInformation { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
