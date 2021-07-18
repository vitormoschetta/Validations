using System;

namespace FluentValidations.Models
{
    public class Customer
    {
        public Customer(string name, int age, Address address, Guid id = new Guid())
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;

            if (Id == Guid.Empty)
                Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Address Address { get; set; }
    }
}