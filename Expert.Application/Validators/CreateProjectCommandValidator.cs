﻿using Expert.Application.Commands.CreateProject;
using FluentValidation;

namespace Expert.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description).MaximumLength(255).WithMessage("Tamanho máximo da descrição é de 255 caracteres");

            RuleFor(p => p.Title).MaximumLength(30).WithMessage("Tamanho máximo do título é de 30 caracteres");

        }
    }
}
