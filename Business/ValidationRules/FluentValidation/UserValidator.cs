using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim bilgisi boş bırakılamaz");
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            
        }
    }
}
