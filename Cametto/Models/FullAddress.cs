using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class FullAddress
    {
        [Key]
        public int Id { get; set; }
        public string AddressType { get; set; }
        public string Address { get; set; }
    }
}
