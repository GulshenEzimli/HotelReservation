using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator() 
        {
            RuleFor(r=>r.Id).NotEmpty();

            RuleFor(r => r.UserId).NotEmpty();
            RuleFor(r=>r.UserId).GreaterThan(0);

            RuleFor(r => r.RoomId).NotEmpty();
            RuleFor(r => r.RoomId).GreaterThan(0);

            RuleFor(r => r.checkIn).NotEmpty();

            RuleFor(r => r.res_Date).NotEmpty();

            RuleFor(r => r.totalCost).NotEmpty();
            RuleFor(r => r.totalCost).GreaterThan(0);

            RuleFor(r => r.dayCount).NotEmpty();
            RuleFor(r => r.dayCount).GreaterThan(0);

        }
    }
}
