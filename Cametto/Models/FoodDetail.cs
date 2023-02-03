using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class FoodDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public string OrderId { get; set; }
        public string FoodItemId { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
