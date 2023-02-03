using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class Address
    {

        public enum AddressType
        {
            Home = 1,
            Office = 2


        }

        public class AddressModel
        {
            [Key]
            public int Id { get; set; }

            [ForeignKey("Customer")]
            public int CustomerId { get; set; }



            public string? Address1 { get; set; }
            public string? Address2 { get; set; }



            public AddressType AddressType { get; set; }





            public virtual CustomerModel? Customer { get; set; }
        }
    }
}
