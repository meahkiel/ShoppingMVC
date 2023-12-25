namespace WebApplication1.Models
{
    public class Catalog
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

        public string Category { get; set; } = "";
        public decimal Price { get; set; }


    }
}
