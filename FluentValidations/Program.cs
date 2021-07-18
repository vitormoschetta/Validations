using System;
using FluentValidations.Models;
using FluentValidations.Validations;

namespace FluentValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("Rua Tucuruí", 0, "Porto Velho", "Rondônia");
            var customer = new Customer("Produto X", 17, address);

            var validationResult = new CustomerValidator().Validate(customer);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                    Console.WriteLine(error.ErrorMessage);

                return;
            }

            Console.WriteLine("Produto é válido!");
        }
    }
}
