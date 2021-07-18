using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidations.Models
{
    public class Customer : Notifiable<Notification>
    {
        public Customer(string name, int age, Address address, Guid id = new Guid())
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;

            if (Id == Guid.Empty)
                Id = Guid.NewGuid();

            Validate();
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Address Address { get; private set; }


        public void Validate()
        {
            AddNotifications(new Contract<Customer>()
                .Requires()
                .IsNotEmpty(Id, "Customer.Id", "não pode ser vazio.")
                .IsNotNullOrEmpty(Name, "Customer.Name", "precisa ser informado.")
                .IsGreaterThan(Name, 4, "Customer.Name", "precisa ter no mínimo 5 caracteres.")
                .IsNotNull(Age, "Customer.Age", "precisa ser informado")
                .IsBetween(Age, 18, 60, "Customer.Age", "precisa ser maior de idade.")
            );

            AddNotifications(Address.Notifications);
        }
    }
}