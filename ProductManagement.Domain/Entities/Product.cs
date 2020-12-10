using ProductManagement.Domain.Enums;

namespace ProductManagement.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
    }
}
