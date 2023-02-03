using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string OrderNo { get; set; }

        public int CustomerId { get; set; }
        public string Address { get; set; }

        public int RestrurantId { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Total { get; set; }


        [Column(TypeName = "decimal(18,2)")]

        public decimal Gst { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal GrandTotal { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
