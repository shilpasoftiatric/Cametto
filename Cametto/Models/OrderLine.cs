using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class OrderLine
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderLineId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal TotalPrice { get; set; }
        public virtual Order Order { get; set; }
    }
}
