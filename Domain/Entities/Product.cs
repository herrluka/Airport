namespace Domain.Entities
{
    public class Product
    {
        public required string Id { get; init; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public string? ImageFile { get; set; }
        public required decimal Price { get; set; }


    }
}
