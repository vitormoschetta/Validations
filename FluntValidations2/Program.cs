using System;
using FluntValidations2.Models;
using FluntValidations2.Validations;

namespace FluntValidations2
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("Rua Tucuruí", 0, "Porto Velho", "Rondônia");
            var customer = new Customer("Produto X", 17, address);

            var validationResult = new CustomerValidator(customer);

            if (!validationResult.IsValid)
            {
                foreach (var notification in validationResult.Notifications)
                    Console.WriteLine("'{0}' {1}", notification.Key, notification.Message);

                return;
            }

            Console.WriteLine("Produto é válido!");
        }
    }
}
