using System;
using FluntValidations.Models;

namespace FluntValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            var addres = new Address("Rua Tucuruí", 0, "Porto Velho", "Rondônia");
            var customer = new Customer("Vitor Moschetta", 17, addres);

            if (!customer.IsValid)
            {
                foreach (var notification in customer.Notifications)
                    Console.WriteLine("'{0}' {1}", notification.Key, notification.Message);

                return;
            }

            Console.WriteLine("Customer is valid!");
        }
    }
}
