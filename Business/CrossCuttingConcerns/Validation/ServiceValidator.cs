using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s=>s.Id).NotEmpty();

            RuleFor(s => s.Name).NotEmpty();
            RuleFor(s => s.Name).MinimumLength(3);
            RuleFor(s => s.Name).Must(NameValidation.InvalidName);
            RuleFor(s => s.Name.Trim()).NotEmpty();

            RuleFor(s => s.Price).NotEmpty();
            RuleFor(s => s.Price).GreaterThan(0);
        }

        
    }
}
