using Cametto.Data;
using Cametto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static Cametto.Models.Address;

namespace Cametto.Controllers
{
    public class BillGeneratorController : Controller
    {
        private ApplicationDbContext _context;

        public BillGeneratorController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(int id = 0)

        {


            BillerViewModel viewModel = new BillerViewModel();
            var reg = _context.Registrations.Select(x => new SelectListItem { Value = x.RegisterId.ToString(), Text = x.UserName }).ToList();
            ViewBag.RegistrationList = reg;
            viewModel.RegistrationList = reg;


            var restrurantList = _context.Restrurants.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Title }).ToList();



            ViewBag.RestrurantList = restrurantList;
            viewModel.RestrurantList = restrurantList;
            viewModel.FoodItemList = new List<FoodItem>();


            //CustomerModel customerModel =  new CustomerModel();
            //customerModel.CustomerId = 1;
            //customerModel.Name = "Shagun";
            // var customer = _context.CustomerModels.Select(x => new SelectListItem { Value = x.CustomerId.ToString(), Text = x.Name }).ToList();
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel{ CustomerId=1,Name="Shagun"},
                new CustomerModel{CustomerId=2,Name="Ramesh"},
                new CustomerModel{CustomerId=3,Name= "Suresh"}

            };




            viewModel.CustomerList = customers;


            AddressModel home = new AddressModel();
            home.AddressType = AddressType.Home;
            home.Address1 = "Derabassi";
            home.Address2 = " Mannat 1131Sbp Housing Park";
            home.CustomerId = 1;

            string HomeAddress = string.Join(",", home.Address1, home.Address2, home.CustomerId);
            viewModel.HomeAddress = HomeAddress;





            AddressModel office = new AddressModel();
            office.AddressType = AddressType.Office;
            office.Address1 = "Zirkpur";
            office.Address2 = "BLock D/E CCC";
            office.CustomerId = 1;
            string OfficeAddress = string.Join(",", office.Address1 + office.Address2 + office.CustomerId);

            viewModel.OfficeAddress = OfficeAddress;


            //var autoId = _context.Orders.OrderByDescending(x => x.OrderId).FirstOrDefault();

            //Order order = new Order()
            //{
            //    OrderNo = autoId.OrderNo + 1.ToString(),
            //    Date = DateTime.Now,




            //};


            //viewModel.Order = order;



            return View(viewModel);
        }




        public PartialViewResult Foods(int id)
        {
            BillerViewModel viewModel = new BillerViewModel();
            var foodlist = _context.FoodItems.Where(x => x.RestrurantId == id).Select(x => new FoodItem()
            {
                Id = x.Id,
                Image = x.Image,
                Item = x.Item,
                price = x.price,
                RestrurantId = x.RestrurantId,
            }).ToList();
            viewModel.FoodItemList = foodlist;


            return PartialView("_FoodListItem", viewModel);
        }







        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BillerViewModel billerViewModel)
        {

            if (ModelState.IsValid)

            {

                Order order = new Order
                {

                    OrderNo = DateTime.Now.Ticks.ToString(),
                    Date = DateTime.Now,
                    RestrurantId = billerViewModel.RestrurantId,
                    Address = billerViewModel.Address,
                    CustomerId = billerViewModel.Customer.CustomerId,
                    Total = 0,

                    Gst = 20,
                    GrandTotal = 0,


                };

                order.OrderLines = new List<OrderLine>();

                foreach (var item in billerViewModel.FoodItemList)

                {
                    OrderLine orderLine = new OrderLine
                    {

                        Item = item.Item,
                        Quantity = billerViewModel.Bill.Quantity,
                        Price = item.price,
                        TotalPrice = item.price * billerViewModel.Bill.Quantity,


                    };
                    order.OrderLines.Add(orderLine);
                }
                _context.Orders.Add(order);
                _context.SaveChanges();

            }
            //    List<OrderLine> lines = new List<OrderLine>();
            //for (int i = 0; i < lines.Count; i++)
            //{
            //    OrderLine orderLine = new OrderLine()
            //    {
            //        OrderId = order.OrderId,
            //        Item = lines[i].Item,
            //        Quantity = lines[i].Quantity,
            //        Price = lines[i].Price,
            //        // TotalPrice = lines[i].Item * billerViewModel.Bill.Quantity,
            //    };
            //    order.OrderLines.Add(orderLine);
            //}
            //_context.Orders.Add(order);
            //_context.SaveChanges();





            return RedirectToAction("");
        }
        // return Create();
    }


    //[HttpGet]

    //public IActionResult Delete(int? id)
    //{
    //    if(id == null|| id== 0 )
    //    {
    //        return NotFound();
    //    }
    //    var Foodie = _context.FoodItems.Find(id);
    //    if(Foodie== null)
    //    {
    //        return NotFound();
    //    }
    //    return View(Foodie);  
    //}
    //[HttpPost,ActionName("Delete")]
    //[ValidateAntiForgeryToken]

    //public IActionResult DeleteData(int? id)
    //{
    //    if(ModelState.IsValid)
    //    {
    //        var Foo = _context.FoodItems.Find(id);  
    //        if(Foo==null)
    //        {
    //            return NotFound();
    //        } 
    //        _context.FoodItems.Remove(Foo); 
    //    }
    //    return RedirectToAction("Index");
    //}

}

//}



