using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BussinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Lütfen boş bırakmayiniz..");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen boş bırakmayiniz..");

        }
    
    }
}
