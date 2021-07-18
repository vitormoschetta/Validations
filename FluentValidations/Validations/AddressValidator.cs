using FluentValidation;
using FluentValidations.Models;

namespace FluentValidations.Validations
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Street).NotEmpty().WithMessage("'Address.Street' precisa ser informado.");
            RuleFor(x => x.Number).GreaterThan(0).WithMessage("'Address.Number' não pode conter valor 0 (zero).");
            RuleFor(x => x.City).NotEmpty().WithMessage("'Address.City' precisa ser informado.");
            RuleFor(x => x.State).NotEmpty().WithMessage("'Address.State' precisa ser informado.");
        }
    }
}