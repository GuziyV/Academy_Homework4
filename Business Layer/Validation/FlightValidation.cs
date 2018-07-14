using Data_Access_Layer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Validation
{
    public class FlightValidation : AbstractValidator<Flight>
    {
        public FlightValidation()
        {
            RuleFor(f => f.Number).NotEqual(0);
            RuleFor(f => f.DepartureFrom).NotEmpty();
            RuleFor(f => f.Destination).NotEmpty();
        }
    }
}
