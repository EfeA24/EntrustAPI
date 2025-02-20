using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; } = null!;

        [Required]
        public int ItemQuantity { get; set; }
    }
}