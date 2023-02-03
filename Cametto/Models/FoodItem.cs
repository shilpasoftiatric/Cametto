using System.ComponentModel.DataAnnotations.Schema;

namespace Cametto.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        [ForeignKey("Restrurant")]
        public int RestrurantId { get; set; }
        public string? Item { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal price { get; set; }
        public string? Image { get; set; }
        public bool IsSelected { get; set; }
    }
}
