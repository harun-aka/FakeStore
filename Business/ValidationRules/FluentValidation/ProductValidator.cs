using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MinimumLength(3);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Category).NotEmpty();
            RuleFor(p => p.Image).NotEmpty();
        }
    }
}
