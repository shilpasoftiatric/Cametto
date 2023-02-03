using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cametto.Models
{
    public class BillerViewModel
    {
        public int Id { get; set; }
        public int RestrurantId { get; set; }
        public CustomerModel Customer { get; set; }
        public BillModel Bill { get; set; }
        public Order? Order { get; set; }
        public List<CustomerModel>? CustomerList { get; set; }
        public List<SelectListItem>? RestrurantList { get; set; }
        public string? Address { get; set; }
        public FullAddress? FullAddress { get; set; }
        public string? HomeAddress { get; set; }
        public string? OfficeAddress { get; set; }
        public FoodItem? FoodItem { get; set; }
        public List<FoodItem>? FoodItemList { get; set; }
        public List<Order>? Orders { get; set; }
        public List<OrderLine>? OrderLines { get; set; }
        public Registration Registration { get; set; }
        public List<SelectListItem>? RegistrationList { get; set; }
    }
}
