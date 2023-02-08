using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Id).NotEmpty();

            RuleFor(r => r.TypeId).NotEmpty();
            RuleFor(r => r.TypeId).GreaterThan(0);

            RuleFor(r => r.Price).NotEmpty();
            RuleFor(r => r.Price).GreaterThan(0);

            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Name.Trim()).NotEmpty();

            RuleFor(r => r.MaxOccupants).NotEmpty();
            RuleFor(r => r.MaxOccupants).GreaterThan(0);

            RuleFor(r => r.Rate).NotEmpty();
            RuleFor(r => r.Rate).GreaterThanOrEqualTo(0).LessThanOrEqualTo(5);

            RuleFor(r => r.Area).NotEmpty();
            RuleFor(r => r.Area).GreaterThan(4);
        }
    }
}
