using FluentValidation;

namespace Cametto.Models
{
    public class BillVaildator : AbstractValidator<BillerViewModel>
    {
        public BillVaildator()
        {
            //RuleFor(u => u.Customer.Name).NotNull().NotEmpty().WithMessage("Customer Name Is Required");
            //RuleFor(u => u.RestrurantId).NotNull().NotEmpty().WithMessage("Select RestrurantId  First");
            //RuleFor(u => u.FoodItemList).NotNull().NotEmpty()
            //    .Must(x => x.Count>0)
            //    .WithMessage("At least one  should be selected");
            //RuleFor(u => u.FoodItemList).NotNull()
            //    .WithMessage("Food Item Is Required")
            //    .Must(fooditemlist => fooditemlist.Count > 0).WithMessage("Select at least one");
            //  RuleFor(vm => vm.FoodItemList)
            // .Must((vm, FoodItem) => FoodItem.Count > 0)
            //.WithMessage("At least one FoodItem is required");
            // RuleFor(x => x.Address).NotNull().NotEmpty().WithMessage("Address Is Required");
            //RuleFor(x => x.FoodItemList).Must(FoodItem_Select).WithMessage("Select at list one");

            //private bool FoodItem_Select(string pass_)
            //{


            //    if (FoodItem_Select < 8)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //    RuleFor(u => u.FoodItemList).Must(Vaildate_FoodItem).WithMessage("Select Atleast One FoodItem ");
            //}
            //private bool Vaildate_FoodItem(List<T>)
            //{
            //    if(string.IsNullOrWhiteSpace(_food))
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            RuleFor(x => x.FoodItemList).NotNull().When(x => x.FoodItem.IsSelected == true).WithMessage("select one");
        }
    }
    }

