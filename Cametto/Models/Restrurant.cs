using System.ComponentModel.DataAnnotations;

namespace Cametto.Models
{
    public class Restrurant
    {

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<FoodItem> FoodItems { get; set; }
    }
}
