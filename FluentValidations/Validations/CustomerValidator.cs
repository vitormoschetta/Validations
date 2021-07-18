using FluentValidation;
using FluentValidations.Models;

namespace FluentValidations.Validations
{
    // Em projetos reais geralmente aplicamos as validações nos Commands, uma vez que 
    // operações diferentes (create, update, etc) requerem validações diferentes
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("'Customer.Id' não pode ser vazio.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("'Customer.Name' precisa ser informado.");
            RuleFor(x => x.Name).Length(5, 50).WithMessage("'Customer.Name' precisa ter entre 5 e 10 caracteres");
            RuleFor(x => x.Age).NotNull().WithMessage("'Customer.Age' precisa ser informado.");
            RuleFor(x => x.Age).InclusiveBetween(18, 60).WithMessage("'Customer.Age' - Precisa ser maior de idade.");

            RuleFor(x => x.Address).SetValidator(new AddressValidator());
        }
    }
}