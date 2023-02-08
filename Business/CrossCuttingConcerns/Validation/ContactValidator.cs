using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c. Id).GreaterThan(0);

            RuleFor(c => c.Heading).NotEmpty();
            RuleFor(c => c.Heading).MaximumLength(30);

            RuleFor(c => c.Content).NotEmpty();
            RuleFor(c => c.Content).MaximumLength(100);

            RuleFor(c => c.dataPosted).NotEmpty();

            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.UserId).GreaterThan(0);

        }
    }
}
