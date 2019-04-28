using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });
            
            RuleFor(c => c.nome)
                .NotEmpty().WithMessage("Is necessary to inform the Nome.")
                .NotNull().WithMessage("Is necessary to inform the Nome.");

        }
    }
}
