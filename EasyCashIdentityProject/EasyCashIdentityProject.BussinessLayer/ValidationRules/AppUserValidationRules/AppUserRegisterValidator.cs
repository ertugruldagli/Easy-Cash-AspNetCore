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
    }
}
