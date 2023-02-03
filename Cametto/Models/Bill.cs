using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class BillModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FoodItem")]
        public int FoodItemId { get; set; }
        public int Quantity { get; set; }


        [Column(TypeName = "decimal(18,2)")]

        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]


        public decimal Total { get; set; }


        [Column(TypeName = "decimal(18,2)")]

        public decimal Gst { get; set; }
    }
}
