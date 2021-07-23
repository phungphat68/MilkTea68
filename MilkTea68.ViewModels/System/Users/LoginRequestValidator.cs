using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password name is required")
                .MinimumLength(6).WithMessage("Pass word is at least 6 character");
        }
    }
}