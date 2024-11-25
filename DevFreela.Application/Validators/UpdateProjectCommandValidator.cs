using DevFreela.Application.Commands.CreateUser;
using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(255)
                .WithMessage("Tamanho máximo da descrição é de 255 caracteres.");

            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Tamanho máximo do título é de 30 caracteres.");

            RuleFor(p => p.TotalCost)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("O custo total deve ser maior que zero.");
        }
    }
}
