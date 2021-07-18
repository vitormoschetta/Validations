using Flunt.Notifications;
using Flunt.Validations;
using FluntValidations2.Models;

namespace FluntValidations2.Validations
{
    public class CustomerValidator : Notifiable<Notification>
    {
        public CustomerValidator(Customer customer)
        {
            AddNotifications(new Contract<Customer>()
                .Requires()
                .IsNotEmpty(customer.Id, "Customer.Id", "não pode ser vazio.")
                .IsNotNullOrEmpty(customer.Name, "Customer.Name", "precisa ser informado.")
                .IsGreaterThan(customer.Name, 4, "Customer.Name", "precisa ter no mínimo 5 caracteres.")
                .IsNotNull(customer.Age, "Customer.Age", "precisa ser informado")
                .IsBetween(customer.Age, 18, 60, "Customer.Age", "precisa ser maior de idade.")
            );

            AddNotifications(new AddressValidator(customer.Address));            
        }
    }
}