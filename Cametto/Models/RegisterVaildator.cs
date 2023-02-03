using FluentValidation;

namespace Cametto.Models
{
    public class RegisterVaildator : AbstractValidator<Registration>
    {
        public RegisterVaildator()
        {
            RuleFor(x => x.UserName).NotEmpty().NotNull().WithMessage("UserName Is Required");
            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Password Is Required");
            RuleFor(x => x.PhoneNumber).MaximumLength(10).WithMessage("PhoneNumber Must be 10 numbers");
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Email Is Required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email Address Is Not Correct");
            RuleFor(x => x.PhoneNumber).NotEmpty().NotNull().WithMessage("PhoneNumber Is Required");
            RuleFor(x => x.Password).Must(PAssword_Length).WithMessage("Password Length must be equal or greater than 8");
        }
        private bool PAssword_Length(string pass_)
        {


            if (pass_.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
