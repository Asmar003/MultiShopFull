using MultiShopp.Models.Base;

namespace MultiShopp.Models
{
    public class Setting:BaseEntity
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }
}
