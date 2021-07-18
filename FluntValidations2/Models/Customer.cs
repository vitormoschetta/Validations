using System;

namespace FluntValidations2.Models
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

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }        
    }
}