using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Slider:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
