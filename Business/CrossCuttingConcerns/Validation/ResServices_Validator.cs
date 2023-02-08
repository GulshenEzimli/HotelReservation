using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ResServices_Validator : AbstractValidator<Res_Services>
    {
        public ResServices_Validator()
        {
            RuleFor(rs => rs.Id).NotEmpty();

            RuleFor(rs => rs.Res_Id).NotEmpty();
            RuleFor(rs => rs.Res_Id).GreaterThan(0);

            RuleFor(rs => rs.Ser_Id).NotEmpty();
            RuleFor(rs => rs.Ser_Id).GreaterThan(0);

            RuleFor(rs => rs.Quantity).NotEmpty();
            RuleFor(rs => rs.Quantity).GreaterThan(0);
        }
    }
}
