using System.ComponentModel.DataAnnotations;
using static Cametto.Models.Address;

namespace Cametto.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            Address = new List<AddressModel>();
        }
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }





        public ICollection<AddressModel> Address { get; set; }

        public void AddAddress(AddressModel model)
        {
            Address.Add(model);
        }

    }
}

