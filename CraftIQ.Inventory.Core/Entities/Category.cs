namespace CraftIQ.Inventory.Core.Entities
{
    public class Category : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();


        public Category(string name, string description)
        {
            CategoryId = Guid.NewGuid();
            Name = name;
            Description = description;

            CreatedBy = Guid.NewGuid();
            CreatedOn = DateTimeOffset.UtcNow;
            ModifiedBy = Guid.NewGuid();
            ModifiedOn = DateTimeOffset.UtcNow;

        }
    }
}
