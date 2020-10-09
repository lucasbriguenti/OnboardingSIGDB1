﻿using FluentValidation;
using OnboardingSIGDB1.Domain.Models;

namespace OnboardingSIGDB1.Domain.Services.Validators
{
    public class FuncionarioCargoValidator : AbstractValidator<FuncionarioCargo>
    {
        public FuncionarioCargoValidator()
        {
            RuleFor(x => x.DataVinculo).NotEmpty().WithMessage("Data vinculo obrigatório");
        }
    }
}