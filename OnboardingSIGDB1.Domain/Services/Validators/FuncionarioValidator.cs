﻿using FluentValidation;
using OnboardingSIGDB1.Models.Classes;
using System;

namespace OnboardingSIGDB1.Domain.Services.Validators
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(x => x.Cpf).IsValidCPF().NotEmpty().MaximumLength(14);
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome obrigatório");
            RuleFor(x => x.Nome).MaximumLength(150).WithMessage("Nome deve ter menos que 150 caracteres");
        }
    }
}
