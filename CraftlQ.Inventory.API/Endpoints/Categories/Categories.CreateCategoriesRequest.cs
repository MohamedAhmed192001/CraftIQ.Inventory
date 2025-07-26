using System.ComponentModel.DataAnnotations;

namespace CraftlQ.Inventory.API.Endpoints.Categories
{
    public class CreateCategoriesRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}