using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class TypesValidator : AbstractValidator<Types>
    {
        public TypesValidator()
        {
            RuleFor(t => t.Id).NotEmpty();

            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Name).MinimumLength(5);
            RuleFor(t => t.Name).Must(NameValidation.InvalidName);
        }
    }
}
