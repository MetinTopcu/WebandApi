using NLayer.Core;

namespace NLayer.Core
{
    public class Category : BaseEntity
    {
        public string name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}