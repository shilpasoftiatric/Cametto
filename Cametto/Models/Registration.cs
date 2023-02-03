using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class Registration
    {
        [Key]
        public int RegisterId { get; set; }


        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
