using System;
using FluentValidations.Models;
using FluentValidations.Validations;

namespace FluentValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            var addres = new Address("Rua Tucuruí", 0, "Porto Velho", "Rondônia");
            var customer = new Customer("Produto X", 17, addres);

            var validationResult = new CustomerValidator().Validate(customer);

            if (!validationResult.IsValid)
            {
                Console.WriteLine(string.Join(" | ", validationResult.Errors));
                return;
            }

            Console.WriteLine("Produto é válido!");
        }
    }
}
