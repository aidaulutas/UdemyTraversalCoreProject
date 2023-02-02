using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Descrition can't stay empty!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Choose a photo!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Must be grater than 50 characters!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Use up to 1500 characters!"); 

        }
    }
}
