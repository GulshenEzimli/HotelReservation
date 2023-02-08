using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).NotEmpty();

            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName.Trim()).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(4);
            RuleFor(u => u.LastName).Must(NameValidation.InvalidName);

            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName.Trim()).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(4);
            RuleFor(u => u.FirstName).Must(NameValidation.InvalidName);

            RuleFor(u => u.Username).NotEmpty();
            RuleFor(u => u.Username.Trim()).NotEmpty();
            RuleFor(u => u.Username).MinimumLength(8);

            RuleFor(u => u.Age).NotEmpty();
            RuleFor(u => u.Age).GreaterThan(0);

            RuleFor(u => u.Phone).NotEmpty();
            RuleFor(u => u.Phone.Trim()).NotEmpty();
            RuleFor(u => u.Phone).MinimumLength(8);

            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email.Trim()).NotEmpty();
            RuleFor(u => u.Email).MinimumLength(15);

            RuleFor(u => u.Address).NotEmpty();
            RuleFor(u => u.Address.Trim()).NotEmpty();

            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password.Trim()).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
        }
    }
}
