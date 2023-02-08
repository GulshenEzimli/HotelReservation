using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(a => a.Id).NotEmpty();

            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Name.Trim()).NotEmpty();
            RuleFor(a => a.Name).MinimumLength(3);
            RuleFor(a => a.Name).Must(NameValidation.InvalidName);

            RuleFor(a => a.Username).NotEmpty();
            RuleFor(a => a.Username).MinimumLength(6);
            RuleFor(a => a.Username.Trim()).NotEmpty();

            RuleFor(a => a.Password).NotEmpty();
            RuleFor(a => a.Password.Trim()).NotEmpty();
            RuleFor(a => a.Password).MinimumLength(8);
        }
    }
}
